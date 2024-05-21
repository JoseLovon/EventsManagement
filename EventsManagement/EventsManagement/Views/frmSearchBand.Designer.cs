namespace EventsManagement
{
    partial class frmSearchBand
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchBand));
            dataGridView1 = new DataGridView();
            pbxBack = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            Artist = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewImageColumn();
            btnDelete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Artist, Genre, btnEdit, btnDelete });
            dataGridView1.Location = new Point(122, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(590, 195);
            dataGridView1.TabIndex = 40;
            // 
            // pbxBack
            // 
            pbxBack.BackColor = Color.FromArgb(151, 20, 9);
            pbxBack.Cursor = Cursors.Hand;
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.ImeMode = ImeMode.NoControl;
            pbxBack.Location = new Point(14, 29);
            pbxBack.Name = "pbxBack";
            pbxBack.Size = new Size(60, 47);
            pbxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBack.TabIndex = 46;
            pbxBack.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.band_wallpaper;
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(-1, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(807, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(195, 157);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 38;
            label5.Text = "Search by Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(225, 199, 129);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(375, 29);
            label1.Name = "label1";
            label1.Size = new Size(96, 38);
            label1.TabIndex = 45;
            label1.Text = "Bands";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonHighlight;
            txtName.Font = new Font("Segoe UI Symbol", 9F);
            txtName.Location = new Point(358, 146);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 31);
            txtName.TabIndex = 52;
            // 
            // Artist
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Artist.DefaultCellStyle = dataGridViewCellStyle5;
            Artist.HeaderText = "Artist";
            Artist.MinimumWidth = 6;
            Artist.Name = "Artist";
            Artist.ReadOnly = true;
            Artist.Width = 166;
            // 
            // Genre
            // 
            Genre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Genre.DefaultCellStyle = dataGridViewCellStyle6;
            Genre.HeaderText = "Genre";
            Genre.MinimumWidth = 6;
            Genre.Name = "Genre";
            Genre.ReadOnly = true;
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "";
            btnEdit.Image = Properties.Resources.edit_iconn;
            btnEdit.MinimumWidth = 6;
            btnEdit.Name = "btnEdit";
            btnEdit.Width = 40;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "";
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.MinimumWidth = 6;
            btnDelete.Name = "btnDelete";
            btnDelete.Width = 40;
            // 
            // frmSearchBand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(pbxBack);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSearchBand";
            Text = "Searchband";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private PictureBox pbxBack;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label1;
        private TextBox txtName;
        private DataGridViewTextBoxColumn Artist;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewImageColumn btnEdit;
        private DataGridViewImageColumn btnDelete;
    }
}