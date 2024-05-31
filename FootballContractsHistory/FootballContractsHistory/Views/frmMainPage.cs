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
    public partial class frmMainPage : Form
    {
        private frmMDI mdiParentForm;
        public frmMainPage()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }

        private void pbxClubs_Click(object sender, EventArgs e)
        {
            if (mdiParentForm != null)
            {
                mdiParentForm.SetToolStrip("Welcome to Clubs Maintenance", true);
                frmClubs childForm = new frmClubs();
                childForm.MdiParent = mdiParentForm;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.Bounds = mdiParentForm.ClientRectangle;
                childForm.Show();
                mdiParentForm.WindowState = FormWindowState.Normal;

            }
        }

        private void pbxPlayers_Click(object sender, EventArgs e)
        {
            if (mdiParentForm != null)
            {
                mdiParentForm.SetToolStrip("Welcome to Players Maintenance", true);
                frmPlayers childForm = new frmPlayers();
                childForm.MdiParent = mdiParentForm;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.Bounds = mdiParentForm.ClientRectangle;
                childForm.Activate();
                childForm.Show();
                mdiParentForm.WindowState = FormWindowState.Normal;
            }
        }

        private void pbxContracts_Click(object sender, EventArgs e)
        {
            if (mdiParentForm != null)
            {
                mdiParentForm.SetToolStrip("Welcome to Contracts Maintenance", true);
                frmContracts childForm = new frmContracts();
                childForm.MdiParent = mdiParentForm;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.Bounds = mdiParentForm.ClientRectangle;
                childForm.Show();
                mdiParentForm.WindowState = FormWindowState.Normal;
            }
        }

        private void pbxLogout_Click(object sender, EventArgs e)
        {
            if (mdiParentForm != null)
            {
                this.Close();
                frmLogin childForm = new frmLogin();
                childForm.MdiParent = mdiParentForm;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.Bounds = mdiParentForm.ClientRectangle;
                childForm.Show();
            }
        }

        private void pbxClubs_MouseHover(object sender, EventArgs e)
        {
            pbxClubs.BackColor = Color.Gainsboro;
        }
        private void pbxPlayers_MouseHover(object sender, EventArgs e)
        {
            pbxPlayers.BackColor = Color.Gainsboro;
        }
        private void pbxContracts_MouseHover(object sender, EventArgs e)
        {
            pbxContracts.BackColor = Color.Gainsboro;
        }

        private void pbxLogout_MouseHover(object sender, EventArgs e)
        {
            pbxLogout.BackColor = Color.Gainsboro;
        }
        private void pbxClubs_MouseDown(object sender, MouseEventArgs e)
        {
            pbxClubs.BackColor = Color.Silver;
        }
        private void pbxPlayers_MouseDown(object sender, MouseEventArgs e)
        {
            pbxPlayers.BackColor = Color.Silver;
        }
        private void pbxContracts_MouseDown(object sender, MouseEventArgs e)
        {
            pbxContracts.BackColor = Color.Silver;
        }

        private void pbxLogout_MouseDown(object sender, MouseEventArgs e)
        {
            pbxLogout.BackColor = Color.Silver;
        }

        private void pbxClubs_MouseLeave(object sender, EventArgs e)
        {
            pbxClubs.BackColor = Color.White;
        }

        private void pbxPlayers_MouseLeave(object sender, EventArgs e)
        {
            pbxPlayers.BackColor = Color.White;
        }

        private void pbxContracts_MouseLeave(object sender, EventArgs e)
        {
            pbxContracts.BackColor = Color.White;
        }

        private void pbxLogout_MouseLeave(object sender, EventArgs e)
        {
            pbxLogout.BackColor = Color.White;
        }

        private void pbxClubLogo_Click(object sender, EventArgs e)
        {
            if (mdiParentForm != null)
            {
                mdiParentForm.SetToolStrip("Welcome to Clubs Maintenance", true);
                frmClubs childForm = new frmClubs();
                childForm.MdiParent = mdiParentForm;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.Bounds = mdiParentForm.ClientRectangle;
                childForm.Show();
            }
        }

        private void pbxPlayerLogo_Click(object sender, EventArgs e)
        {
            if (mdiParentForm != null)
            {
                mdiParentForm.SetToolStrip("Welcome to Players Maintenance", true);
                frmPlayers childForm = new frmPlayers();
                childForm.MdiParent = mdiParentForm;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.Bounds = mdiParentForm.ClientRectangle;
                childForm.Activate();
                childForm.Show();
            }
        }

        private void pbxContractLogo_Click(object sender, EventArgs e)
        {
            if (mdiParentForm != null)
            {
                mdiParentForm.SetToolStrip("Welcome to Contracts Maintenance", true);
                frmContracts childForm = new frmContracts();
                childForm.MdiParent = mdiParentForm;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.Bounds = mdiParentForm.ClientRectangle;
                childForm.Show();
            }
        }
        private void pbxLogoutLogo_Click(object sender, EventArgs e)
        {
            this.Close();
            if (mdiParentForm != null)
            {
                frmLogin childForm = new frmLogin();
                childForm.MdiParent = mdiParentForm;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.Bounds = mdiParentForm.ClientRectangle;
                childForm.Show();
            }
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            mdiParentForm.SetToolStrip($"Welcome {DataUser.GetInstance().username}", true);

        }
    }
}
