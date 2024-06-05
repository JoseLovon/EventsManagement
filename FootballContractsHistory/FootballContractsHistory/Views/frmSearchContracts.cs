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
using System.Xml.Linq;

namespace FootballContractsHistory.Views
{
    public partial class frmSearchContracts : Form
    {
        private frmMDI mdiParentForm;
        public Contract contractSearched;
        private List<Contract> contracts;
        public frmSearchContracts()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }
        private void frmSearchContracts_Load(object sender, EventArgs e)
        {
            LoadClubs();
            LoadPlayers();
            mdiParentForm.SetToolStrip("Ready to search contracts", true);
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
        private void personalizeDataGridView()
        {
            //dgvPlayers.RowHeadersVisible = false;
            dgvContracts.Columns.Clear();
            dgvContracts.DataSource = contracts;
            dgvContracts.Columns["ContractId"].Visible = false;
            dgvContracts.Columns["ClubId"].Visible = false;
            dgvContracts.Columns["PlayerId"].Visible = false;
            dgvContracts.Columns["ClubName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContracts.Columns["PlayerName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContracts.Columns["PositionName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContracts.Columns["StartDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContracts.Columns["EndDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContracts.Columns["CreationDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mdiParentForm.SetToolStrip("Contracts searched successfully.", true);
        }

        private void cbxClubs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbxClubs.SelectedIndex != -1 && cbxClubs.SelectedIndex != 0)
                {
                    dgvContracts.Columns.Clear();
                    contracts = Contract.GetContractsByClub_Player(cbxClubs.GetItemText(cbxClubs.SelectedItem),
                        (cbxPlayers.SelectedIndex != -1 && cbxPlayers.SelectedIndex != 0) ? cbxPlayers.GetItemText(cbxPlayers.SelectedItem) : null)!;
                    if (contracts != null && contracts.Count > 0)
                    {
                        personalizeDataGridView();
                    }
                    else
                    {
                        mdiParentForm.SetToolStrip("No contracts found with the data searched.", true);
                    }
                }
                else
                {
                    mdiParentForm.SetToolStrip("Please select a Club or Player.", false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong. Please try again later.");
            }
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
                    dgvContracts.Columns.Clear();
                    contracts = Contract.GetContractsByClub_Player((cbxClubs.SelectedIndex != -1 && cbxClubs.SelectedIndex != 0) ? cbxClubs.GetItemText(cbxClubs.SelectedItem):null,
                       cbxPlayers.GetItemText(cbxPlayers.SelectedItem));
                    if (contracts != null && contracts.Count > 0)
                    {
                        personalizeDataGridView();
                    }
                    else
                    {
                        mdiParentForm.SetToolStrip("No contracts found with the data searched.", true);
                    }
                }
                else
                {
                    mdiParentForm.SetToolStrip("Please select a Club or Player.", false);
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
