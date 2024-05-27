namespace FootballContractsHistory.Views
{
    partial class frmSearchContracts
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgvPresentations = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            From = new DataGridViewTextBoxColumn();
            To = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnUpdate = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            pbxBack = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPresentations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvPresentations
            // 
            dgvPresentations.BackgroundColor = Color.White;
            dgvPresentations.BorderStyle = BorderStyle.None;
            dgvPresentations.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvPresentations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresentations.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn1, From, To });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.BlanchedAlmond;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPresentations.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPresentations.GridColor = SystemColors.HighlightText;
            dgvPresentations.Location = new Point(112, 282);
            dgvPresentations.Name = "dgvPresentations";
            dgvPresentations.RowHeadersWidth = 51;
            dgvPresentations.Size = new Size(639, 163);
            dgvPresentations.TabIndex = 66;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumn2.HeaderText = "Event";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTextBoxColumn1.HeaderText = "Artist";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // From
            // 
            From.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            From.HeaderText = "From";
            From.MinimumWidth = 6;
            From.Name = "From";
            From.Width = 72;
            // 
            // To
            // 
            To.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            To.HeaderText = "To";
            To.MinimumWidth = 6;
            To.Name = "To";
            To.Width = 54;
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
            btnDelete.Location = new Point(469, 500);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 53);
            btnDelete.TabIndex = 65;
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
            btnUpdate.Location = new Point(298, 500);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 53);
            btnUpdate.TabIndex = 64;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Segoe UI Symbol", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(352, 207);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 28);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 63;
            comboBox1.Text = " -- Select a club --";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(210, 215);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 62;
            label5.Text = "Search by Club:";
            // 
            // pbxBack
            // 
            pbxBack.BackColor = Color.FromArgb(13, 91, 176);
            pbxBack.Cursor = Cursors.Hand;
            pbxBack.Image = Properties.Resources.back_button;
            pbxBack.ImeMode = ImeMode.NoControl;
            pbxBack.Location = new Point(25, 32);
            pbxBack.Name = "pbxBack";
            pbxBack.Size = new Size(60, 47);
            pbxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBack.TabIndex = 61;
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
            label1.Location = new Point(383, 41);
            label1.Name = "label1";
            label1.Size = new Size(141, 38);
            label1.TabIndex = 60;
            label1.Text = "Contracts";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(852, 148);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 635);
            Controls.Add(dgvPresentations);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(pbxBack);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSearch";
            Text = "frmSearch";
            ((System.ComponentModel.ISupportInitialize)dgvPresentations).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPresentations;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn From;
        private DataGridViewTextBoxColumn To;
        private Button btnDelete;
        private Button btnUpdate;
        private ComboBox comboBox1;
        private Label label5;
        private PictureBox pbxBack;
        private Label label1;
        private PictureBox pictureBox2;
    }
}