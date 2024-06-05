using FootballContractsHistory.Models;
using FootballContractsHistory.Views;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace FootballContractsHistory
{
    public partial class frmContracts : Form
    {
        private int currentContractId;
        private int firstContractId;
        private int lastContractId;
        private int? nextContractId;
        private int? previousContractId;
        private int rowNumber;

        private frmMDI mdiParentForm;
        private FormState currentState;

        public frmContracts()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }

        private bool ContractIsSelected
        {
            get
            {
                return currentContractId > 0;
            }
        }
        private int TotalContractCount()
        {
            return cbxContracts.Items.Count - 1;
        }

        private void frmContracts_Load(object sender, EventArgs e)
        {
            LoadContracts();
            LoadClubs();
            LoadPlayers();

            SetState(currentState);

            LoadFirstContract();
        }
        private void LoadClubs()
        {
            DataTable dtClubs = Club.GetClubs();
            dtClubs.AddEmptyRow("Club", "Club_ID");

            Invoke((MethodInvoker)delegate
            {
                cbxClubs.Bind("Club", "Club_ID", dtClubs);
            });

        }
        private void LoadPlayers()
        {
            DataTable dtPlayers = Player.GetPlayers();
            dtPlayers.AddEmptyRow("Player", "Player_ID");

            Invoke((MethodInvoker)delegate
            {
                cbxPlayers.Bind("Player", "Player_ID", dtPlayers);
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
                currentContractId = firstContractId;
            }
            else if (sender == btnLast)
            {
                currentContractId = lastContractId;
            }
            else if (sender == btnNext)
            {
                if (nextContractId != null)
                {
                    currentContractId = nextContractId.Value;
                }
                else
                {
                    MessageBox.Show("The last Contract is currently displayed");
                }
            }
            else if (sender == btnPrevious)
            {
                if (previousContractId != null)
                {
                    currentContractId = previousContractId.Value;
                }
                else
                {
                    MessageBox.Show("The first Contract is currently displayed");
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
                        RegisterContract();
                    }
                    else
                    {
                        UpdateContract();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void RegisterContract()
        {
            if (cbxClubs.SelectedIndex != -1 && cbxClubs.SelectedIndex != 0 &&
                cbxPlayers.SelectedIndex != -1 && cbxPlayers.SelectedIndex != 0)
            {
                var status = Player.VerifyPlayerContract(Convert.ToInt32(cbxPlayers.SelectedValue),
                    dtpStartDate.Value, dtpEndDate.Value);

                if (status == 0)
                {
                    Contract c = new Contract(Convert.ToInt32(cbxClubs.SelectedValue),
                        Convert.ToInt32(cbxPlayers.SelectedValue), dtpStartDate.Value, dtpEndDate.Value);
                    var response = Contract.CreateContract(c);
                    if (response)
                    {
                        MessageBox.Show("Contract registered successfully.");
                        LoadContracts();
                        LoadFirstContract();
                    }
                    else
                    {
                        MessageBox.Show("Error creating contract.");
                    }
                }
                else
                {
                    MessageBox.Show("These dates cross with the dates of the actual contract " +
                        "of this player.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateContract()
        {
            if (cbxClubs.SelectedIndex != -1 && cbxClubs.SelectedIndex != 0 &&
                cbxPlayers.SelectedIndex != -1 && cbxPlayers.SelectedIndex != 0)
            {
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;
                if (endDate <= DateTime.Now)
                {
                    MessageBox.Show("The contract cannot be updated, it has already ended."
                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if (startDate <= DateTime.Now)
                {
                    MessageBox.Show("The contract cannot be updated, it has already started.", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else { 
                        Contract c = new Contract(Convert.ToInt32(txtId.Text), Convert.ToInt32(cbxClubs.SelectedValue),
                    Convert.ToInt32(cbxPlayers.SelectedValue), dtpStartDate.Value, dtpEndDate.Value);
                        var response = Contract.UpdateContract(c);
                        if (response)
                        {
                            //SetState(FormState.Register);
                            MessageBox.Show("Contract updated successfully.");
                            LoadContracts();
                            LoadFirstContract();
                        }
                        else
                        {
                            MessageBox.Show("Error updating contract.");
                        }
                }
            }
        }
        private void PopulateFields()
        {
            if (ContractIsSelected)
            {
                DataRow selectedRow = GetContractRow(currentContractId);

                DisplayContract(selectedRow);

                mdiParentForm.SetToolStrip($"Displaying Contract {rowNumber} of {TotalContractCount()}", true);
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
        private void DisplayContract(DataRow productRow)
        {
            txtId.Text = productRow["Contract_ID"].ToString();
            cbxClubs.SelectedValue = productRow["Club_ID"];
            cbxPlayers.SelectedValue = productRow["Player_ID"];
            dtpStartDate.Text = productRow["Start_Date"].ToString();
            dtpEndDate.Text = productRow["End_Date"].ToString();
            dtpCreationDate.Text = productRow["Creation_Date"].ToString();


            LoadContracts();

            cbxContracts.SelectedValue = productRow["Contract_ID"];

        }
        private DataRow GetContractRow(int contractID)
        {
            var dsContractsInfo = Contract.GetContractsToLoadById(contractID);

            DataTable dtCurrentContract = dsContractsInfo.Tables[0];
            DataTable dtContractPosition = dsContractsInfo.Tables[1];
            LoadContractPositionInfo(dtContractPosition.Rows[0]);

            return dtCurrentContract.Rows[0];
        }
        private void LoadContractPositionInfo(DataRow ContractPositionRow)
        {
            currentContractId = Convert.ToInt32(ContractPositionRow["Contract_ID"]);
            firstContractId = Convert.ToInt32(ContractPositionRow["FirstContractID"]);
            lastContractId = Convert.ToInt32(ContractPositionRow["LastContractID"]);
            rowNumber = Convert.ToInt32(ContractPositionRow["RowNumber"]);

            nextContractId = ContractPositionRow["NextContractID"] != DBNull.Value ?
                Convert.ToInt32(ContractPositionRow["NextContractID"]) : null;

            if (ContractPositionRow["PreviousContractID"] != DBNull.Value)
                previousContractId = Convert.ToInt32(ContractPositionRow["PreviousContractID"]);
            else
                previousContractId = null;

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

        private void LoadContracts()
        {
            DataTable? dtContracts = Contract.GetContractsToLoad();

            if (dtContracts.Rows.Count > 0)
            {
                firstContractId = Convert.ToInt32(dtContracts.Rows[0]["FirstContractID"]);
                lastContractId = Convert.ToInt32(dtContracts.Rows[0]["LastContractID"]);
            }
            dtContracts.AddEmptyRow("Name", "Contract_ID");

            Invoke((MethodInvoker)delegate
            {
                cbxContracts.Bind("Name", "Contract_ID", dtContracts);
            });
        }
        private void cbxContracts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxContracts.SelectedIndex != -1 && cbxContracts.SelectedIndex != 0)
            {
                currentContractId = Convert.ToInt32(cbxContracts.SelectedValue);

                //this is for debbuging and demo purposes, I wouldn't do this inside of a event handler
                DataRowView currentContract = cbxContracts.SelectedItem as DataRowView;
                if (currentContract != null)
                {
                    Debug.WriteLine(currentContract["Contract_ID"]);
                    Debug.WriteLine(currentContract["FirstContractID"]);
                    Debug.WriteLine(currentContract["LastContractID"]);
                    Debug.WriteLine(currentContract["RowNumber"]);
                    Debug.WriteLine(currentContract["NextContractID"]);
                    Debug.WriteLine(currentContract["PreviousContractID"]);
                    if (ContractIsSelected)
                    {
                        PopulateFields();
                        SetState(FormState.Update);
                    }
                    else
                    {
                        MessageBox.Show("Please select a contract to display");
                    }
                }
            }
        }
        private void NavigationButtonManagement()
        {
            SetNavigationState(false);
            if (currentContractId > 0)
            {
                SetState(FormState.Update);
            }

            btnPrevious.Enabled = previousContractId is not null;
            btnNext.Enabled = nextContractId is not null;

            btnFirst.Enabled = currentContractId != firstContractId;
            btnLast.Enabled = currentContractId != lastContractId;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls(groupBox1.Controls);
            SetState(FormState.Register);
        }
        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
            mdiParentForm.SetToolStrip("", true);
        }
        private void cbx_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;

            ComboBox combobox = (ComboBox)sender;

            if (combobox.SelectedIndex == -1 || combobox.SelectedIndex == 0)
            {
                errorMessage = $"{combobox.Tag} is required.";
                mdiParentForm.SetToolStrip("Please provide the Club, Player, Start Date and End Date.", false);
            }

            errorProvider1.SetError(combobox, errorMessage);
        }
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;

            TextBox textBox = (TextBox)sender;

            if (textBox.Text == string.Empty)
            {
                errorMessage = $"{textBox.Tag} is required.";
                mdiParentForm.SetToolStrip("Please provide the Club, Player, Start Date and End Date.", false);

            }
            errorProvider1.SetError(textBox, errorMessage);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete the Contract {txtId.Text + ": " + 
                cbxClubs.GetItemText(cbxClubs.SelectedItem)
                + " - " + cbxPlayers.GetItemText(cbxPlayers.SelectedItem)}?", "Warning", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteContract();
            }
            LoadFirstContract();
        }
        private void LoadFirstContract()
        {
            currentContractId = Contract.GetFirstContract();
            PopulateFields();
        }
        private void DeleteContract()
        {
            var response = Contract.DeleteContract(Convert.ToInt32(txtId.Text));
            if (response)
            {
                MessageBox.Show("Contract deleted successfully.");
            }
            else
            {
                MessageBox.Show("Error deleting Contract.");
            }
        }
        private void SetState(FormState state)
        {
            currentState = state;
            LoadState(state);
        }
    }
}
