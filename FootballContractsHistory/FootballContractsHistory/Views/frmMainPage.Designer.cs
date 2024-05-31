namespace FootballContractsHistory.Views
{
    partial class frmMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            pbxClubs = new PictureBox();
            pbxPlayers = new PictureBox();
            pbxContracts = new PictureBox();
            pbxLogout = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pbxClubLogo = new PictureBox();
            pbxPlayerLogo = new PictureBox();
            pbxContractLogo = new PictureBox();
            pbxLogoutLogo = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxClubs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxContracts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxClubLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPlayerLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxContractLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogoutLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pbxClubs
            // 
            pbxClubs.BackColor = Color.White;
            pbxClubs.Cursor = Cursors.Hand;
            pbxClubs.Location = new Point(155, 111);
            pbxClubs.Name = "pbxClubs";
            pbxClubs.Size = new Size(201, 187);
            pbxClubs.TabIndex = 0;
            pbxClubs.TabStop = false;
            pbxClubs.Click += pbxClubs_Click;
            pbxClubs.MouseDown += pbxClubs_MouseDown;
            pbxClubs.MouseLeave += pbxClubs_MouseLeave;
            pbxClubs.MouseHover += pbxClubs_MouseHover;
            // 
            // pbxPlayers
            // 
            pbxPlayers.BackColor = Color.White;
            pbxPlayers.Cursor = Cursors.Hand;
            pbxPlayers.Location = new Point(486, 111);
            pbxPlayers.Name = "pbxPlayers";
            pbxPlayers.Size = new Size(201, 187);
            pbxPlayers.TabIndex = 1;
            pbxPlayers.TabStop = false;
            pbxPlayers.Click += pbxPlayers_Click;
            pbxPlayers.MouseDown += pbxPlayers_MouseDown;
            pbxPlayers.MouseLeave += pbxPlayers_MouseLeave;
            pbxPlayers.MouseHover += pbxPlayers_MouseHover;
            // 
            // pbxContracts
            // 
            pbxContracts.BackColor = Color.White;
            pbxContracts.Cursor = Cursors.Hand;
            pbxContracts.Location = new Point(155, 372);
            pbxContracts.Name = "pbxContracts";
            pbxContracts.Size = new Size(201, 187);
            pbxContracts.TabIndex = 2;
            pbxContracts.TabStop = false;
            pbxContracts.Click += pbxContracts_Click;
            pbxContracts.MouseDown += pbxContracts_MouseDown;
            pbxContracts.MouseLeave += pbxContracts_MouseLeave;
            pbxContracts.MouseHover += pbxContracts_MouseHover;
            // 
            // pbxLogout
            // 
            pbxLogout.BackColor = Color.White;
            pbxLogout.Cursor = Cursors.Hand;
            pbxLogout.Location = new Point(486, 372);
            pbxLogout.Name = "pbxLogout";
            pbxLogout.Size = new Size(201, 187);
            pbxLogout.TabIndex = 3;
            pbxLogout.TabStop = false;
            pbxLogout.Click += pbxLogout_Click;
            pbxLogout.MouseDown += pbxLogout_MouseDown;
            pbxLogout.MouseLeave += pbxLogout_MouseLeave;
            pbxLogout.MouseHover += pbxLogout_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 243);
            label1.Name = "label1";
            label1.Size = new Size(90, 38);
            label1.TabIndex = 1;
            label1.Text = "Clubs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(533, 243);
            label2.Name = "label2";
            label2.Size = new Size(112, 38);
            label2.TabIndex = 4;
            label2.Text = "Players";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(184, 505);
            label3.Name = "label3";
            label3.Size = new Size(142, 38);
            label3.TabIndex = 5;
            label3.Text = "Contracts";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(536, 505);
            label4.Name = "label4";
            label4.Size = new Size(109, 38);
            label4.TabIndex = 6;
            label4.Text = "Logout";
            // 
            // pbxClubLogo
            // 
            pbxClubLogo.Cursor = Cursors.Hand;
            pbxClubLogo.Image = (Image)resources.GetObject("pbxClubLogo.Image");
            pbxClubLogo.Location = new Point(199, 139);
            pbxClubLogo.Name = "pbxClubLogo";
            pbxClubLogo.Size = new Size(114, 89);
            pbxClubLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxClubLogo.TabIndex = 7;
            pbxClubLogo.TabStop = false;
            pbxClubLogo.Click += pbxClubLogo_Click;
            pbxClubLogo.MouseDown += pbxClubs_MouseDown;
            pbxClubLogo.MouseLeave += pbxClubs_MouseLeave;
            pbxClubLogo.MouseHover += pbxClubs_MouseHover;
            // 
            // pbxPlayerLogo
            // 
            pbxPlayerLogo.Cursor = Cursors.Hand;
            pbxPlayerLogo.Image = (Image)resources.GetObject("pbxPlayerLogo.Image");
            pbxPlayerLogo.Location = new Point(531, 139);
            pbxPlayerLogo.Name = "pbxPlayerLogo";
            pbxPlayerLogo.Size = new Size(114, 89);
            pbxPlayerLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPlayerLogo.TabIndex = 8;
            pbxPlayerLogo.TabStop = false;
            pbxPlayerLogo.Click += pbxPlayerLogo_Click;
            pbxPlayerLogo.MouseDown += pbxPlayers_MouseDown;
            pbxPlayerLogo.MouseLeave += pbxPlayers_MouseLeave;
            pbxPlayerLogo.MouseHover += pbxPlayers_MouseHover;
            // 
            // pbxContractLogo
            // 
            pbxContractLogo.Cursor = Cursors.Hand;
            pbxContractLogo.Image = (Image)resources.GetObject("pbxContractLogo.Image");
            pbxContractLogo.Location = new Point(199, 401);
            pbxContractLogo.Name = "pbxContractLogo";
            pbxContractLogo.Size = new Size(114, 89);
            pbxContractLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxContractLogo.TabIndex = 9;
            pbxContractLogo.TabStop = false;
            pbxContractLogo.Click += pbxContractLogo_Click;
            pbxContractLogo.MouseDown += pbxContracts_MouseDown;
            pbxContractLogo.MouseLeave += pbxContracts_MouseLeave;
            pbxContractLogo.MouseHover += pbxContracts_MouseHover;
            // 
            // pbxLogoutLogo
            // 
            pbxLogoutLogo.Cursor = Cursors.Hand;
            pbxLogoutLogo.Image = (Image)resources.GetObject("pbxLogoutLogo.Image");
            pbxLogoutLogo.Location = new Point(533, 401);
            pbxLogoutLogo.Name = "pbxLogoutLogo";
            pbxLogoutLogo.Size = new Size(114, 89);
            pbxLogoutLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxLogoutLogo.TabIndex = 10;
            pbxLogoutLogo.TabStop = false;
            pbxLogoutLogo.Click += pbxLogoutLogo_Click;
            pbxLogoutLogo.MouseDown += pbxLogout_MouseDown;
            pbxLogoutLogo.MouseLeave += pbxLogout_MouseLeave;
            pbxLogoutLogo.MouseHover += pbxLogout_MouseHover;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox5.Location = new Point(-1, -1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(855, 67);
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // frmMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(858, 635);
            Controls.Add(pictureBox5);
            Controls.Add(pbxLogoutLogo);
            Controls.Add(pbxContractLogo);
            Controls.Add(pbxPlayerLogo);
            Controls.Add(pbxClubLogo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbxLogout);
            Controls.Add(pbxContracts);
            Controls.Add(pbxPlayers);
            Controls.Add(pbxClubs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMainPage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmMainPage";
            Load += frmMainPage_Load;
            ((System.ComponentModel.ISupportInitialize)pbxClubs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxContracts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxClubLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPlayerLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxContractLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogoutLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxClubs;
        private PictureBox pbxPlayers;
        private PictureBox pbxContracts;
        private PictureBox pbxLogout;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pbxClubLogo;
        private PictureBox pbxPlayerLogo;
        private PictureBox pbxContractLogo;
        private PictureBox pbxLogoutLogo;
        private PictureBox pictureBox5;
    }
}