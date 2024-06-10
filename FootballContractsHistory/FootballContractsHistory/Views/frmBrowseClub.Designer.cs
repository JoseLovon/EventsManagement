namespace FootballContractsHistory.Views
{
    partial class frmBrowseClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowseClub));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pbxBack = new PictureBox();
            lblClubs = new Label();
            pictureBox2 = new PictureBox();
            dgvClubs = new DataGridView();
            cbxClubs = new ComboBox();
            label1 = new Label();
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
            lblClubs.Location = new Point(396, 60);
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
            dgvClubs.Location = new Point(46, 276);
            dgvClubs.Name = "dgvClubs";
            dgvClubs.RowHeadersWidth = 51;
            dgvClubs.Size = new Size(735, 259);
            dgvClubs.TabIndex = 84;
            // 
            // cbxClubs
            // 
            cbxClubs.Cursor = Cursors.Hand;
            cbxClubs.FlatStyle = FlatStyle.System;
            cbxClubs.Font = new Font("Segoe UI Symbol", 9F);
            cbxClubs.FormattingEnabled = true;
            cbxClubs.Location = new Point(350, 215);
            cbxClubs.Name = "cbxClubs";
            cbxClubs.Size = new Size(283, 28);
            cbxClubs.TabIndex = 86;
            cbxClubs.Tag = "Club";
            cbxClubs.SelectionChangeCommitted += cbxClubs_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(199, 223);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 87;
            label1.Text = "Search by Club:";
            // 
            // frmBrowseClub
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(827, 635);
            Controls.Add(cbxClubs);
            Controls.Add(label1);
            Controls.Add(dgvClubs);
            Controls.Add(pbxBack);
            Controls.Add(lblClubs);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBrowseClub";
            StartPosition = FormStartPosition.Manual;
            Tag = "browseClub";
            Text = "frmBrowseClub";
            Load += frmSearchClubs_Load;
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
        private DataGridView dgvClubs;
        private ComboBox cbxClubs;
        private Label label1;
    }
}