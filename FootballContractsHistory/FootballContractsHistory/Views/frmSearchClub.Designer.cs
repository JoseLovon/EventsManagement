namespace FootballContractsHistory.Views
{
    partial class frmSearchClub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchClub));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pbxBack = new PictureBox();
            lblClubs = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            dgvClubs = new DataGridView();
            txtName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClubs).BeginInit();
            SuspendLayout();
            // 
            // pbxBack
            // 
            pbxBack.BackColor = Color.FromArgb(99, 83, 56);
            pbxBack.Cursor = Cursors.Hand;
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.ImeMode = ImeMode.NoControl;
            pbxBack.Location = new Point(71, 51);
            pbxBack.Name = "pbxBack";
            pbxBack.Size = new Size(55, 47);
            pbxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBack.TabIndex = 81;
            pbxBack.TabStop = false;
            pbxBack.Click += pbxBack_Click;
            // 
            // lblClubs
            // 
            lblClubs.AutoSize = true;
            lblClubs.BackColor = Color.FromArgb(73, 72, 61);
            lblClubs.FlatStyle = FlatStyle.System;
            lblClubs.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblClubs.ForeColor = Color.White;
            lblClubs.ImeMode = ImeMode.NoControl;
            lblClubs.Location = new Point(386, 60);
            lblClubs.Name = "lblClubs";
            lblClubs.Size = new Size(88, 38);
            lblClubs.TabIndex = 80;
            lblClubs.Text = "Clubs";
            lblClubs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(829, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 79;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(167, 216);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 83;
            label5.Text = "Search by Name:";
            // 
            // dgvClubs
            // 
            dgvClubs.BackgroundColor = Color.White;
            dgvClubs.BorderStyle = BorderStyle.None;
            dgvClubs.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvClubs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.BlanchedAlmond;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClubs.DefaultCellStyle = dataGridViewCellStyle1;
            dgvClubs.GridColor = SystemColors.HighlightText;
            dgvClubs.Location = new Point(49, 272);
            dgvClubs.Name = "dgvClubs";
            dgvClubs.RowHeadersWidth = 51;
            dgvClubs.Size = new Size(735, 259);
            dgvClubs.TabIndex = 84;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonHighlight;
            txtName.Font = new Font("Segoe UI Symbol", 9F);
            txtName.Location = new Point(332, 205);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 31);
            txtName.TabIndex = 85;
            txtName.Tag = "Name";
            txtName.KeyPress += txtName_KeyPress;
            // 
            // frmSearchClub
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(827, 635);
            Controls.Add(txtName);
            Controls.Add(dgvClubs);
            Controls.Add(label5);
            Controls.Add(pbxBack);
            Controls.Add(lblClubs);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSearchClub";
            StartPosition = FormStartPosition.Manual;
            Tag = "searchClub";
            Text = "frmSearchClub";
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClubs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxBack;
        private Label lblClubs;
        private PictureBox pictureBox2;
        private Label label5;
        private DataGridView dgvClubs;
        private TextBox txtName;
    }
}