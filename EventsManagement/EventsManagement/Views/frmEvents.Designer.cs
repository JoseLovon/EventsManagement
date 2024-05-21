namespace EventsManagement
{
    partial class frmEvents
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClear = new Button();
            btnRegister = new Button();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pbxBack = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            txtDescription = new TextBox();
            label4 = new Label();
            dprEventDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(22, 30, 45);
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Symbol", 9F);
            btnClear.Location = new Point(425, 492);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 53);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(192, 0, 0);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Symbol", 9F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(258, 492);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(135, 53);
            btnRegister.TabIndex = 18;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonHighlight;
            txtName.Font = new Font("Segoe UI Symbol", 9F);
            txtName.Location = new Point(320, 196);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 34);
            txtName.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 274);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 15;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 210);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 14;
            label2.Text = "Name:";
            // 
            // pbxBack
            // 
            pbxBack.BackColor = Color.FromArgb(224, 185, 124);
            pbxBack.Cursor = Cursors.Hand;
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.Location = new Point(13, 35);
            pbxBack.Name = "pbxBack";
            pbxBack.Size = new Size(60, 47);
            pbxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBack.TabIndex = 13;
            pbxBack.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(249, 249, 249);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(351, 35);
            label1.Name = "label1";
            label1.Size = new Size(102, 38);
            label1.TabIndex = 12;
            label1.Text = "Events";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.event_wallpaper;
            pictureBox2.Location = new Point(-1, -4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(802, 166);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ButtonHighlight;
            txtDescription.Font = new Font("Segoe UI Symbol", 9F);
            txtDescription.Location = new Point(320, 274);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(283, 93);
            txtDescription.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 407);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 21;
            label4.Text = "Date:";
            // 
            // dprEventDate
            // 
            dprEventDate.Cursor = Cursors.Hand;
            dprEventDate.Location = new Point(320, 400);
            dprEventDate.MinDate = new DateTime(2024, 5, 20, 0, 0, 0, 0);
            dprEventDate.Name = "dprEventDate";
            dprEventDate.Size = new Size(283, 27);
            dprEventDate.TabIndex = 22;
            dprEventDate.Value = new DateTime(2024, 5, 20, 0, 0, 0, 0);
            // 
            // frmEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 591);
            Controls.Add(dprEventDate);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pbxBack);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Font = new Font("Segoe UI Symbol", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEvents";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Event";
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnRegister;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private PictureBox pbxBack;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txtDescription;
        private Label label4;
        private DateTimePicker dprEventDate;
    }
}
