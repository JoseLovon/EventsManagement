namespace EventsManagement
{
    partial class frmSearchEvent
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchEvent));
            txtName = new TextBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            pbxBack = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            Artist = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            EventDate = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewImageColumn();
            btnDelete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonHighlight;
            txtName.Font = new Font("Segoe UI Symbol", 9F);
            txtName.Location = new Point(354, 159);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 31);
            txtName.TabIndex = 58;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Artist, Genre, EventDate, btnEdit, btnDelete });
            dataGridView1.Location = new Point(25, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(748, 195);
            dataGridView1.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(191, 170);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 53;
            label5.Text = "Search by Name:";
            // 
            // pbxBack
            // 
            pbxBack.BackColor = Color.FromArgb(241, 237, 235);
            pbxBack.Cursor = Cursors.Hand;
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.Location = new Point(25, 28);
            pbxBack.Name = "pbxBack";
            pbxBack.Size = new Size(60, 47);
            pbxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBack.TabIndex = 61;
            pbxBack.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(249, 249, 249);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(354, 37);
            label1.Name = "label1";
            label1.Size = new Size(102, 38);
            label1.TabIndex = 60;
            label1.Text = "Events";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.event_wallpaper;
            pictureBox2.Location = new Point(-1, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(802, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            // 
            // Artist
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Artist.DefaultCellStyle = dataGridViewCellStyle1;
            Artist.HeaderText = "Event";
            Artist.MinimumWidth = 6;
            Artist.Name = "Artist";
            Artist.ReadOnly = true;
            Artist.Width = 166;
            // 
            // Genre
            // 
            Genre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Genre.DefaultCellStyle = dataGridViewCellStyle2;
            Genre.HeaderText = "Description";
            Genre.MinimumWidth = 6;
            Genre.Name = "Genre";
            Genre.ReadOnly = true;
            // 
            // EventDate
            // 
            EventDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EventDate.HeaderText = "Date";
            EventDate.MinimumWidth = 6;
            EventDate.Name = "EventDate";
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
            // frmSearchEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pbxBack);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSearchEvent";
            Text = "SearchEvent";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private DataGridView dataGridView1;
        private Label label5;
        private PictureBox pbxBack;
        private Label label1;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn Artist;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn EventDate;
        private DataGridViewImageColumn btnEdit;
        private DataGridViewImageColumn btnDelete;
    }
}