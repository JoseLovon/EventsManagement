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
            InitializeComponent();
        }
        private void frmSearchContracts_Load(object sender, EventArgs e)
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
        private void dgvPlayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvContracts.Rows[e.RowIndex];

                if (e.ColumnIndex == dgvContracts.Columns["Update"].Index)
                {
                    UpdateContract(selectedRow);
                }
                else if (e.ColumnIndex == dgvContracts.Columns["Delete"].Index)
                {
                    DeleteContract(selectedRow);
                }
            }
        }
        private void UpdateContract(DataGridViewRow row)
        {
            contractSearched = (Contract)row.DataBoundItem;
            this.Close();
        }

        private void DeleteContract(DataGridViewRow row)
        {
            try
            {
                int id = Convert.ToInt32(row.Cells["ContractId"].Value);

                var response = Contract.DeleteContract(id);
                if (response)
                {
                    mdiParentForm.SetToolStrip("Contract deleted successfully.", true);
                }
                else
                {
                    mdiParentForm.SetToolStrip("Error deleting contract.", true);
                }
                contracts.RemoveAt(row.Index);
                dgvContracts.DataSource = null;
                personalizeDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                mdiParentForm.SetToolStrip("Error deleting contract.", true);
            }
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
            mdiParentForm.SetToolStrip("Contracts searched successfully..", true);

            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            updateColumn.Text = "Update";
            updateColumn.Name = "Update";
            updateColumn.UseColumnTextForButtonValue = true;

            dgvContracts.Columns.Add(updateColumn);
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgvContracts.Columns.Add(deleteColumn);
        }

        private void cbxClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxClubs.SelectedIndex != 0 || cbxPlayers.SelectedIndex != 0)
                {
                    dgvContracts.Columns.Clear();
                    contracts = Contract.GetContractsByClub_Player(cbxClubs.SelectedText, cbxPlayers.SelectedText)!;
                    if (contracts != null && contracts.Count > 0)
                    {

                        cbxClubs.SelectedIndex = 0;
                        cbxPlayers.SelectedIndex = 0;
                        personalizeDataGridView();
                    }
                    else
                    {
                        mdiParentForm.SetToolStrip("No contracts found with the data searched.", true);
                    }
                }
                else
                {
                    mdiParentForm.SetToolStrip("Please select the Club or Player fields.", false);
                }
                cbxClubs.SelectedIndex = 0;
                cbxPlayers.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong. Please try again later.");
            }
        }
        private void cbxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxClubs.SelectedIndex != 0 || cbxPlayers.SelectedIndex != 0)
                {
                    dgvContracts.Columns.Clear();
                    contracts = Contract.GetContractsByClub_Player(cbxClubs.SelectedText, cbxPlayers.SelectedText)!;
                    if (contracts != null && contracts.Count > 0)
                    {

                        cbxClubs.SelectedIndex = 0;
                        cbxPlayers.SelectedIndex = 0;
                        personalizeDataGridView();
                    }
                    else
                    {
                        mdiParentForm.SetToolStrip("No contracts found with the data searched.", true);
                    }
                }
                else
                {
                    mdiParentForm.SetToolStrip("Please select the Club or Player fields.", false);
                }
                cbxClubs.SelectedIndex = 0;
                cbxPlayers.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong. Please try again later.");
            }
        }
    }
}
