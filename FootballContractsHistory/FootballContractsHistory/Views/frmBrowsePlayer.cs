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
    public partial class frmBrowsePlayer : Form
    {
        private frmMDI mdiParentForm;
        public Player playerSearched;
        private List<Contract> contracts;
        public frmBrowsePlayer()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }
        private void frmSearchPlayers_Load(object sender, EventArgs e)
        {
            LoadPlayers();
            mdiParentForm.SetToolStrip("Ready to browse clubs by player", true);
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
        private void personalizeDataGridView()
        {
            //dgvPlayers.RowHeadersVisible = false;
            dgvPlayers.Columns.Clear();
            dgvPlayers.DataSource = contracts;
               
            dgvPlayers.Columns["ContractId"].Visible = false;
            dgvPlayers.Columns["ClubId"].Visible = false;
            dgvPlayers.Columns["PlayerId"].Visible = false;
            dgvPlayers.Columns["PlayerName"].Visible = false;

            dgvPlayers.Columns["ClubName"].HeaderText = "Club";
            dgvPlayers.Columns["PositionName"].HeaderText = "Position";
            dgvPlayers.Columns["StartDate"].HeaderText = "Start Date";
            dgvPlayers.Columns["EndDate"].HeaderText = "End Date";
            dgvPlayers.Columns["CreationDate"].HeaderText = "Creation Date";

            dgvPlayers.Columns["ClubName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPlayers.Columns["PositionName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPlayers.Columns["StartDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPlayers.Columns["EndDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPlayers.Columns["CreationDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            mdiParentForm.SetToolStrip("Clubs searched successfully.", true);
        }
        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
            mdiParentForm.SetToolStrip("", true);
        }
        private void cbxPlayers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbxPlayers.SelectedIndex != -1 && cbxPlayers.SelectedIndex != 0)
                {
                    dgvPlayers.Columns.Clear();
                    contracts = Contract.GetClubsByPlayer(cbxPlayers.GetItemText(cbxPlayers.SelectedItem));
                    if (contracts != null && contracts.Count > 0)
                    {
                        personalizeDataGridView();
                    }
                    else
                    {
                        mdiParentForm.SetToolStrip("No clubs found with the player searched.", true);
                    }
                }
                else
                {
                    mdiParentForm.SetToolStrip("Please select a Player.", false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong. Please try again later.");
            }
        }
    }
}
