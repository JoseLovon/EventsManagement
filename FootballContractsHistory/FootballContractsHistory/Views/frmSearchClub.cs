using FootballContractsHistory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballContractsHistory.Views
{
    public partial class frmSearchClub : Form
    {
        private frmMDI mdiParentForm;
        public Club clubSearched;
        private List<Club> clubs;
        public frmSearchClub()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }
        private void frmSearchClubs_Load(object sender, EventArgs e)
        {
            mdiParentForm.SetToolStrip("Ready to search clubs", true);
        }
        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
            mdiParentForm.SetToolStrip("", true);
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    dgvClubs.Columns.Clear();
                    e.Handled = true;
                    if (!string.IsNullOrEmpty(txtName.Text))
                    {
                        clubs = Club.GetClubByName(txtName.Text);
                        if (clubs != null && clubs.Count > 0)
                        {

                            txtName.Text = string.Empty;
                            personalizeDataGridView();
                        }
                        else
                        {
                            mdiParentForm.SetToolStrip("No clubs found with the Name searched.", true);
                        }
                    }
                    else
                    {
                        mdiParentForm.SetToolStrip("Please complete the Name.", false);
                    }
                    txtName.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong. Please try again later.");
            }
        }
        private void personalizeDataGridView()
        {
            dgvClubs.Columns.Clear();
            dgvClubs.DataSource = clubs;

            dgvClubs.Columns["ClubId"].Visible = false;

            dgvClubs.Columns["ClubId"].HeaderText = "Club #";

            dgvClubs.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClubs.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            mdiParentForm.SetToolStrip("Clubs searched successfully.", true);
        }
    }
}
