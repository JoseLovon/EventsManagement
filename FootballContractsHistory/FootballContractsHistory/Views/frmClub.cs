using FootballContractsHistory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballContractsHistory.Views
{
    public partial class frmClub : Form
    {
        private int currentClubId;
        private int firstClubId;
        private int lastClubId;
        private int? nextClubId;
        private int? previousClubId;
        private int rowNumber;

        private frmMDI mdiParentForm;
        private FormState currentState;

        public frmClub()
        {
            mdiParentForm = Application.OpenForms.OfType<frmMDI>().FirstOrDefault()!;
            InitializeComponent();
        }
        private bool ClubIsSelected
        {
            get
            {
                return currentClubId > 0;
            }
        }
        private int TotalClubCount()
        {
            return cbxClubs.Items.Count - 1;
        }

        private void frmClubs_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => LoadClubs());

            SetState(currentState);

            LoadFirstClub();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetState(FormState.Add);
        }
        private void Navigation_Handler(object sender, EventArgs e)
        {
            mdiParentForm.SetToolStrip("", true);

            if (sender == btnFirst)
            {
                currentClubId = firstClubId;
            }
            else if (sender == btnLast)
            {
                currentClubId = lastClubId;
            }
            else if (sender == btnNext)
            {
                if (nextClubId != null)
                {
                    currentClubId = nextClubId.Value;
                }
                else
                {
                    MessageBox.Show("The last Club is currently displayed");
                }
            }
            else if (sender == btnPrevious)
            {
                if (previousClubId != null)
                {
                    currentClubId = previousClubId.Value;
                }
                else
                {
                    MessageBox.Show("The first Club is currently displayed");
                }
            }
            else
            {
                return;
            }

            PopulateFields();
        }
        private void LoadState(FormState state)
        {
            //btnClear.Enabled = state != FormState.View;

            if (state == FormState.Add || state == FormState.Register)
            {
                btnClear.Enabled = true;
                //EnableClubInput(true);
                btnRegisterUpdate.Text = "Register";
                ClearControls(groupBox1.Controls);
            }
            else
            {
                btnClear.Enabled = false;
                //EnableClubInput(false);
                btnRegisterUpdate.Text = "Update";
            }
            btnDelete.Enabled = state == FormState.Update;
        }
        private void btnRegisterUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (String.IsNullOrEmpty(txtId.Text))
                    {
                        RegisterClub();
                    }
                    else
                    {
                        UpdateClub();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void RegisterClub()
        {
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtDescription.Text))
            {
                Club c = new Club(txtName.Text, txtDescription.Text);
                var response = Club.CreateClub(c);
                if (response)
                {
                    txtName.Text = string.Empty;
                    txtDescription.Text = string.Empty;
                    MessageBox.Show("Club registered successfully.");
                    LoadClubs();
                    LoadFirstClub();
                }
                else
                {
                    MessageBox.Show("Error creating club.");
                }
            }
        }
        private void UpdateClub()
        {
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtDescription.Text) && cbxClubs.SelectedIndex != 0)
            {
                Club c = new Club(Convert.ToInt32(txtId.Text), txtName.Text, txtDescription.Text);
                var response = Club.UpdateClub(c);
                if (response)
                {
                    //SetState(FormState.Register);
                    MessageBox.Show("Club updated successfully.");
                    LoadClubs();
                    LoadFirstClub();
                }
                else
                {
                    MessageBox.Show("Error updating club.");
                }
            }
        }
        private void PopulateFields()
        {
            if (ClubIsSelected)
            {
                DataRow selectedRow = GetClubRow(currentClubId);

                DisplayClub(selectedRow);

                mdiParentForm.SetToolStrip($"Displaying Club {rowNumber} of {TotalClubCount()}", true);
            }

            NavigationButtonManagement();
        }
        private void SetNavigationState(bool enable)
        {
            btnPrevious.Enabled = enable;
            btnNext.Enabled = enable;
            btnLast.Enabled = enable;
            btnFirst.Enabled = enable;
        }
        private void DisplayClub(DataRow productRow)
        {
            txtId.Text = productRow["Club_ID"].ToString();
            txtName.Text = productRow["Name"].ToString();
            txtDescription.Text = productRow["Description"].ToString();
            dtpCreationDate.Text = productRow["Creation_Date"].ToString();

            LoadClubs();

            cbxClubs.SelectedValue = productRow["Club_ID"];

        }
        private DataRow GetClubRow(int clubID)
        {
            var dsClubInfo = Club.GetClubsToLoadById(clubID);

            DataTable dtCurrentClub = dsClubInfo.Tables[0];
            DataTable dtClubPosition = dsClubInfo.Tables[1];
            LoadClubPositionInfo(dtClubPosition.Rows[0]);

            return dtCurrentClub.Rows[0];
        }
        private void LoadClubPositionInfo(DataRow clubPositionRow)
        {
            currentClubId = Convert.ToInt32(clubPositionRow["Club_ID"]);
            firstClubId = Convert.ToInt32(clubPositionRow["FirstClubID"]);
            lastClubId = Convert.ToInt32(clubPositionRow["LastClubID"]);
            rowNumber = Convert.ToInt32(clubPositionRow["RowNumber"]);

            nextClubId = clubPositionRow["NextClubID"] != DBNull.Value ?
                Convert.ToInt32(clubPositionRow["NextClubID"]) : null;

            if (clubPositionRow["PreviousClubID"] != DBNull.Value)
                previousClubId = Convert.ToInt32(clubPositionRow["PreviousClubID"]);
            else
                previousClubId = null;

        }
        private void ClearControls(Control.ControlCollection parentControl)
        {
            Invoke((MethodInvoker)delegate
            {
                foreach (Control control in parentControl)
                {
                    switch (control)
                    {
                        case TextBox textBox:
                            textBox.Text = string.Empty;
                            break;
                        case CheckBox checkBox:
                            checkBox.Checked = false;
                            break;
                        case ComboBox combo:
                            if (currentClubId > 0)
                            {
                                if (combo.Tag.ToString() != "search")
                                    combo.SelectedIndex = 0;
                            }
                            else
                            {
                                combo.SelectedIndex = 0;

                            }
                            break;
                        case GroupBox groupBox:
                            ClearControls(groupBox.Controls);
                            break;
                        case DateTimePicker dateTimePicker:
                            dateTimePicker.Value = DateTime.Today;
                            break;
                    }
                }
            });
        }

        private void LoadClubs()
        {
            DataTable? dtClubs = Club.GetClubsToLoad();

            firstClubId = Convert.ToInt32(dtClubs.Rows[0]["FirstClubID"]);
            lastClubId = Convert.ToInt32(dtClubs.Rows[0]["LastClubID"]);

            dtClubs.AddEmptyRow("Name", "Club_ID");

            Invoke((MethodInvoker)delegate
            {
                cbxClubs.Bind("Name", "Club_ID", dtClubs);
            });
        }
        private void cbxClubs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbxClubs.SelectedIndex != -1 && cbxClubs.SelectedIndex != 0)
                {
                    currentClubId = Convert.ToInt32(cbxClubs.SelectedValue);

                    //this is for debbuging and demo purposes, I wouldn't do this inside of a event handler
                    DataRowView currentClub = cbxClubs.SelectedItem as DataRowView;
                    if (currentClub != null)
                    {
                        Debug.WriteLine(currentClub["Club_ID"]);
                        Debug.WriteLine(currentClub["FirstClubID"]);
                        Debug.WriteLine(currentClub["LastClubID"]);
                        Debug.WriteLine(currentClub["RowNumber"]);
                        Debug.WriteLine(currentClub["NextClubID"]);
                        Debug.WriteLine(currentClub["PreviousClubID"]);
                        if (ClubIsSelected)
                        {
                            PopulateFields();
                            SetState(FormState.Update);
                        }
                        else
                        {
                            MessageBox.Show("Please select a product to display");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void NavigationButtonManagement()
        {
            SetNavigationState(false);
            if (currentClubId > 0)
            {
                SetState(FormState.Update);
            }
            else
            {
                ClearControls(groupBox1.Controls);
                SetState(FormState.Register);
            }

            btnPrevious.Enabled = previousClubId is not null;
            btnNext.Enabled = nextClubId is not null;

            btnFirst.Enabled = currentClubId != firstClubId;
            btnLast.Enabled = currentClubId != lastClubId;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            mdiParentForm.SetToolStrip("Ready...", true);
            SetState(FormState.Add);
            DisplayCurrentClub();
        }
        private void DisplayCurrentClub()
        {
            PopulateFields();
        }
        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
            mdiParentForm.SetToolStrip("", true);
        }
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;

            TextBox textBox = (TextBox)sender;

            if (textBox.Text == string.Empty)
            {
                errorMessage = $"{textBox.Tag} is required.";
                mdiParentForm.SetToolStrip("Please provide the Name and Description.", false);

            }
            errorProvider1.SetError(textBox, errorMessage);

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var response = Club.VerifyClubToDelete(Convert.ToInt32(txtId.Text));
                if (response == 0)
                {
                    if (MessageBox.Show($"Are you sure you want to delete the Club {txtName.Text}?", 
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        DeleteClub();
                    }
                    LoadFirstClub();
                }
                else
                {
                    MessageBox.Show("Unable to delete this club, it is vinculated to a contract.",
                        "Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void LoadFirstClub()
        {
            currentClubId = Club.GetFirstClub();
            PopulateFields();
        }
        private void DeleteClub()
        {
            var response = Club.DeleteClub(Convert.ToInt32(txtId.Text));
            if (response)
            {
                MessageBox.Show("Club deleted successfully.");
            }
            else
            {
                MessageBox.Show("Error deleting club.");
            }
        }
        private void SetState(FormState state)
        {
            currentState = state;
            LoadState(state);
        }
    }
}
