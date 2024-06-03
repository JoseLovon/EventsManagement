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
            pbxBack = new PictureBox();
            lblPlayers = new Label();
            pictureBox2 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            txtId = new TextBox();
            btnRegisterUpdate = new Button();
            label1 = new Label();
            btnClear = new Button();
            btnNext = new Button();
            btnAdd = new Button();
            btnLast = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            dtpCreationDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            cbxPosition = new ComboBox();
            label3 = new Label();
            txtPlayer = new TextBox();
            cbxPlayers = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            lblPlayers.Location = new Point(353, 67);
            lblPlayers.Name = "lblPlayers";
            lblPlayers.Size = new Size(110, 38);
            lblPlayers.TabIndex = 42;
            lblPlayers.Text = "Players";
            lblPlayers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(-3, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(831, 173);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnRegisterUpdate);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnLast);
            groupBox1.Controls.Add(btnPrevious);
            groupBox1.Controls.Add(btnFirst);
            groupBox1.Controls.Add(dtpCreationDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbxPosition);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPlayer);
            groupBox1.Location = new Point(32, 241);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 382);
            groupBox1.TabIndex = 53;
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
            btnDelete.Location = new Point(593, 178);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 53);
            btnDelete.TabIndex = 67;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ButtonHighlight;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI Symbol", 9F);
            txtId.Location = new Point(222, 54);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(283, 34);
            txtId.TabIndex = 66;
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
            btnRegisterUpdate.Location = new Point(593, 113);
            btnRegisterUpdate.Name = "btnRegisterUpdate";
            btnRegisterUpdate.Size = new Size(135, 53);
            btnRegisterUpdate.TabIndex = 66;
            btnRegisterUpdate.Text = "Register";
            btnRegisterUpdate.UseVisualStyleBackColor = false;
            btnRegisterUpdate.Click += btnRegisterUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 68);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 67;
            label1.Text = "ID:";
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(22, 30, 45);
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Symbol", 9F);
            btnClear.ImeMode = ImeMode.NoControl;
            btnClear.Location = new Point(593, 237);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 53);
            btnClear.TabIndex = 65;
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
            btnNext.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(363, 306);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(35, 42);
            btnNext.TabIndex = 97;
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
            btnAdd.Location = new Point(593, 54);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 53);
            btnAdd.TabIndex = 64;
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
            btnLast.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLast.Location = new Point(404, 306);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(53, 42);
            btnLast.TabIndex = 96;
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
            btnPrevious.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrevious.Location = new Point(322, 306);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(35, 42);
            btnPrevious.TabIndex = 95;
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
            btnFirst.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFirst.Location = new Point(263, 306);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(53, 42);
            btnFirst.TabIndex = 94;
            btnFirst.Text = "<<";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += Navigation_Handler;
            // 
            // dtpCreationDate
            // 
            dtpCreationDate.Enabled = false;
            dtpCreationDate.Location = new Point(222, 245);
            dtpCreationDate.Name = "dtpCreationDate";
            dtpCreationDate.Size = new Size(283, 27);
            dtpCreationDate.TabIndex = 92;
            dtpCreationDate.Value = new DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(91, 252);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 93;
            label4.Text = "Creation Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(91, 183);
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
            cbxPosition.Location = new Point(222, 175);
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
            label3.Location = new Point(91, 126);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 54;
            label3.Text = "Player:";
            // 
            // txtPlayer
            // 
            txtPlayer.BackColor = SystemColors.ButtonHighlight;
            txtPlayer.Font = new Font("Segoe UI Symbol", 9F);
            txtPlayer.Location = new Point(222, 115);
            txtPlayer.Multiline = true;
            txtPlayer.Name = "txtPlayer";
            txtPlayer.PlaceholderText = "Enter Player";
            txtPlayer.Size = new Size(283, 31);
            txtPlayer.TabIndex = 1;
            txtPlayer.Tag = "Player";
            // 
            // cbxPlayers
            // 
            cbxPlayers.Cursor = Cursors.Hand;
            cbxPlayers.FlatStyle = FlatStyle.System;
            cbxPlayers.Font = new Font("Segoe UI Symbol", 9F);
            cbxPlayers.FormattingEnabled = true;
            cbxPlayers.Location = new Point(254, 207);
            cbxPlayers.Name = "cbxPlayers";
            cbxPlayers.Size = new Size(280, 28);
            cbxPlayers.TabIndex = 1;
            cbxPlayers.Tag = "search";
            cbxPlayers.SelectionChangeCommitted += cbxPlayers_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(123, 215);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 81;
            label2.Text = "Search Player:";
            // 
            // frmPlayers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(827, 635);
            Controls.Add(cbxPlayers);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(pbxBack);
            Controls.Add(lblPlayers);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPlayers";
            StartPosition = FormStartPosition.Manual;
            Tag = "players";
            Load += frmPlayers_Load;
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbxBack;
        private Label lblPlayers;
        private PictureBox pictureBox2;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox1;
        private Label label5;
        private ComboBox cbxPosition;
        private Label label3;
        private TextBox txtPlayer;
        private Button btnNext;
        private Button btnLast;
        private Button btnPrevious;
        private Button btnFirst;
        private DateTimePicker dtpCreationDate;
        private Label label4;
        private TextBox txtId;
        private Label label1;
        private Button btnDelete;
        private Button btnRegisterUpdate;
        private Button btnClear;
        private Button btnAdd;
        private ComboBox cbxPlayers;
        private Label label2;
    }
}