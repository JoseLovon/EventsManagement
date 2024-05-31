namespace FootballContractsHistory
{
    partial class frmPlayers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayers));
            btnClear = new Button();
            btnRegister = new Button();
            pbxBack = new PictureBox();
            lblPlayers = new Label();
            pictureBox2 = new PictureBox();
            pbxSearch = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            label5 = new Label();
            cbxPosition = new ComboBox();
            label3 = new Label();
            txtPlayer = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.Black;
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Symbol", 9F);
            btnClear.ImeMode = ImeMode.NoControl;
            btnClear.Location = new Point(282, 236);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 53);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(192, 0, 0);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Symbol", 9F);
            btnRegister.ForeColor = Color.White;
            btnRegister.ImeMode = ImeMode.NoControl;
            btnRegister.Location = new Point(141, 236);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(135, 53);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegisterUpdate_Click;
            // 
            // pbxBack
            // 
            pbxBack.BackColor = Color.FromArgb(99, 83, 56);
            pbxBack.Cursor = Cursors.Hand;
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.ImeMode = ImeMode.NoControl;
            pbxBack.Location = new Point(47, 58);
            pbxBack.Name = "pbxBack";
            pbxBack.Size = new Size(60, 47);
            pbxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBack.TabIndex = 43;
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
            lblPlayers.Location = new Point(383, 67);
            lblPlayers.Name = "lblPlayers";
            lblPlayers.Size = new Size(110, 38);
            lblPlayers.TabIndex = 42;
            lblPlayers.Text = "Players";
            lblPlayers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(-3, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(865, 173);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // pbxSearch
            // 
            pbxSearch.BackColor = Color.White;
            pbxSearch.Cursor = Cursors.Hand;
            pbxSearch.Image = (Image)resources.GetObject("pbxSearch.Image");
            pbxSearch.ImeMode = ImeMode.NoControl;
            pbxSearch.Location = new Point(507, 63);
            pbxSearch.Name = "pbxSearch";
            pbxSearch.Size = new Size(30, 31);
            pbxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxSearch.TabIndex = 52;
            pbxSearch.TabStop = false;
            pbxSearch.Click += pbxSearch_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(pbxSearch);
            groupBox1.Controls.Add(cbxPosition);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPlayer);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Location = new Point(144, 219);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 339);
            groupBox1.TabIndex = 53;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(71, 151);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 55;
            label5.Text = "Position:";
            // 
            // cbxPosition
            // 
            cbxPosition.Cursor = Cursors.Hand;
            cbxPosition.FlatStyle = FlatStyle.System;
            cbxPosition.Font = new Font("Segoe UI Symbol", 9F);
            cbxPosition.FormattingEnabled = true;
            cbxPosition.Location = new Point(184, 143);
            cbxPosition.Name = "cbxPosition";
            cbxPosition.Size = new Size(283, 28);
            cbxPosition.Sorted = true;
            cbxPosition.TabIndex = 2;
            cbxPosition.Tag = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(71, 74);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 54;
            label3.Text = "Player:";
            // 
            // txtPlayer
            // 
            txtPlayer.BackColor = SystemColors.ButtonHighlight;
            txtPlayer.Font = new Font("Segoe UI Symbol", 9F);
            txtPlayer.Location = new Point(184, 63);
            txtPlayer.Multiline = true;
            txtPlayer.Name = "txtPlayer";
            txtPlayer.PlaceholderText = "Enter Player";
            txtPlayer.Size = new Size(283, 31);
            txtPlayer.TabIndex = 1;
            txtPlayer.Tag = "Player";
            // 
            // frmPlayers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(858, 635);
            Controls.Add(groupBox1);
            Controls.Add(pbxBack);
            Controls.Add(lblPlayers);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPlayers";
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Maximized;
            Load += frmPlayers_Load;
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnClear;
        private Button btnRegister;
        private PictureBox pbxBack;
        private Label lblPlayers;
        private PictureBox pictureBox2;
        private PictureBox pbxSearch;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox1;
        private Label label5;
        private ComboBox cbxPosition;
        private Label label3;
        private TextBox txtPlayer;
    }
}