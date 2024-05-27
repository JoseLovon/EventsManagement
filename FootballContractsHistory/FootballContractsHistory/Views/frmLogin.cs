using FootballContractsHistory.Models;
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
                    DataUser data = new DataUser() { userId = userLogged.Username! };

                    if (mdiParentForm != null)
                    {
                        mdiParentForm.SetToolStrip("hola", true);
                        frmPlayers childForm = new frmPlayers();
                        childForm.MdiParent = mdiParentForm;
                        childForm.WindowState = FormWindowState.Maximized;
                        childForm.Bounds = mdiParentForm.ClientRectangle;
                        childForm.Show();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a valid username and password");
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            mdiParentForm.SetToolStrip("Enter username and password to login", true);
        }
    }
}
