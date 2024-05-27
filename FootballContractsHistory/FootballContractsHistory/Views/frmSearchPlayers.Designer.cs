namespace FootballContractsHistory
{
    partial class frmSearchPlayers
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchPlayers));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgvBands = new DataGridView();
            label5 = new Label();
            txtName = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            pbxBack = new PictureBox();
            lblPlayers = new Label();
            pictureBox2 = new PictureBox();
            Artist = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBands).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvBands
            // 
            dgvBands.BackgroundColor = Color.White;
            dgvBands.BorderStyle = BorderStyle.None;
            dgvBands.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvBands.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBands.Columns.AddRange(new DataGridViewColumn[] { Artist, Genre });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.BlanchedAlmond;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvBands.DefaultCellStyle = dataGridViewCellStyle6;
            dgvBands.GridColor = SystemColors.HighlightText;
            dgvBands.Location = new Point(122, 319);
            dgvBands.Name = "dgvBands";
            dgvBands.RowHeadersWidth = 51;
            dgvBands.Size = new Size(639, 163);
            dgvBands.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(206, 241);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 38;
            label5.Text = "Search by Name:";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonHighlight;
            txtName.Font = new Font("Segoe UI Symbol", 9F);
            txtName.Location = new Point(369, 230);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 31);
            txtName.TabIndex = 52;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(0, 192, 192);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.Black;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Symbol", 9F);
            btnDelete.ForeColor = Color.White;
            btnDelete.ImeMode = ImeMode.NoControl;
            btnDelete.Location = new Point(468, 511);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 53);
            btnDelete.TabIndex = 54;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 0, 0);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Symbol", 9F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.ImeMode = ImeMode.NoControl;
            btnUpdate.Location = new Point(294, 511);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 53);
            btnUpdate.TabIndex = 53;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // pbxBack
            // 
            pbxBack.BackColor = Color.FromArgb(99, 83, 56);
            pbxBack.Cursor = Cursors.Hand;
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.ImeMode = ImeMode.NoControl;
            pbxBack.Location = new Point(14, 38);
            pbxBack.Name = "pbxBack";
            pbxBack.Size = new Size(60, 47);
            pbxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBack.TabIndex = 57;
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
            lblPlayers.Location = new Point(387, 47);
            lblPlayers.Name = "lblPlayers";
            lblPlayers.Size = new Size(110, 38);
            lblPlayers.TabIndex = 56;
            lblPlayers.Text = "Players";
            lblPlayers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(-1, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(859, 173);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            // 
            // Artist
            // 
            Artist.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            Artist.DefaultCellStyle = dataGridViewCellStyle4;
            Artist.HeaderText = "Player";
            Artist.MinimumWidth = 6;
            Artist.Name = "Artist";
            Artist.ReadOnly = true;
            // 
            // Genre
            // 
            Genre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Genre.DefaultCellStyle = dataGridViewCellStyle5;
            Genre.HeaderText = "Position";
            Genre.MinimumWidth = 6;
            Genre.Name = "Genre";
            Genre.ReadOnly = true;
            // 
            // frmSearchBand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 635);
            Controls.Add(pbxBack);
            Controls.Add(lblPlayers);
            Controls.Add(pictureBox2);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtName);
            Controls.Add(dgvBands);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSearchBand";
            Text = "Searchband";
            ((System.ComponentModel.ISupportInitialize)dgvBands).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvBands;
        private Label label5;
        private TextBox txtName;
        private Button btnDelete;
        private Button btnUpdate;
        private PictureBox pbxBack;
        private Label lblPlayers;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn Artist;
        private DataGridViewTextBoxColumn Genre;
    }
}