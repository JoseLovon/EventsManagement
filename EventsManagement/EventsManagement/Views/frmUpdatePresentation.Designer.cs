namespace EventsManagement
{
    partial class frmUpdatePresentation
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
            pbxBack = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            comboBox1 = new ComboBox();
            Artist = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            StartTime = new DataGridViewTextBoxColumn();
            EndTime = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pbxBack
            // 
            pbxBack.BackColor = Color.FromArgb(13, 91, 176);
            pbxBack.Cursor = Cursors.Hand;
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.ImeMode = ImeMode.NoControl;
            pbxBack.Location = new Point(24, 31);
            pbxBack.Name = "pbxBack";
            pbxBack.Size = new Size(60, 47);
            pbxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBack.TabIndex = 28;
            pbxBack.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(249, 253, 255);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(320, 40);
            label1.Name = "label1";
            label1.Size = new Size(195, 38);
            label1.TabIndex = 27;
            label1.Text = "Presentations";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.presentation_wallpaper;
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(-1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(802, 148);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Artist, Genre, StartTime, EndTime, btnEdit });
            dataGridView1.Location = new Point(115, 241);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(590, 195);
            dataGridView1.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(188, 188);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 53;
            label5.Text = "Search by Event:";
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Segoe UI Symbol", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(329, 180);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 28);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 55;
            comboBox1.Text = " -- Select an event --";
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
            Genre.HeaderText = "Artist";
            Genre.MinimumWidth = 6;
            Genre.Name = "Genre";
            Genre.ReadOnly = true;
            // 
            // StartTime
            // 
            StartTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StartTime.HeaderText = "From";
            StartTime.MinimumWidth = 6;
            StartTime.Name = "StartTime";
            StartTime.Width = 72;
            // 
            // EndTime
            // 
            EndTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            EndTime.HeaderText = "To";
            EndTime.MinimumWidth = 6;
            EndTime.Name = "EndTime";
            EndTime.Width = 54;
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "";
            btnEdit.Image = Properties.Resources.edit_iconn;
            btnEdit.MinimumWidth = 6;
            btnEdit.Name = "btnEdit";
            btnEdit.Width = 40;
            // 
            // frmUpdatePresentation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 468);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(pbxBack);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "frmUpdatePresentation";
            Text = "UpdatePresentation";
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxBack;
        private Label label1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Label label5;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn Artist;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn EndTime;
        private DataGridViewImageColumn btnEdit;
    }
}