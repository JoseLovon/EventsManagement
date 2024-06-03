namespace FootballContractsHistory.Views
{
    partial class frmClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClub));
            cbxClubs = new ComboBox();
            label5 = new Label();
            pbxBack = new PictureBox();
            lblClubs = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            btnNext = new Button();
            btnLast = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            dtpCreationDate = new DateTimePicker();
            label4 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            btnRegisterUpdate = new Button();
            btnClear = new Button();
            txtName = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cbxClubs
            // 
            cbxClubs.Cursor = Cursors.Hand;
            cbxClubs.FlatStyle = FlatStyle.System;
            cbxClubs.Font = new Font("Segoe UI Symbol", 9F);
            cbxClubs.FormattingEnabled = true;
            cbxClubs.Location = new Point(275, 167);
            cbxClubs.Name = "cbxClubs";
            cbxClubs.Size = new Size(280, 28);
            cbxClubs.TabIndex = 1;
            cbxClubs.Tag = "search";
            cbxClubs.SelectionChangeCommitted += cbxClubs_SelectionChangeCommitted;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(159, 175);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 79;
            label5.Text = "Search Club:";
            // 
            // pbxBack
            // 
            pbxBack.BackColor = Color.FromArgb(99, 83, 56);
            pbxBack.Cursor = Cursors.Hand;
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.ImeMode = ImeMode.NoControl;
            pbxBack.Location = new Point(55, 28);
            pbxBack.Name = "pbxBack";
            pbxBack.Size = new Size(60, 47);
            pbxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBack.TabIndex = 78;
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
            lblClubs.Location = new Point(393, 37);
            lblClubs.Name = "lblClubs";
            lblClubs.Size = new Size(88, 38);
            lblClubs.TabIndex = 77;
            lblClubs.Text = "Clubs";
            lblClubs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(830, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 76;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(btnLast);
            groupBox1.Controls.Add(btnPrevious);
            groupBox1.Controls.Add(btnFirst);
            groupBox1.Controls.Add(dtpCreationDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnRegisterUpdate);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(58, 214);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 394);
            groupBox1.TabIndex = 75;
            groupBox1.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(22, 30, 45);
            btnNext.FlatAppearance.BorderSize = 2;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Symbol", 12F);
            btnNext.Location = new Point(350, 328);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(35, 42);
            btnNext.TabIndex = 77;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += Navigation_Handler;
            // 
            // btnLast
            // 
            btnLast.Cursor = Cursors.Hand;
            btnLast.FlatAppearance.BorderColor = Color.FromArgb(22, 30, 45);
            btnLast.FlatAppearance.BorderSize = 2;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Segoe UI Symbol", 12F);
            btnLast.Location = new Point(391, 328);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(53, 42);
            btnLast.TabIndex = 76;
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
            btnPrevious.Location = new Point(309, 328);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(35, 42);
            btnPrevious.TabIndex = 75;
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
            btnFirst.Location = new Point(250, 328);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(53, 42);
            btnFirst.TabIndex = 74;
            btnFirst.Text = "<<";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += Navigation_Handler;
            // 
            // dtpCreationDate
            // 
            dtpCreationDate.Enabled = false;
            dtpCreationDate.Location = new Point(217, 274);
            dtpCreationDate.Name = "dtpCreationDate";
            dtpCreationDate.Size = new Size(280, 27);
            dtpCreationDate.TabIndex = 71;
            dtpCreationDate.Value = new DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(101, 279);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 72;
            label4.Text = "Creation Date:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ButtonHighlight;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI Symbol", 9F);
            txtId.Location = new Point(217, 26);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(280, 34);
            txtId.TabIndex = 64;
            txtId.Tag = "Club Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 40);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 65;
            label1.Text = "ID:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Symbol", 9F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(543, 186);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 53);
            btnDelete.TabIndex = 63;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRegisterUpdate
            // 
            btnRegisterUpdate.BackColor = Color.CornflowerBlue;
            btnRegisterUpdate.Cursor = Cursors.Hand;
            btnRegisterUpdate.FlatAppearance.BorderSize = 0;
            btnRegisterUpdate.FlatStyle = FlatStyle.Flat;
            btnRegisterUpdate.Font = new Font("Segoe UI Symbol", 9F);
            btnRegisterUpdate.ForeColor = Color.White;
            btnRegisterUpdate.Location = new Point(543, 121);
            btnRegisterUpdate.Name = "btnRegisterUpdate";
            btnRegisterUpdate.Size = new Size(135, 53);
            btnRegisterUpdate.TabIndex = 62;
            btnRegisterUpdate.Text = "Register";
            btnRegisterUpdate.UseVisualStyleBackColor = false;
            btnRegisterUpdate.Click += btnRegisterUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(22, 30, 45);
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Symbol", 9F);
            btnClear.Location = new Point(543, 245);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 53);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonHighlight;
            txtName.Font = new Font("Segoe UI Symbol", 9F);
            txtName.Location = new Point(214, 95);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 34);
            txtName.TabIndex = 1;
            txtName.Tag = "Club Name";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ButtonHighlight;
            txtDescription.Font = new Font("Segoe UI Symbol", 9F);
            txtDescription.Location = new Point(214, 163);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(283, 76);
            txtDescription.TabIndex = 2;
            txtDescription.Tag = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 109);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 55;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 166);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 56;
            label3.Text = "Description:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Symbol", 9F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(543, 62);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 53);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmClub
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(827, 635);
            Controls.Add(cbxClubs);
            Controls.Add(label5);
            Controls.Add(pbxBack);
            Controls.Add(lblClubs);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmClub";
            StartPosition = FormStartPosition.Manual;
            Tag = "clubs";
            Text = "frmClub";
            Load += frmClubs_Load;
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxClubs;
        private Label label5;
        private PictureBox pbxBack;
        private Label lblClubs;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
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
        private TextBox txtName;
        private TextBox txtDescription;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private ErrorProvider errorProvider1;
    }
}