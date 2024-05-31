using FootballContractsHistory.Models;
using System.ComponentModel;
using System.Data;

namespace FootballContractsHistory
{
    public partial class frmPlayers : Form
    {
        private frmMDI mdiParentForm;
        private frmSearchPlayers searchPlayersForm;
        private Player playerToUpdate;
        private FormState currentState;

        public frmPlayers()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }

        private void frmPlayers_Load(object sender, EventArgs e)
        {
            currentState = FormState.Register;
            Task.Factory.StartNew(() => LoadPositions());
            mdiParentForm.SetToolStrip("Ready...", true);
        }
        private void LoadState(FormState state)
        {
            if (state == FormState.Register)
            {
                btnRegister.Text = "Register";
                ClearControls(groupBox1.Controls);
            }
            else if (state == FormState.Update)
            {
                btnRegister.Text = "Update";
            }
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
                            combo.SelectedIndex = 0;
                            break;
                        case GroupBox groupBox:
                            ClearControls(groupBox.Controls);
                            break;
                    }
                }
            });
        }
        private void LoadPositions()
        {
            Position p = new Position();
            DataTable dtPositions = p.GetPositions();
            dtPositions.AddEmptyRow("Name", "Position_ID");

            Invoke((MethodInvoker)delegate
            {
                cbxPosition.Bind("Name", "Position_ID", dtPositions);
            });
        }

        private void btnRegisterUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPlayer.Text) && cbxPosition.SelectedIndex != 0)
                {
                    if (currentState == FormState.Register)
                    {
                        Player p = new Player(txtPlayer.Text, Convert.ToInt32(cbxPosition.SelectedValue));
                        var response = p.CreatePlayer(p);
                        if (response)
                        {
                            txtPlayer.Text = string.Empty;
                            cbxPosition.SelectedIndex = 0;
                            mdiParentForm.SetToolStrip("Player registered successfully.", true);
                        }
                        else
                        {
                            mdiParentForm.SetToolStrip("Error creating player.", true);
                        }
                    } else if (currentState == FormState.Update)
                    {
                        Player p = new Player(playerToUpdate.PlayerId, txtPlayer.Text, Convert.ToInt32(cbxPosition.SelectedValue));
                        var response = p.UpdatePlayer(p);
                        if (response)
                        {
                            //SetState(FormState.Register);
                            mdiParentForm.SetToolStrip("Player updated successfully.", true);
                        }
                        else
                        {
                            mdiParentForm.SetToolStrip("Error updating player.", false);
                        }
                    }
                } else
                {
                    mdiParentForm.SetToolStrip("Please complete the Player Full Name and Position.", false);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void ShowFrmSearchPlayers()
        {
            searchPlayersForm = new frmSearchPlayers
            {
                MdiParent = mdiParentForm,
                WindowState = FormWindowState.Normal,
                Bounds = mdiParentForm.Bounds
            };
            searchPlayersForm.FormClosed += frmSearchPlayers_FormClosed!;
            searchPlayersForm.Show();
            
        }
        private void pbxSearch_Click(object sender, EventArgs e)
        {
            ShowFrmSearchPlayers();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls(groupBox1.Controls);
            mdiParentForm.SetToolStrip("Ready...", true);
            SetState(FormState.Register);
        }
        private void pbxBack_Click(object sender, EventArgs e)
        {
            if(searchPlayersForm != null)
                searchPlayersForm.Close();

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
        }
        private void cbx_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;

            ComboBox combobox = (ComboBox)sender;

            if (combobox.SelectedIndex == -1 || combobox.SelectedIndex == 0)
            {
                errorMessage = $"{combobox.Tag} is required.";
            }

            errorProvider1.SetError(combobox, errorMessage);
        }
        private void frmSearchPlayers_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            if (searchPlayersForm.playerSearched != null)
            {
                playerToUpdate = searchPlayersForm.playerSearched;
                txtPlayer.Text = playerToUpdate.PlayerName;
                cbxPosition.SelectedValue = playerToUpdate.PositionId;
                SetState(FormState.Update);
                
            }
        }
        private void SetState(FormState state)
        {
            currentState = state;
            LoadState(state);
        }
    }
}
