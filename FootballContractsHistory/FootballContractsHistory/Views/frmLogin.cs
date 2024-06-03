using FootballContractsHistory.Models;
using FootballContractsHistory.Views;
using System.ComponentModel;


namespace FootballContractsHistory
{
    public partial class frmLogin : Form
    {
        private Login? login;
        private frmMDI mdiParentForm;
        public frmLogin()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            mdiParentForm.SetToolStrip("Enter Username and Password to login", true);
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = !string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                login = new Login();
                var userLogged = login.VerifyUser(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (userLogged != null)
                {
                    DataUser data = new DataUser() { userId = userLogged.UserId!, username = userLogged.Username };
                    this.Close();
                    if (mdiParentForm != null)
                    {
                        mdiParentForm.SetEnableMenuToolStrip(true);
                        frmMainPage childForm = new frmMainPage();
                        childForm.Activate();
                        childForm.MdiParent = mdiParentForm;
                        childForm.ShowInTaskbar = false;
                        childForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Username and Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
