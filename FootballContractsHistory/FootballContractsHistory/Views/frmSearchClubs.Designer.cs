namespace FootballContractsHistory
{
    partial class frmSearchClubs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchClubs));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            errorProvider1 = new ErrorProvider(components);
            pbxBack = new PictureBox();
            lblPlayers = new Label();
            pictureBox2 = new PictureBox();
            txtName = new TextBox();
            dgvClubs = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClubs).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pbxBack
            // 
            pbxBack.BackColor = Color.FromArgb(99, 83, 56);
            pbxBack.Cursor = Cursors.Hand;
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.ImeMode = ImeMode.NoControl;
            pbxBack.Location = new Point(45, 61);
            pbxBack.Name = "pbxBack";
            pbxBack.Size = new Size(60, 47);
            pbxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBack.TabIndex = 63;
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
            lblPlayers.Location = new Point(388, 70);
            lblPlayers.Name = "lblPlayers";
            lblPlayers.Size = new Size(88, 38);
            lblPlayers.TabIndex = 62;
            lblPlayers.Text = "Clubs";
            lblPlayers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(854, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 61;
            pictureBox2.TabStop = false;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonHighlight;
            txtName.Font = new Font("Segoe UI Symbol", 9F);
            txtName.Location = new Point(388, 243);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 31);
            txtName.TabIndex = 1;
            txtName.Tag = "Name";
            txtName.KeyPress += txtName_KeyPress;
            // 
            // dgvClubs
            // 
            dgvClubs.BackgroundColor = Color.White;
            dgvClubs.BorderStyle = BorderStyle.None;
            dgvClubs.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvClubs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.BlanchedAlmond;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClubs.DefaultCellStyle = dataGridViewCellStyle1;
            dgvClubs.GridColor = SystemColors.HighlightText;
            dgvClubs.Location = new Point(123, 332);
            dgvClubs.Name = "dgvClubs";
            dgvClubs.RowHeadersWidth = 51;
            dgvClubs.Size = new Size(639, 163);
            dgvClubs.TabIndex = 59;
            dgvClubs.CellClick += dgvClubs_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(186, 254);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 58;
            label5.Text = "Search by Name:";
            // 
            // frmSearchClubs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 635);
            Controls.Add(pbxBack);
            Controls.Add(lblPlayers);
            Controls.Add(pictureBox2);
            Controls.Add(txtName);
            Controls.Add(dgvClubs);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSearchClubs";
            Text = "SearchEvent";
            Load += frmSearchClubs_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClubs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProvider1;
        private PictureBox pbxBack;
        private Label lblPlayers;
        private PictureBox pictureBox2;
        private TextBox txtName;
        private DataGridView dgvClubs;
        private Label label5;
    }
}