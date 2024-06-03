using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballContractsHistory.Views
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            lblApplicationName.Text = assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;
            lblVersion.Text = assembly.GetName().Version.ToString();

            timer.Interval = 5000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Hide();

            frmMDI frmParent = new();
            frmParent.Show();
        }
    }
}
