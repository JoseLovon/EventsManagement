namespace FootballContractsHistory
{
    partial class frmClubs
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClubs));
            errorProvider1 = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            pbxSearch = new PictureBox();
            btnClear = new Button();
            txtName = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnRegister = new Button();
            pbxBack = new PictureBox();
            lblClubs = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbxSearch);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Location = new Point(155, 220);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 362);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            // 
            // pbxSearch
            // 
            pbxSearch.BackColor = Color.White;
            pbxSearch.Cursor = Cursors.Hand;
            pbxSearch.Image = (Image)resources.GetObject("pbxSearch.Image");
            pbxSearch.ImeMode = ImeMode.NoControl;
            pbxSearch.Location = new Point(475, 44);
            pbxSearch.Name = "pbxSearch";
            pbxSearch.Size = new Size(36, 34);
            pbxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxSearch.TabIndex = 61;
            pbxSearch.TabStop = false;
            pbxSearch.Click += pbxSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(22, 30, 45);
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Symbol", 9F);
            btnClear.Location = new Point(291, 293);
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
            txtName.Location = new Point(143, 44);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 34);
            txtName.TabIndex = 1;
            txtName.Tag = "Club Name";
            txtName.Validating += txt_Validating;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ButtonHighlight;
            txtDescription.Font = new Font("Segoe UI Symbol", 9F);
            txtDescription.Location = new Point(150, 144);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(276, 93);
            txtDescription.TabIndex = 2;
            txtDescription.Tag = "Description";
            txtDescription.Validating += txt_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 58);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 55;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 147);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 56;
            label3.Text = "Description:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(192, 0, 0);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Symbol", 9F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(150, 293);
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
            pbxBack.Location = new Point(47, 57);
            pbxBack.Name = "pbxBack";
            pbxBack.Size = new Size(60, 47);
            pbxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBack.TabIndex = 57;
            pbxBack.TabStop = false;
            // 
            // lblClubs
            // 
            lblClubs.AutoSize = true;
            lblClubs.BackColor = Color.FromArgb(73, 72, 61);
            lblClubs.FlatStyle = FlatStyle.System;
            lblClubs.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblClubs.ForeColor = Color.White;
            lblClubs.ImeMode = ImeMode.NoControl;
            lblClubs.Location = new Point(383, 66);
            lblClubs.Name = "lblClubs";
            lblClubs.Size = new Size(88, 38);
            lblClubs.TabIndex = 56;
            lblClubs.Text = "Clubs";
            lblClubs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(-3, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(865, 173);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            // 
            // frmClubs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(858, 635);
            Controls.Add(pbxBack);
            Controls.Add(lblClubs);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Symbol", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClubs";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Event";
            Load += frmClubs_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProvider1;
        private GroupBox groupBox1;
        private PictureBox pbxSearch;
        private Button btnClear;
        private TextBox txtName;
        private TextBox txtDescription;
        private Label label2;
        private Label label3;
        private Button btnRegister;
        private PictureBox pbxBack;
        private Label lblClubs;
        private PictureBox pictureBox2;
    }
}
