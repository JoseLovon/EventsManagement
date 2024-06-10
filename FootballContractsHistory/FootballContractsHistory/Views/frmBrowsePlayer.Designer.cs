namespace FootballContractsHistory.Views
{
    partial class frmBrowsePlayer
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowsePlayer));
            dgvPlayers = new DataGridView();
            pbxBack = new PictureBox();
            lblPlayers = new Label();
            pictureBox2 = new PictureBox();
            cbxPlayers = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvPlayers
            // 
            dgvPlayers.BackgroundColor = Color.White;
            dgvPlayers.BorderStyle = BorderStyle.None;
            dgvPlayers.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.BlanchedAlmond;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPlayers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPlayers.GridColor = SystemColors.HighlightText;
            dgvPlayers.Location = new Point(47, 288);
            dgvPlayers.Name = "dgvPlayers";
            dgvPlayers.RowHeadersWidth = 51;
            dgvPlayers.Size = new Size(735, 259);
            dgvPlayers.TabIndex = 91;
            // 
            // pbxBack
            // 
            pbxBack.BackColor = Color.FromArgb(99, 83, 56);
            pbxBack.Cursor = Cursors.Hand;
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.ImeMode = ImeMode.NoControl;
            pbxBack.Location = new Point(72, 50);
            pbxBack.Name = "pbxBack";
            pbxBack.Size = new Size(55, 47);
            pbxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBack.TabIndex = 90;
            pbxBack.TabStop = false;
            pbxBack.Click += pbxBack_Click;
            // 
            // lblPlayers
            // 
            lblPlayers.AutoSize = true;
            lblPlayers.BackColor = Color.FromArgb(73, 72, 61);
            lblPlayers.FlatStyle = FlatStyle.System;
            lblPlayers.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblPlayers.ForeColor = Color.White;
            lblPlayers.ImeMode = ImeMode.NoControl;
            lblPlayers.Location = new Point(377, 59);
            lblPlayers.Name = "lblPlayers";
            lblPlayers.Size = new Size(110, 38);
            lblPlayers.TabIndex = 89;
            lblPlayers.Text = "Players";
            lblPlayers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(829, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 88;
            pictureBox2.TabStop = false;
            // 
            // cbxPlayers
            // 
            cbxPlayers.Cursor = Cursors.Hand;
            cbxPlayers.FlatStyle = FlatStyle.System;
            cbxPlayers.Font = new Font("Segoe UI Symbol", 9F);
            cbxPlayers.FormattingEnabled = true;
            cbxPlayers.Location = new Point(339, 216);
            cbxPlayers.Name = "cbxPlayers";
            cbxPlayers.Size = new Size(283, 28);
            cbxPlayers.TabIndex = 92;
            cbxPlayers.Tag = "Player";
            cbxPlayers.SelectionChangeCommitted += cbxPlayers_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(198, 224);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 93;
            label1.Text = "Search by Player:";
            // 
            // frmBrowsePlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(827, 635);
            Controls.Add(cbxPlayers);
            Controls.Add(label1);
            Controls.Add(dgvPlayers);
            Controls.Add(pbxBack);
            Controls.Add(lblPlayers);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBrowsePlayer";
            StartPosition = FormStartPosition.Manual;
            Tag = "browsePlayer";
            Text = "frmBrowsePlayer";
            Load += frmSearchPlayers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxClubs;
        private DataGridView dgvPlayers;
        private PictureBox pbxBack;
        private Label lblPlayers;
        private PictureBox pictureBox2;
        private ComboBox cbxPlayers;
        private Label label1;
    }
}