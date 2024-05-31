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
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            pbxSearch = new PictureBox();
            btnClear = new Button();
            cbxPlayers = new ComboBox();
            cbxClubs = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            btnRegister = new Button();
            label4 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbxBack
            // 
            resources.ApplyResources(pbxBack, "pbxBack");
            pbxBack.BackColor = Color.FromArgb(99, 83, 56);
            pbxBack.Cursor = Cursors.Hand;
            errorProvider1.SetError(pbxBack, resources.GetString("pbxBack.Error"));
            errorProvider1.SetIconAlignment(pbxBack, (ErrorIconAlignment)resources.GetObject("pbxBack.IconAlignment"));
            errorProvider1.SetIconPadding(pbxBack, (int)resources.GetObject("pbxBack.IconPadding"));
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.Name = "pbxBack";
            pbxBack.TabStop = false;
            pbxBack.Click += pbxBack_Click;
            // 
            // lblPlayers
            // 
            resources.ApplyResources(lblPlayers, "lblPlayers");
            lblPlayers.BackColor = Color.FromArgb(73, 72, 61);
            errorProvider1.SetError(lblPlayers, resources.GetString("lblPlayers.Error"));
            lblPlayers.FlatStyle = FlatStyle.System;
            lblPlayers.ForeColor = Color.White;
            errorProvider1.SetIconAlignment(lblPlayers, (ErrorIconAlignment)resources.GetObject("lblPlayers.IconAlignment"));
            errorProvider1.SetIconPadding(lblPlayers, (int)resources.GetObject("lblPlayers.IconPadding"));
            lblPlayers.Name = "lblPlayers";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            errorProvider1.SetError(pictureBox2, resources.GetString("pictureBox2.Error"));
            errorProvider1.SetIconAlignment(pictureBox2, (ErrorIconAlignment)resources.GetObject("pictureBox2.IconAlignment"));
            errorProvider1.SetIconPadding(pictureBox2, (int)resources.GetObject("pictureBox2.IconPadding"));
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(dtpEndDate);
            groupBox1.Controls.Add(dtpStartDate);
            groupBox1.Controls.Add(pbxSearch);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(cbxPlayers);
            groupBox1.Controls.Add(cbxClubs);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            errorProvider1.SetError(groupBox1, resources.GetString("groupBox1.Error"));
            errorProvider1.SetIconAlignment(groupBox1, (ErrorIconAlignment)resources.GetObject("groupBox1.IconAlignment"));
            errorProvider1.SetIconPadding(groupBox1, (int)resources.GetObject("groupBox1.IconPadding"));
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // dtpEndDate
            // 
            resources.ApplyResources(dtpEndDate, "dtpEndDate");
            errorProvider1.SetError(dtpEndDate, resources.GetString("dtpEndDate.Error"));
            errorProvider1.SetIconAlignment(dtpEndDate, (ErrorIconAlignment)resources.GetObject("dtpEndDate.IconAlignment"));
            errorProvider1.SetIconPadding(dtpEndDate, (int)resources.GetObject("dtpEndDate.IconPadding"));
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Value = new DateTime(2024, 5, 30, 0, 0, 0, 0);
            dtpEndDate.Validating += cbx_Validating;
            // 
            // dtpStartDate
            // 
            resources.ApplyResources(dtpStartDate, "dtpStartDate");
            errorProvider1.SetError(dtpStartDate, resources.GetString("dtpStartDate.Error"));
            errorProvider1.SetIconAlignment(dtpStartDate, (ErrorIconAlignment)resources.GetObject("dtpStartDate.IconAlignment"));
            errorProvider1.SetIconPadding(dtpStartDate, (int)resources.GetObject("dtpStartDate.IconPadding"));
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Value = new DateTime(2024, 5, 30, 0, 0, 0, 0);
            dtpStartDate.Validating += cbx_Validating;
            // 
            // pbxSearch
            // 
            resources.ApplyResources(pbxSearch, "pbxSearch");
            pbxSearch.BackColor = Color.White;
            pbxSearch.Cursor = Cursors.Hand;
            errorProvider1.SetError(pbxSearch, resources.GetString("pbxSearch.Error"));
            errorProvider1.SetIconAlignment(pbxSearch, (ErrorIconAlignment)resources.GetObject("pbxSearch.IconAlignment"));
            errorProvider1.SetIconPadding(pbxSearch, (int)resources.GetObject("pbxSearch.IconPadding"));
            pbxSearch.Name = "pbxSearch";
            pbxSearch.TabStop = false;
            pbxSearch.Click += pbxSearch_Click;
            // 
            // btnClear
            // 
            resources.ApplyResources(btnClear, "btnClear");
            btnClear.Cursor = Cursors.Hand;
            errorProvider1.SetError(btnClear, resources.GetString("btnClear.Error"));
            btnClear.FlatAppearance.BorderColor = Color.Black;
            btnClear.FlatAppearance.BorderSize = 2;
            errorProvider1.SetIconAlignment(btnClear, (ErrorIconAlignment)resources.GetObject("btnClear.IconAlignment"));
            errorProvider1.SetIconPadding(btnClear, (int)resources.GetObject("btnClear.IconPadding"));
            btnClear.Name = "btnClear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cbxPlayers
            // 
            resources.ApplyResources(cbxPlayers, "cbxPlayers");
            cbxPlayers.Cursor = Cursors.Hand;
            errorProvider1.SetError(cbxPlayers, resources.GetString("cbxPlayers.Error"));
            cbxPlayers.FormattingEnabled = true;
            errorProvider1.SetIconAlignment(cbxPlayers, (ErrorIconAlignment)resources.GetObject("cbxPlayers.IconAlignment"));
            errorProvider1.SetIconPadding(cbxPlayers, (int)resources.GetObject("cbxPlayers.IconPadding"));
            cbxPlayers.Name = "cbxPlayers";
            cbxPlayers.Sorted = true;
            cbxPlayers.Validating += cbx_Validating;
            // 
            // cbxClubs
            // 
            resources.ApplyResources(cbxClubs, "cbxClubs");
            cbxClubs.Cursor = Cursors.Hand;
            errorProvider1.SetError(cbxClubs, resources.GetString("cbxClubs.Error"));
            cbxClubs.FormattingEnabled = true;
            errorProvider1.SetIconAlignment(cbxClubs, (ErrorIconAlignment)resources.GetObject("cbxClubs.IconAlignment"));
            errorProvider1.SetIconPadding(cbxClubs, (int)resources.GetObject("cbxClubs.IconPadding"));
            cbxClubs.Name = "cbxClubs";
            cbxClubs.Sorted = true;
            cbxClubs.Validating += cbx_Validating;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            errorProvider1.SetError(label2, resources.GetString("label2.Error"));
            errorProvider1.SetIconAlignment(label2, (ErrorIconAlignment)resources.GetObject("label2.IconAlignment"));
            errorProvider1.SetIconPadding(label2, (int)resources.GetObject("label2.IconPadding"));
            label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            errorProvider1.SetError(label5, resources.GetString("label5.Error"));
            errorProvider1.SetIconAlignment(label5, (ErrorIconAlignment)resources.GetObject("label5.IconAlignment"));
            errorProvider1.SetIconPadding(label5, (int)resources.GetObject("label5.IconPadding"));
            label5.Name = "label5";
            // 
            // btnRegister
            // 
            resources.ApplyResources(btnRegister, "btnRegister");
            btnRegister.BackColor = Color.FromArgb(192, 0, 0);
            btnRegister.Cursor = Cursors.Hand;
            errorProvider1.SetError(btnRegister, resources.GetString("btnRegister.Error"));
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.ForeColor = Color.White;
            errorProvider1.SetIconAlignment(btnRegister, (ErrorIconAlignment)resources.GetObject("btnRegister.IconAlignment"));
            errorProvider1.SetIconPadding(btnRegister, (int)resources.GetObject("btnRegister.IconPadding"));
            btnRegister.Name = "btnRegister";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegisterUpdate_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            errorProvider1.SetError(label4, resources.GetString("label4.Error"));
            errorProvider1.SetIconAlignment(label4, (ErrorIconAlignment)resources.GetObject("label4.IconAlignment"));
            errorProvider1.SetIconPadding(label4, (int)resources.GetObject("label4.IconPadding"));
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            errorProvider1.SetError(label3, resources.GetString("label3.Error"));
            errorProvider1.SetIconAlignment(label3, (ErrorIconAlignment)resources.GetObject("label3.IconAlignment"));
            errorProvider1.SetIconPadding(label3, (int)resources.GetObject("label3.IconPadding"));
            label3.Name = "label3";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            resources.ApplyResources(errorProvider1, "errorProvider1");
            // 
            // frmContracts
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(pbxBack);
            Controls.Add(lblPlayers);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmContracts";
            Load += frmContracts_Load;
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbxBack;
        private Label lblPlayers;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private PictureBox pbxSearch;
        private Button btnClear;
        private ComboBox cbxPlayers;
        private ComboBox cbxClubs;
        private Label label2;
        private Label label5;
        private Button btnRegister;
        private Label label4;
        private Label label3;
        private ErrorProvider errorProvider1;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
    }
}