namespace EventsManagement
{
    partial class frmPresentations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresentations));
            label4 = new Label();
            btnClear = new Button();
            btnRegister = new Button();
            pbxBack = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            cbxGenres = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // btnClear
            // 
            resources.ApplyResources(btnClear, "btnClear");
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.Black;
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.Name = "btnClear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            resources.ApplyResources(btnRegister, "btnRegister");
            btnRegister.BackColor = Color.FromArgb(192, 0, 0);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.ForeColor = Color.White;
            btnRegister.Name = "btnRegister";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // pbxBack
            // 
            resources.ApplyResources(pbxBack, "pbxBack");
            pbxBack.BackColor = Color.FromArgb(13, 91, 176);
            pbxBack.Cursor = Cursors.Hand;
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.Name = "pbxBack";
            pbxBack.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.FromArgb(249, 253, 255);
            label1.FlatStyle = FlatStyle.System;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Name = "label1";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Image = Properties.Resources.presentation_wallpaper;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // cbxGenres
            // 
            resources.ApplyResources(cbxGenres, "cbxGenres");
            cbxGenres.Cursor = Cursors.Hand;
            cbxGenres.FormattingEnabled = true;
            cbxGenres.Name = "cbxGenres";
            cbxGenres.Sorted = true;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // comboBox1
            // 
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FormattingEnabled = true;
            comboBox1.Name = "comboBox1";
            comboBox1.Sorted = true;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // comboBox2
            // 
            resources.ApplyResources(comboBox2, "comboBox2");
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { resources.GetString("comboBox2.Items"), resources.GetString("comboBox2.Items1"), resources.GetString("comboBox2.Items2"), resources.GetString("comboBox2.Items3"), resources.GetString("comboBox2.Items4"), resources.GetString("comboBox2.Items5"), resources.GetString("comboBox2.Items6"), resources.GetString("comboBox2.Items7"), resources.GetString("comboBox2.Items8"), resources.GetString("comboBox2.Items9") });
            comboBox2.Name = "comboBox2";
            // 
            // comboBox3
            // 
            resources.ApplyResources(comboBox3, "comboBox3");
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { resources.GetString("comboBox3.Items"), resources.GetString("comboBox3.Items1"), resources.GetString("comboBox3.Items2"), resources.GetString("comboBox3.Items3"), resources.GetString("comboBox3.Items4"), resources.GetString("comboBox3.Items5"), resources.GetString("comboBox3.Items6"), resources.GetString("comboBox3.Items7"), resources.GetString("comboBox3.Items8"), resources.GetString("comboBox3.Items9") });
            comboBox3.Name = "comboBox3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // frmPresentations
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(comboBox3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(cbxGenres);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(pbxBack);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPresentations";
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Button btnClear;
        private Button btnRegister;
        private PictureBox pbxBack;
        private Label label1;
        private PictureBox pictureBox2;
        private ComboBox cbxGenres;
        private Label label3;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label2;
    }
}