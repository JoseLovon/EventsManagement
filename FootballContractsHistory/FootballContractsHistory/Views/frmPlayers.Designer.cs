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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayers));
            cbxPosition = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            btnClear = new Button();
            btnRegister = new Button();
            pbxBack = new PictureBox();
            lblPlayers = new Label();
            pictureBox2 = new PictureBox();
            txtPlayer = new TextBox();
            pbxSearch = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cbxPosition
            // 
            cbxPosition.Cursor = Cursors.Hand;
            cbxPosition.FlatStyle = FlatStyle.System;
            cbxPosition.Font = new Font("Segoe UI Symbol", 9F);
            cbxPosition.FormattingEnabled = true;
            cbxPosition.Location = new Point(346, 320);
            cbxPosition.Name = "cbxPosition";
            cbxPosition.Size = new Size(283, 28);
            cbxPosition.Sorted = true;
            cbxPosition.TabIndex = 50;
            cbxPosition.Tag = "Position";
            cbxPosition.Text = " -- Select a position --";
            cbxPosition.Validating += cbx_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(237, 328);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 49;
            label5.Text = "Position:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(237, 251);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 47;
            label3.Text = "Player:";
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.Black;
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Symbol", 9F);
            btnClear.ImeMode = ImeMode.NoControl;
            btnClear.Location = new Point(446, 414);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 53);
            btnClear.TabIndex = 45;
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
            btnRegister.Location = new Point(279, 414);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(135, 53);
            btnRegister.TabIndex = 44;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
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
            // txtPlayer
            // 
            txtPlayer.BackColor = SystemColors.ButtonHighlight;
            txtPlayer.Font = new Font("Segoe UI Symbol", 9F);
            txtPlayer.Location = new Point(346, 240);
            txtPlayer.Multiline = true;
            txtPlayer.Name = "txtPlayer";
            txtPlayer.PlaceholderText = "Enter Player";
            txtPlayer.Size = new Size(283, 31);
            txtPlayer.TabIndex = 51;
            txtPlayer.Tag = "Player";
            txtPlayer.Validating += txt_Validating;
            // 
            // pbxSearch
            // 
            pbxSearch.BackColor = Color.White;
            pbxSearch.Cursor = Cursors.Hand;
            pbxSearch.Image = (Image)resources.GetObject("pbxSearch.Image");
            pbxSearch.ImeMode = ImeMode.NoControl;
            pbxSearch.Location = new Point(674, 240);
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
            // frmPlayers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(858, 635);
            Controls.Add(pbxSearch);
            Controls.Add(txtPlayer);
            Controls.Add(cbxPosition);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(pbxBack);
            Controls.Add(lblPlayers);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPlayers";
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Maximized;
            Load += frmBands_Load;
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxPosition;
        private Label label5;
        private Label label3;
        private Button btnClear;
        private Button btnRegister;
        private PictureBox pbxBack;
        private Label lblPlayers;
        private PictureBox pictureBox2;
        private TextBox txtPlayer;
        private PictureBox pbxSearch;
        private ErrorProvider errorProvider1;
    }
}