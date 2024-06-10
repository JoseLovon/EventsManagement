using FootballContractsHistory.Models;
using System.Data;


namespace FootballContractsHistory.Views
{
    public partial class frmBrowseClub : Form
    {
        private frmMDI mdiParentForm;
        public Club clubSearched;
        private List<Contract> contracts;
        public frmBrowseClub()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }
        private void frmSearchClubs_Load(object sender, EventArgs e)
        {
            LoadClubs();
            mdiParentForm.SetToolStrip("Ready to browse players by club", true);
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
        private void personalizeDataGridView()
        {
            //dgvPlayers.RowHeadersVisible = false;
            dgvClubs.Columns.Clear();

            dgvClubs.DataSource = contracts;
            dgvClubs.Columns["ContractId"].Visible = false;
            dgvClubs.Columns["ClubId"].Visible = false;
            dgvClubs.Columns["ClubName"].Visible = false;
            dgvClubs.Columns["PlayerId"].Visible = false;

            dgvClubs.Columns["PlayerName"].HeaderText = "Player";
            dgvClubs.Columns["PositionName"].HeaderText = "Position";
            dgvClubs.Columns["StartDate"].HeaderText = "Start Date";
            dgvClubs.Columns["EndDate"].HeaderText = "End Date";
            dgvClubs.Columns["CreationDate"].HeaderText = "Creation Date";

            dgvClubs.Columns["PlayerName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClubs.Columns["PositionName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClubs.Columns["StartDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClubs.Columns["EndDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClubs.Columns["CreationDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            mdiParentForm.SetToolStrip("Players searched successfully.", true);
        }

        private void cbxClubs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbxClubs.SelectedIndex != -1 && cbxClubs.SelectedIndex != 0)
                {
                    dgvClubs.Columns.Clear();
                    contracts = Contract.GetPlayersByClub(cbxClubs.GetItemText(cbxClubs.SelectedItem))!;
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
                    mdiParentForm.SetToolStrip("Please select a Club.", false);
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
    }
}
