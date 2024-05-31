using FootballContractsHistory.Models;
using System.ComponentModel;
using System.Data;

namespace FootballContractsHistory
{
    public partial class frmClubs : Form
    {
        private frmMDI mdiParentForm;
        private frmSearchClubs searchClubsForm;
        private Club clubToUpdate;
        private FormState currentState;

        public frmClubs()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }

        private void frmClubs_Load(object sender, EventArgs e)
        {
            currentState = FormState.Register;
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
        private void btnRegisterUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtName.Text) && 
                    !string.IsNullOrEmpty(txtName.Text))
                {
                    if (currentState == FormState.Register)
                    {
                        Club c = new Club(DataUser.GetInstance().userId, txtName.Text, txtDescription.Text);
                        var response = c.CreateClub(c);
                        if (response)
                        {
                            txtName.Text = string.Empty;
                            txtDescription.Text = string.Empty;
                            mdiParentForm.SetToolStrip("Club registered successfully.", true);
                        }
                        else
                        {
                            mdiParentForm.SetToolStrip("Error creating club.", true);
                        }
                    }
                    else if (currentState == FormState.Update)
                    {
                        Club c = new Club(clubToUpdate.ClubId, DataUser.GetInstance().userId, txtName.Text, txtDescription.Text);
                        var response = c.UpdateClub(c);
                        if (response)
                        {
                            //SetState(FormState.Register);
                            mdiParentForm.SetToolStrip("Club updated successfully.", true);
                        }
                        else
                        {
                            mdiParentForm.SetToolStrip("Error updating club.", false);
                        }
                    }
                }
                else
                {
                    mdiParentForm.SetToolStrip("Please complete the Name and Description.", false);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void ShowFrmSearchClubs()
        {
            searchClubsForm = new frmSearchClubs
            {
                MdiParent = mdiParentForm,
                WindowState = FormWindowState.Normal,
                Bounds = mdiParentForm.Bounds
            };
            searchClubsForm.FormClosed += frmSearchClubs_FormClosed!;
            searchClubsForm.Show();

        }
        private void pbxSearch_Click(object sender, EventArgs e)
        {
            ShowFrmSearchClubs();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls(groupBox1.Controls);
            mdiParentForm.SetToolStrip("Ready...", true);
            SetState(FormState.Register);
        }
        private void pbxBack_Click(object sender, EventArgs e)
        {
            if (searchClubsForm != null)
                searchClubsForm.Close();

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
        private void frmSearchClubs_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            if (searchClubsForm.clubSearched != null)
            {
                clubToUpdate = searchClubsForm.clubSearched;
                txtName.Text = clubToUpdate.Name;
                txtDescription.Text = clubToUpdate.Description;
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
