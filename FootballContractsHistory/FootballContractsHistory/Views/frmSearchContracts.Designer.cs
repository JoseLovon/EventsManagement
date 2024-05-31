namespace FootballContractsHistory.Views
{
    partial class frmSearchContracts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param playerName="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchContracts));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pbxBack = new PictureBox();
            lblPlayers = new Label();
            pictureBox2 = new PictureBox();
            dgvContracts = new DataGridView();
            label5 = new Label();
            label1 = new Label();
            cbxClubs = new ComboBox();
            cbxPlayers = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContracts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbxBack
            // 
            pbxBack.BackColor = Color.FromArgb(99, 83, 56);
            pbxBack.Cursor = Cursors.Hand;
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.ImeMode = ImeMode.NoControl;
            pbxBack.Location = new Point(44, 60);
            pbxBack.Name = "pbxBack";
            pbxBack.Size = new Size(60, 47);
            pbxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBack.TabIndex = 69;
            pbxBack.TabStop = false;
            // 
            // lblPlayers
            // 
            lblPlayers.AutoSize = true;
            lblPlayers.BackColor = Color.FromArgb(73, 72, 61);
            lblPlayers.FlatStyle = FlatStyle.System;
            lblPlayers.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblPlayers.ForeColor = Color.White;
            lblPlayers.ImeMode = ImeMode.NoControl;
            lblPlayers.Location = new Point(399, 69);
            lblPlayers.Name = "lblPlayers";
            lblPlayers.Size = new Size(141, 38);
            lblPlayers.TabIndex = 68;
            lblPlayers.Text = "Contracts";
            lblPlayers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(-1, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(854, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 67;
            pictureBox2.TabStop = false;
            // 
            // dgvContracts
            // 
            dgvContracts.BackgroundColor = Color.White;
            dgvContracts.BorderStyle = BorderStyle.None;
            dgvContracts.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.BlanchedAlmond;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvContracts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvContracts.GridColor = SystemColors.HighlightText;
            dgvContracts.Location = new Point(109, 375);
            dgvContracts.Name = "dgvContracts";
            dgvContracts.RowHeadersWidth = 51;
            dgvContracts.Size = new Size(639, 193);
            dgvContracts.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(194, 242);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 65;
            label5.Text = "Search by Club:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(194, 306);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 71;
            label1.Text = "Search by Player:";
            // 
            // cbxClubs
            // 
            cbxClubs.Cursor = Cursors.Hand;
            cbxClubs.FlatStyle = FlatStyle.System;
            cbxClubs.Font = new Font("Segoe UI Symbol", 9F);
            cbxClubs.FormattingEnabled = true;
            cbxClubs.Location = new Point(335, 234);
            cbxClubs.Name = "cbxClubs";
            cbxClubs.Size = new Size(283, 28);
            cbxClubs.Sorted = true;
            cbxClubs.TabIndex = 72;
            cbxClubs.Tag = "Club";
            cbxClubs.SelectedIndexChanged += cbxClubs_SelectedIndexChanged;
            // 
            // cbxPlayers
            // 
            cbxPlayers.Cursor = Cursors.Hand;
            cbxPlayers.FlatStyle = FlatStyle.System;
            cbxPlayers.Font = new Font("Segoe UI Symbol", 9F);
            cbxPlayers.FormattingEnabled = true;
            cbxPlayers.Location = new Point(335, 298);
            cbxPlayers.Name = "cbxPlayers";
            cbxPlayers.Size = new Size(283, 28);
            cbxPlayers.Sorted = true;
            cbxPlayers.TabIndex = 73;
            cbxPlayers.Tag = "Player";
            cbxPlayers.SelectedIndexChanged += cbxPlayers_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmSearchContracts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 635);
            Controls.Add(cbxPlayers);
            Controls.Add(cbxClubs);
            Controls.Add(label1);
            Controls.Add(pbxBack);
            Controls.Add(lblPlayers);
            Controls.Add(pictureBox2);
            Controls.Add(dgvContracts);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSearchContracts";
            Text = "frmSearch";
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContracts).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxBack;
        private Label lblPlayers;
        private PictureBox pictureBox2;
        private DataGridView dgvContracts;
        private Label label5;
        private Label label1;
        private ComboBox cbxClubs;
        private ComboBox cbxPlayers;
        private ErrorProvider errorProvider1;
    }
}