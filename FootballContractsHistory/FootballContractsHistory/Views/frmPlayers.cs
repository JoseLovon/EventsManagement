using FootballContractsHistory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballContractsHistory
{
    public partial class frmPlayers : Form
    {
        private frmMDI mdiParentForm;

        public frmPlayers()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }

        private void frmBands_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => LoadPositions());
            mdiParentForm.SetToolStrip("Ready...", true);
        }

        private void LoadPositions()
        {
            Position p = new Position();
            DataTable dtPositions = p.GetPositions();
            dtPositions.AddEmptyRow("Name", "Position_ID");

            Invoke((MethodInvoker)delegate
            {
                cbxPosition.Bind("Name", "Position_ID", dtPositions);
            });
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPlayer.Text) && cbxPosition.SelectedIndex != 0)
                {
                    Player p = new Player(txtPlayer.Text, Convert.ToInt32(cbxPosition.SelectedValue));
                    var response = p.CreatePlayer(p);
                    if (response)
                    {
                        txtPlayer.Text = string.Empty;
                        cbxPosition.SelectedIndex = -1;
                        mdiParentForm.SetToolStrip("Enter Player Name and Position to register a player.", true);
                        MessageBox.Show("Player registered successfully.");
                    }
                    else
                    {
                        mdiParentForm.SetToolStrip("Error creating player.", true);
                    }
                } else
                {
                    mdiParentForm.SetToolStrip("Please complete the Player Name and Position.", false);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong. Please try again later.");
            }
        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {
            frmSearchPlayers searchPlayersForm = new frmSearchPlayers();
            searchPlayersForm.WindowState = FormWindowState.Normal;
            searchPlayersForm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPlayer.Text = string.Empty;
            cbxPosition.SelectedIndex = -1;
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
        private void cbx_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;

            ComboBox combobox = (ComboBox)sender;

            if (combobox.SelectedIndex == -1 || combobox.SelectedIndex == 0)
            {
                errorMessage = $"{combobox.Tag} is required.";
            }

            errorProvider1.SetError(combobox, errorMessage);
        }
    }
}
