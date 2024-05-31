using FootballContractsHistory.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballContractsHistory
{
    public partial class frmSearchClubs : Form
    {
        private frmMDI mdiParentForm;
        public Club clubSearched;
        private List<Club> clubs;
        public frmSearchClubs()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }

        private void frmSearchClubs_Load(object sender, EventArgs e)
        {
            mdiParentForm.SetToolStrip("Ready...", true);
        }
        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        Club c = new();
                        clubs = c.GetClubByName(txtName.Text)!;
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
        private void dgvClubs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvClubs.Rows[e.RowIndex];

                if (e.ColumnIndex == dgvClubs.Columns["Update"].Index)
                {
                    UpdateClub(selectedRow);
                }
                else if (e.ColumnIndex == dgvClubs.Columns["Delete"].Index)
                {
                    DeleteClub(selectedRow);
                }
            }
        }
        private void UpdateClub(DataGridViewRow row)
        {
            clubSearched = (Club)row.DataBoundItem;

            //clubSearched = new Club()
            //{
            //    ClubId = Convert.ToInt32(row.Cells["ClubId"].Value),
            //    Name = row.Cells["Name"].Value.ToString(),
            //    Description = row.Cells["Description"].Value.ToString()
            //};
            this.Close();
        }

        private void DeleteClub(DataGridViewRow row)
        {
            try
            {
                int id = Convert.ToInt32(row.Cells["ClubId"].Value);

                Club c = new();
                var response = c.DeleteClub(id);
                if (response)
                {
                    mdiParentForm.SetToolStrip("Club deleted successfully.", true);
                }
                else
                {
                    mdiParentForm.SetToolStrip("Error deleting club.", true);
                }
                clubs.RemoveAt(row.Index);
                dgvClubs.DataSource = null;
                personalizeDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                mdiParentForm.SetToolStrip("Error deleting club.", true);
            }
        }
        private void personalizeDataGridView()
        {
            //dgvPlayers.RowHeadersVisible = false;
            dgvClubs.Columns.Clear();
            dgvClubs.DataSource = clubs;
            dgvClubs.Columns["ClubId"].Visible = false;
            dgvClubs.Columns["UserId"].Visible = false;
            dgvClubs.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClubs.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mdiParentForm.SetToolStrip("Clubs searched successfully..", true);

            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            updateColumn.Text = "Update";
            updateColumn.Name = "Update";
            updateColumn.UseColumnTextForButtonValue = true;

            dgvClubs.Columns.Add(updateColumn);
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgvClubs.Columns.Add(deleteColumn);
        }
    }
}
