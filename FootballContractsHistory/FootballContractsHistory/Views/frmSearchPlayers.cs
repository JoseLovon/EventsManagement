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
    public partial class frmSearchPlayers : Form
    {
        private frmMDI mdiParentForm;
        public Player playerSearched;
        private List<Player> players;
        public frmSearchPlayers()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }

        private void frmPlayers_Load(object sender, EventArgs e)
        {
            mdiParentForm.SetToolStrip("Ready...", true);
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    dgvPlayers.Columns.Clear();
                    e.Handled = true;
                    if (!string.IsNullOrEmpty(txtName.Text))
                    {
                        Player p = new();
                        players = p.GetPlayerByName(txtName.Text)!;
                        if (players != null && players.Count > 0)
                        {
                            
                            txtName.Text = string.Empty;
                            personalizeDataGridView();
                        }
                        else
                        {
                            mdiParentForm.SetToolStrip("No contracts found with the Full Name searched.", true);
                        }
                    }
                    else
                    {
                        mdiParentForm.SetToolStrip("Please complete the Player Full Name.", false);
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
        private void dgvPlayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvPlayers.Rows[e.RowIndex];

                if (e.ColumnIndex == dgvPlayers.Columns["Update"].Index)
                {
                    UpdatePlayer(selectedRow);
                }
                else if (e.ColumnIndex == dgvPlayers.Columns["Delete"].Index)
                {
                    DeletePlayer(selectedRow);
                }
            }
        }
        private void UpdatePlayer(DataGridViewRow row)
        {
            playerSearched = (Player)row.DataBoundItem;

            //playerSearched = new Player()
            //{
            //    PlayerId = Convert.ToInt32(row.Cells["PlayerId"].Value),
            //    PlayerName = row.Cells["PlayerName"].Value.ToString(),
            //    PositionId = Convert.ToInt32(row.Cells["PositionId"].Value),
            //    PositionName = row.Cells["PositionName"].Value.ToString()
            //};
            this.Close();
        }

        private void DeletePlayer(DataGridViewRow row)
        {
            try
            {
                int id = Convert.ToInt32(row.Cells["PlayerId"].Value);

                Player p = new();
                var response = p.DeletePlayer(id);
                if (response)
                {
                    mdiParentForm.SetToolStrip("Player deleted successfully.", true);
                }
                else
                {
                    mdiParentForm.SetToolStrip("Error deleting player.", true);
                }
                players.RemoveAt(row.Index);
                dgvPlayers.DataSource = null;
                personalizeDataGridView();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                mdiParentForm.SetToolStrip("Error deleting player.", true);
            }
        }
        private void personalizeDataGridView()
        {
            //dgvPlayers.RowHeadersVisible = false;
            dgvPlayers.Columns.Clear();
            dgvPlayers.DataSource = players;
            dgvPlayers.Columns["PlayerId"].Visible = false;
            dgvPlayers.Columns["PlayerName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPlayers.Columns["PositionId"].Visible = false;
            dgvPlayers.Columns["PositionName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mdiParentForm.SetToolStrip("Players searched successfully..", true);

            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            updateColumn.Text = "Update";
            updateColumn.Name = "Update";
            updateColumn.UseColumnTextForButtonValue = true;

            dgvPlayers.Columns.Add(updateColumn);
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgvPlayers.Columns.Add(deleteColumn);
        }
    }
}
