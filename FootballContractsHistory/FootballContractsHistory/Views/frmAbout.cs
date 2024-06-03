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
    public partial class frmAbout : Form
    {
        private frmMDI mdiParentForm;

        public frmAbout()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
            mdiParentForm.SetToolStrip($"Welcome {DataUser.GetInstance().username}", true);

        }
    }
}
