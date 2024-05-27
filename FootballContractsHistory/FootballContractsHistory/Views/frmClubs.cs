using FootballContractsHistory.Models;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace FootballContractsHistory
{
    public partial class frmClubs : Form
    {
        private frmMDI mdiParentForm;

        public frmClubs()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }

        private void frmClubs_Load(object sender, EventArgs e)
        {
            //Task.Factory.StartNew(() => LoadPositions());
            mdiParentForm.SetToolStrip("Ready...", true);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtName.Text) && 
                    !string.IsNullOrEmpty(txtDescription.Text))
                {
                    Club c = new Club(txtName.Text, txtDescription.Text);
                    var response = c.CreateClub(c);
                    if (response)
                    {
                        txtName.Text = string.Empty;
                        txtDescription.Text = string.Empty;
                        mdiParentForm.SetToolStrip("Enter Name and Description to register a club.", true);
                        MessageBox.Show("Club registered successfully.");
                    }
                    else
                    {
                        mdiParentForm.SetToolStrip("Error creating club.", true);
                    }
                }
                else
                {
                    mdiParentForm.SetToolStrip("Please complete the Name and Description of the club.", false);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong. Please try again later.");
            }
        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {
            frmSearchClubs searchClubsForm = new frmSearchClubs();
            searchClubsForm.WindowState = FormWindowState.Normal;
            searchClubsForm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
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
        }
    }
}
