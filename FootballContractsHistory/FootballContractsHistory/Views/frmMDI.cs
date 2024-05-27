using System.Windows.Forms;

namespace FootballContractsHistory
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        //private void ShowNewForm(object sender, EventArgs e)
        //{
        //    Form? childForm = null;

        //    ToolStripMenuItem? menuItem = sender as ToolStripMenuItem;

        //    if (menuItem == null)
        //    {
        //        return;
        //    }

        //    switch (menuItem.Tag)
        //    {
        //        case "Bands":
        //            childForm = new frmBands();
        //            break;
        //        case "Events":
        //            childForm = new frmEvents();
        //            break;
        //        case "Presentations":
        //            childForm = new frmPresentations();
        //            break;
        //    }

        //    if (childForm != null)
        //    {
        //        foreach (Form form in this.MdiChildren)
        //        {
        //            if (form.GetType() == childForm.GetType())
        //            {
        //                form.Activate();
        //                return;
        //            }
        //        }
        //        childForm.MdiParent = this;
        //        childForm.Show();
        //    }
        //}

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Form? childForm = new frmLogin();
            childForm.MdiParent = this;
            childForm.Activate();
            childForm.WindowState = FormWindowState.Maximized; 
            childForm.Bounds = this.ClientRectangle;
            childForm.Show();
        }
        public void SetToolStrip(string msg, bool c)
        {
            toolStripStatusLabel.Text = msg;
            toolStripStatusLabel.ForeColor = c ? Color.Black : Color.Red;
        }
    }
}
