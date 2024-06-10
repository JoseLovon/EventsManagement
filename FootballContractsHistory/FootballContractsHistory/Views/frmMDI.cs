using FootballContractsHistory.Models;
using FootballContractsHistory.Views;
using System.Windows.Forms;

namespace FootballContractsHistory
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form? childForm = null;

            ToolStripMenuItem? menuItem = sender as ToolStripMenuItem;

            if (menuItem == null)
            {
                return;
            }

            switch (menuItem.Tag)
            {
                case "about":
                    childForm = new frmAbout();
                    this.SetToolStrip("Welcome to About Page", true);
                    break;
                case "clubs":
                    childForm = new frmClub();
                    this.SetToolStrip("Welcome to Clubs Maintenance", true);
                    break;
                case "browseClub":
                    childForm = new frmBrowseClub();
                    this.SetToolStrip("Welcome to Search Players by Club", true);
                    break;
                case "browsePlayer":
                    childForm = new frmBrowsePlayer();
                    this.SetToolStrip("Welcome to Search Clubs by Player", true);
                    break;
                case "players":
                    childForm = new frmPlayers();
                    this.SetToolStrip("Welcome to Players Maintenance", true);
                    break;
                case "contracts":
                    childForm = new frmContracts();
                    this.SetToolStrip("Welcome to Contracts Maintenance", true);
                    break;
                
            }

            if (childForm != null)
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form.GetType() == childForm.GetType())
                    {
                        form.Activate();
                        return;
                    }
                }
                childForm.MdiParent = this;
                childForm.ShowInTaskbar = false;
                childForm.Show();
            }
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            maintenanceToolStripMenuItem.Enabled = false;
            Form? childForm = new frmLogin();
            childForm.Activate();
            childForm.MdiParent = this;
            childForm.ShowInTaskbar = false;
            childForm.Show();
        }
        public void SetToolStrip(string msg, bool c)
        {
            toolStripStatusLabel.Text = msg;
            toolStripStatusLabel.ForeColor = c ? Color.Black : Color.Red;
        }
        public void SetEnableMenuToolStrip(bool status)
        {
            if (status)
            {
                maintenanceToolStripMenuItem.Enabled = status;
            }
            else
            {
                maintenanceToolStripMenuItem.Enabled = status;
            }
        }
        private void frmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clubsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetToolStrip("Welcome to Clubs Maintenance", true);
            frmClub childForm = new frmClub();
            childForm.Activate();
            childForm.MdiParent = this;
            childForm.ShowInTaskbar = false;
            childForm.Show();
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetToolStrip("Welcome to Players Maintenance", true);
            frmPlayers childForm = new frmPlayers();
            childForm.Activate();
            childForm.MdiParent = this;
            childForm.ShowInTaskbar = false;
            childForm.Show();
        }

        private void contractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetToolStrip("Welcome to Contracts Maintenance", true);
            frmContracts childForm = new frmContracts();
            childForm.Activate();
            childForm.MdiParent = this;
            childForm.ShowInTaskbar = false;
            childForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetToolStrip("Welcome to About Page", true);
            frmAbout childForm = new frmAbout();
            childForm.Activate();
            childForm.MdiParent = this;
            childForm.ShowInTaskbar = false;
            childForm.Show();
        }
    }
}
