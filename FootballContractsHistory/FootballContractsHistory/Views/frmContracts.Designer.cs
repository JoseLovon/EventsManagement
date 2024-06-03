namespace FootballContractsHistory
{
    partial class frmContracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContracts));
            pbxBack = new PictureBox();
            lblPlayers = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            txtId = new TextBox();
            btnRegisterUpdate = new Button();
            label6 = new Label();
            btnClear = new Button();
            btnNext = new Button();
            btnAdd = new Button();
            btnLast = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            dtpCreationDate = new DateTimePicker();
            label1 = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            cbxPlayers = new ComboBox();
            cbxClubs = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            cbxContracts = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbxBack
            // 
            pbxBack.BackColor = Color.FromArgb(99, 83, 56);
            pbxBack.Cursor = Cursors.Hand;
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.ImeMode = ImeMode.NoControl;
            pbxBack.Location = new Point(39, 56);
            pbxBack.Name = "pbxBack";
            pbxBack.Size = new Size(73, 47);
            pbxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBack.TabIndex = 66;
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
            lblPlayers.Location = new Point(327, 65);
            lblPlayers.Name = "lblPlayers";
            lblPlayers.Size = new Size(141, 38);
            lblPlayers.TabIndex = 65;
            lblPlayers.Text = "Contracts";
            lblPlayers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(-6, -6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(836, 164);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnRegisterUpdate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnLast);
            groupBox1.Controls.Add(btnPrevious);
            groupBox1.Controls.Add(btnFirst);
            groupBox1.Controls.Add(dtpCreationDate);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpEndDate);
            groupBox1.Controls.Add(dtpStartDate);
            groupBox1.Controls.Add(cbxPlayers);
            groupBox1.Controls.Add(cbxClubs);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(54, 226);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 397);
            groupBox1.TabIndex = 67;
            groupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Symbol", 9F);
            btnDelete.ForeColor = Color.White;
            btnDelete.ImeMode = ImeMode.NoControl;
            btnDelete.Location = new Point(554, 199);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 53);
            btnDelete.TabIndex = 71;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ButtonHighlight;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI Symbol", 9F);
            txtId.Location = new Point(177, 35);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(283, 34);
            txtId.TabIndex = 88;
            txtId.Tag = "Club Name";
            // 
            // btnRegisterUpdate
            // 
            btnRegisterUpdate.BackColor = Color.CornflowerBlue;
            btnRegisterUpdate.Cursor = Cursors.Hand;
            btnRegisterUpdate.FlatAppearance.BorderSize = 0;
            btnRegisterUpdate.FlatStyle = FlatStyle.Flat;
            btnRegisterUpdate.Font = new Font("Segoe UI Symbol", 9F);
            btnRegisterUpdate.ForeColor = Color.White;
            btnRegisterUpdate.ImeMode = ImeMode.NoControl;
            btnRegisterUpdate.Location = new Point(554, 134);
            btnRegisterUpdate.Name = "btnRegisterUpdate";
            btnRegisterUpdate.Size = new Size(135, 53);
            btnRegisterUpdate.TabIndex = 70;
            btnRegisterUpdate.Text = "Register";
            btnRegisterUpdate.UseVisualStyleBackColor = false;
            btnRegisterUpdate.Click += btnRegisterUpdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 49);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 89;
            label6.Text = "ID:";
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(22, 30, 45);
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Symbol", 9F);
            btnClear.ImeMode = ImeMode.NoControl;
            btnClear.Location = new Point(554, 258);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 53);
            btnClear.TabIndex = 69;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnNext
            // 
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(22, 30, 45);
            btnNext.FlatAppearance.BorderSize = 2;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Symbol", 12F);
            btnNext.Location = new Point(314, 335);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(35, 42);
            btnNext.TabIndex = 87;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += Navigation_Handler;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Symbol", 9F);
            btnAdd.ForeColor = Color.White;
            btnAdd.ImeMode = ImeMode.NoControl;
            btnAdd.Location = new Point(554, 75);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 53);
            btnAdd.TabIndex = 68;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLast
            // 
            btnLast.Cursor = Cursors.Hand;
            btnLast.FlatAppearance.BorderColor = Color.FromArgb(22, 30, 45);
            btnLast.FlatAppearance.BorderSize = 2;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Segoe UI Symbol", 12F);
            btnLast.Location = new Point(355, 335);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(53, 42);
            btnLast.TabIndex = 86;
            btnLast.Text = ">>";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += Navigation_Handler;
            // 
            // btnPrevious
            // 
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatAppearance.BorderColor = Color.FromArgb(22, 30, 45);
            btnPrevious.FlatAppearance.BorderSize = 2;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI Symbol", 12F);
            btnPrevious.Location = new Point(273, 335);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(35, 42);
            btnPrevious.TabIndex = 85;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += Navigation_Handler;
            // 
            // btnFirst
            // 
            btnFirst.Cursor = Cursors.Hand;
            btnFirst.FlatAppearance.BorderColor = Color.FromArgb(22, 30, 45);
            btnFirst.FlatAppearance.BorderSize = 2;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Font = new Font("Segoe UI Symbol", 12F);
            btnFirst.Location = new Point(214, 335);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(53, 42);
            btnFirst.TabIndex = 84;
            btnFirst.Text = "<<";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += Navigation_Handler;
            // 
            // dtpCreationDate
            // 
            dtpCreationDate.Enabled = false;
            dtpCreationDate.Location = new Point(177, 285);
            dtpCreationDate.Name = "dtpCreationDate";
            dtpCreationDate.Size = new Size(283, 27);
            dtpCreationDate.TabIndex = 82;
            dtpCreationDate.Value = new DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(45, 290);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 83;
            label1.Text = "Creation Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(177, 238);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(283, 27);
            dtpEndDate.TabIndex = 77;
            dtpEndDate.Value = new DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(177, 191);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(283, 27);
            dtpStartDate.TabIndex = 68;
            dtpStartDate.Value = new DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // cbxPlayers
            // 
            cbxPlayers.Cursor = Cursors.Hand;
            cbxPlayers.FlatStyle = FlatStyle.System;
            cbxPlayers.Font = new Font("Segoe UI Symbol", 9F);
            cbxPlayers.FormattingEnabled = true;
            cbxPlayers.Location = new Point(177, 143);
            cbxPlayers.Name = "cbxPlayers";
            cbxPlayers.Size = new Size(283, 28);
            cbxPlayers.Sorted = true;
            cbxPlayers.TabIndex = 72;
            cbxPlayers.Tag = "Player";
            cbxPlayers.Validating += cbx_Validating;
            // 
            // cbxClubs
            // 
            cbxClubs.Cursor = Cursors.Hand;
            cbxClubs.FlatStyle = FlatStyle.System;
            cbxClubs.Font = new Font("Segoe UI Symbol", 9F);
            cbxClubs.FormattingEnabled = true;
            cbxClubs.Location = new Point(177, 88);
            cbxClubs.Name = "cbxClubs";
            cbxClubs.Size = new Size(283, 28);
            cbxClubs.Sorted = true;
            cbxClubs.TabIndex = 74;
            cbxClubs.Tag = "Club";
            cbxClubs.Validating += cbx_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(45, 240);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 75;
            label2.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(45, 91);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 73;
            label5.Text = "Club:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(45, 193);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 70;
            label4.Text = "Start Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(45, 146);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 71;
            label3.Text = "Player:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // cbxContracts
            // 
            cbxContracts.Cursor = Cursors.Hand;
            cbxContracts.FlatStyle = FlatStyle.System;
            cbxContracts.Font = new Font("Segoe UI Symbol", 9F);
            cbxContracts.FormattingEnabled = true;
            cbxContracts.Location = new Point(231, 180);
            cbxContracts.Name = "cbxContracts";
            cbxContracts.Size = new Size(280, 28);
            cbxContracts.TabIndex = 1;
            cbxContracts.Tag = "search";
            cbxContracts.SelectionChangeCommitted += cbxContracts_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(99, 188);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 83;
            label7.Text = "Search Contract:";
            // 
            // frmContracts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(827, 635);
            Controls.Add(cbxContracts);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(pbxBack);
            Controls.Add(lblPlayers);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmContracts";
            StartPosition = FormStartPosition.Manual;
            Load += frmContracts_Load;
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbxBack;
        private Label lblPlayers;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private ComboBox cbxPlayers;
        private ComboBox cbxClubs;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private ErrorProvider errorProvider1;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Button btnNext;
        private Button btnLast;
        private Button btnPrevious;
        private Button btnFirst;
        private DateTimePicker dtpCreationDate;
        private Label label1;
        private TextBox txtId;
        private Label label6;
        private Button btnDelete;
        private Button btnRegisterUpdate;
        private Button btnClear;
        private Button btnAdd;
        private ComboBox cbxContracts;
        private Label label7;
    }
}