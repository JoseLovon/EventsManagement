using FootballContractsHistory.Models;
using FootballContractsHistory.Views;
using System.ComponentModel;
using System.Data;

namespace FootballContractsHistory
{
    public partial class frmContracts : Form
    {
        private frmMDI mdiParentForm;
        private frmSearchContracts searchContractsForm;
        private Contract contractToUpdate;
        private FormState currentState;

        public frmContracts()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }

        private void frmContracts_Load(object sender, EventArgs e)
        {
            currentState = FormState.Register;
            Task.Factory.StartNew(() => LoadClubs());
            Task.Factory.StartNew(() => LoadPlayers());
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
        private void LoadClubs()
        {
            Club c = new Club();
            DataTable? dtClubs = c.GetClubs();
            dtClubs.AddEmptyRow("Name", "Club_ID");

            Invoke((MethodInvoker)delegate
            {
                cbxClubs.Bind("Name", "Club_ID", dtClubs);
            });
        }
        private void LoadPlayers()
        {
            Player p = new Player();
            DataTable? dtPlayers = p.GetPlayers();
            dtPlayers.AddEmptyRow("Name", "Player_ID");

            Invoke((MethodInvoker)delegate
            {
                cbxPlayers.Bind("Name", "Player_ID", dtPlayers);
            });
        }

        private void btnRegisterUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxClubs.SelectedIndex != 0 && cbxPlayers.SelectedIndex != 0)
                {
                    if (currentState == FormState.Register)
                    {
                        Contract c = new Contract(Convert.ToInt32(cbxClubs.SelectedValue),
                            Convert.ToInt32(cbxPlayers.SelectedValue), 
                            dtpStartDate.Value, dtpEndDate.Value);
                        var response = Contract.CreateContract(c);
                        if (response)
                        {
                            cbxClubs.SelectedIndex = 0;
                            cbxPlayers.SelectedIndex = 0;
                            mdiParentForm.SetToolStrip("Contract registered successfully.", true);
                        }
                        else
                        {
                            mdiParentForm.SetToolStrip("Error creating contract.", true);
                        }
                    }
                    else if (currentState == FormState.Update)
                    {
                        Contract c = new Contract(contractToUpdate.ContractId, 
                            Convert.ToInt32(cbxClubs.SelectedValue), 
                            Convert.ToInt32(cbxPlayers.SelectedValue), 
                            dtpStartDate.Value, dtpEndDate.Value);
                        var response = Contract.UpdateContract(c);
                        if (response)
                        {
                            mdiParentForm.SetToolStrip("Contract updated successfully.", true);
                        }
                        else
                        {
                            mdiParentForm.SetToolStrip("Error updating contract.", false);
                        }
                    }
                }
                else
                {
                    mdiParentForm.SetToolStrip("Please complete the Club, Player, Start Date and End Date fields.", false);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void ShowFrmSearchContracts()
        {
            searchContractsForm = new frmSearchContracts
            {
                MdiParent = mdiParentForm,
                WindowState = FormWindowState.Normal,
                Bounds = mdiParentForm.Bounds
            };
            searchContractsForm.FormClosed += frmSearchContracts_FormClosed!;
            searchContractsForm.Show();

        }
        private void pbxSearch_Click(object sender, EventArgs e)
        {
            ShowFrmSearchContracts();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls(groupBox1.Controls);
            mdiParentForm.SetToolStrip("Ready...", true);
            SetState(FormState.Register);
        }
        private void pbxBack_Click(object sender, EventArgs e)
        {
            if (searchContractsForm != null)
                searchContractsForm.Close();

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
        private void frmSearchContracts_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            if (searchContractsForm.contractSearched != null)
            {
                contractToUpdate = searchContractsForm.contractSearched;
                cbxClubs.SelectedValue = contractToUpdate.ClubId;
                cbxPlayers.SelectedValue = contractToUpdate.PlayerId;
                dtpStartDate.Value = contractToUpdate.StartDate;
                dtpEndDate.Value = contractToUpdate.EndDate;
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
