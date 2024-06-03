using FootballContractsHistory.Models;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Xml.Linq;

namespace FootballContractsHistory
{
    public partial class frmPlayers : Form
    {
        private int currentPlayerId;
        private int firstPlayerId;
        private int lastPlayerId;
        private int? nextPlayerId;
        private int? previousPlayerId;
        private int rowNumber;

        private frmMDI mdiParentForm;
        private Player playerToUpdate;
        private FormState currentState;

        public frmPlayers()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }

        private bool PlayerIsSelected
        {
            get
            {
                return currentPlayerId > 0;
            }
        }
        private int TotalPlayerCount()
        {
            return cbxPlayers.Items.Count - 1;
        }

        private void frmPlayers_Load(object sender, EventArgs e)
        {
            LoadPlayers();
            LoadPositions();

            SetState(currentState);

            LoadFirstPlayer();
        }
        private void LoadPositions()
        {
            DataTable dtPositions = Position.GetPositions();
            dtPositions.AddEmptyRow("Name", "Position_ID");

            Invoke((MethodInvoker)delegate
            {
                cbxPosition.Bind("Name", "Position_ID", dtPositions);
            });

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetState(FormState.Add);
        }
        private void Navigation_Handler(object sender, EventArgs e)
        {
            mdiParentForm.SetToolStrip("", true);

            if (sender == btnFirst)
            {
                currentPlayerId = firstPlayerId;
            }
            else if (sender == btnLast)
            {
                currentPlayerId = lastPlayerId;
            }
            else if (sender == btnNext)
            {
                if (nextPlayerId != null)
                {
                    currentPlayerId = nextPlayerId.Value;
                }
                else
                {
                    MessageBox.Show("The last Player is currently displayed");
                }
            }
            else if (sender == btnPrevious)
            {
                if (previousPlayerId != null)
                {
                    currentPlayerId = previousPlayerId.Value;
                }
                else
                {
                    MessageBox.Show("The first Player is currently displayed");
                }
            }
            else
            {
                return;
            }

            PopulateFields();
        }
        private void LoadState(FormState state)
        {
            //btnClear.Enabled = state != FormState.View;

            if (state == FormState.Add || state == FormState.Register)
            {
                btnClear.Enabled = true;
                //EnablePlayerInput(true);
                btnRegisterUpdate.Text = "Register";
                ClearControls(groupBox1.Controls);
            }
            else
            {
                btnClear.Enabled = false;
                //EnablePlayerInput(false);
                btnRegisterUpdate.Text = "Update";
            }
            btnDelete.Enabled = state == FormState.Update;
        }
        private void btnRegisterUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (String.IsNullOrEmpty(txtId.Text))
                    {
                        RegisterPlayer();
                    }
                    else
                    {
                        UpdatePlayer();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void RegisterPlayer()
        {
            if (!String.IsNullOrEmpty(txtPlayer.Text) && cbxPosition.SelectedIndex != -1 && cbxPosition.SelectedIndex != 0)
            {
                Player p = new Player(txtPlayer.Text, Convert.ToInt32(cbxPosition.SelectedValue));
                var response = Player.CreatePlayer(p);
                if (response)
                {
                    MessageBox.Show("Player registered successfully.");
                    LoadPlayers();
                    LoadFirstPlayer();
                }
                else
                {
                    MessageBox.Show("Error creating player.");
                }
            }
        }
        private void UpdatePlayer()
        {
            if (!String.IsNullOrEmpty(txtPlayer.Text) && cbxPosition.SelectedIndex != -1 && cbxPosition.SelectedIndex != 0)
            {
                Player p = new Player(Convert.ToInt32(txtId.Text), txtPlayer.Text, Convert.ToInt32(cbxPosition.SelectedValue));
                var response = Player.UpdatePlayer(p);
                if (response)
                {
                    //SetState(FormState.Register);
                    MessageBox.Show("Player updated successfully.");
                    LoadPlayers();
                    LoadFirstPlayer();
                }
                else
                {
                    MessageBox.Show("Error updating player.");
                }
            }
        }
        private void PopulateFields()
        {
            if (PlayerIsSelected)
            {
                DataRow selectedRow = GetPlayerRow(currentPlayerId);

                DisplayPlayer(selectedRow);

                mdiParentForm.SetToolStrip($"Displaying Player {rowNumber} of {TotalPlayerCount()}", true);
            }

            NavigationButtonManagement();
        }
        private void SetNavigationState(bool enable)
        {
            btnPrevious.Enabled = enable;
            btnNext.Enabled = enable;
            btnLast.Enabled = enable;
            btnFirst.Enabled = enable;
        }
        private void DisplayPlayer(DataRow productRow)
        {
            txtId.Text = productRow["Player_ID"].ToString();
            txtPlayer.Text = productRow["Name"].ToString();
            cbxPosition.SelectedValue = productRow["Position_ID"];
            dtpCreationDate.Text = productRow["Creation_Date"].ToString();

            LoadPlayers();

            cbxPlayers.SelectedValue = productRow["Player_ID"];

        }
        private DataRow GetPlayerRow(int playerID)
        {
            var dsPlayerInfo = Player.GetPlayersToLoadById(playerID);

            DataTable dtCurrentPlayer = dsPlayerInfo.Tables[0];
            DataTable dtPlayerPosition = dsPlayerInfo.Tables[1];
            LoadPlayerPositionInfo(dtPlayerPosition.Rows[0]);

            return dtCurrentPlayer.Rows[0];
        }
        private void LoadPlayerPositionInfo(DataRow PlayerPositionRow)
        {
            currentPlayerId = Convert.ToInt32(PlayerPositionRow["Player_ID"]);
            firstPlayerId = Convert.ToInt32(PlayerPositionRow["FirstPlayerID"]);
            lastPlayerId = Convert.ToInt32(PlayerPositionRow["LastPlayerID"]);
            rowNumber = Convert.ToInt32(PlayerPositionRow["RowNumber"]);

            nextPlayerId = PlayerPositionRow["NextPlayerID"] != DBNull.Value ?
                Convert.ToInt32(PlayerPositionRow["NextPlayerID"]) : null;

            if (PlayerPositionRow["PreviousPlayerID"] != DBNull.Value)
                previousPlayerId = Convert.ToInt32(PlayerPositionRow["PreviousPlayerID"]);
            else
                previousPlayerId = null;

        }
        private void ClearControls(Control.ControlCollection parentControl)
        {
            Invoke((MethodInvoker)delegate
            {
                foreach (Control control in parentControl)
                {
                    switch (control)
                    {
                        case TextBox textBox:
                            textBox.Text = string.Empty;
                            break;
                        case CheckBox checkBox:
                            checkBox.Checked = false;
                            break;
                        case ComboBox combo:
                            if (combo.Tag.ToString() != "search")
                                combo.SelectedIndex = 0;
                            break;
                        case GroupBox groupBox:
                            ClearControls(groupBox.Controls);
                            break;
                        case DateTimePicker dateTimePicker:
                            dateTimePicker.Value = DateTime.Today;
                            break;
                    }
                }
            });
        }

        private void LoadPlayers()
        {
            DataTable? dtPlayers = Player.GetPlayersToLoad();

            if (dtPlayers.Rows.Count > 0)
            {
                firstPlayerId = Convert.ToInt32(dtPlayers.Rows[0]["FirstPlayerID"]);
            lastPlayerId = Convert.ToInt32(dtPlayers.Rows[0]["LastPlayerID"]);
            }
            dtPlayers.AddEmptyRow("Name", "Player_ID");

            Invoke((MethodInvoker)delegate
            {
                cbxPlayers.Bind("Name", "Player_ID", dtPlayers);
            });
        }
        private void cbxPlayers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxPlayers.SelectedIndex != -1 && cbxPlayers.SelectedIndex != 0)
            {
                currentPlayerId = Convert.ToInt32(cbxPlayers.SelectedValue);

                //this is for debbuging and demo purposes, I wouldn't do this inside of a event handler
                DataRowView currentPlayer = cbxPlayers.SelectedItem as DataRowView;
                if (currentPlayer != null)
                {
                    Debug.WriteLine(currentPlayer["Player_ID"]);
                    Debug.WriteLine(currentPlayer["FirstPlayerID"]);
                    Debug.WriteLine(currentPlayer["LastPlayerID"]);
                    Debug.WriteLine(currentPlayer["RowNumber"]);
                    Debug.WriteLine(currentPlayer["NextPlayerID"]);
                    Debug.WriteLine(currentPlayer["PreviousPlayerID"]);
                    if (PlayerIsSelected)
                    {
                        PopulateFields();
                        SetState(FormState.Update);
                    }
                    else
                    {
                        MessageBox.Show("Please select a player to display");
                    }
                }
            }
        }
        private void NavigationButtonManagement()
        {
            SetNavigationState(false);
            if (currentPlayerId > 0)
            {
                SetState(FormState.Update);
            }

            btnPrevious.Enabled = previousPlayerId is not null;
            btnNext.Enabled = nextPlayerId is not null;

            btnFirst.Enabled = currentPlayerId != firstPlayerId;
            btnLast.Enabled = currentPlayerId != lastPlayerId;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls(groupBox1.Controls);
            mdiParentForm.SetToolStrip("Ready...", true);
            SetState(FormState.Register);
        }
        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;

            TextBox textBox = (TextBox)sender;

            if (textBox.Text == string.Empty)
            {
                errorMessage = $"{textBox.Tag} is required.";
            }

            errorProvider1.SetError(textBox, errorMessage);
            mdiParentForm.SetToolStrip("Please provide the Name and Description.", false);

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete the Player {txtPlayer.Text}?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeletePlayer();
            }
            LoadFirstPlayer();
        }
        private void LoadFirstPlayer()
        {
            currentPlayerId = Player.GetFirstPlayer();
            PopulateFields();
        }
        private void DeletePlayer()
        {
            var response = Player.DeletePlayer(Convert.ToInt32(txtId.Text));
            if (response)
            {
                MessageBox.Show("Player deleted successfully.");
            }
            else
            {
                MessageBox.Show("Error deleting Player.");
            }
        }
        private void SetState(FormState state)
        {
            currentState = state;
            LoadState(state);
        }
    }
}

