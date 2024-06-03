namespace FootballContractsHistory
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            maintenanceToolStripMenuItem = new ToolStripMenuItem();
            clubsToolStripMenuItem = new ToolStripMenuItem();
            registerUpdateDeleteToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            playersToolStripMenuItem = new ToolStripMenuItem();
            contractsToolStripMenuItem = new ToolStripMenuItem();
            registerUpdateDeleteToolStripMenuItem1 = new ToolStripMenuItem();
            searchToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 680);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 19, 0);
            statusStrip.Size = new Size(844, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(49, 20);
            toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, maintenanceToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(844, 30);
            menuStrip.TabIndex = 4;
            menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileMenu.ImageTransparentColor = SystemColors.ActiveBorder;
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(46, 24);
            fileMenu.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // maintenanceToolStripMenuItem
            // 
            maintenanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clubsToolStripMenuItem, playersToolStripMenuItem, contractsToolStripMenuItem });
            maintenanceToolStripMenuItem.Image = Properties.Resources.ic_maintenance;
            maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            maintenanceToolStripMenuItem.Size = new Size(128, 24);
            maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // clubsToolStripMenuItem
            // 
            clubsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerUpdateDeleteToolStripMenuItem, searchToolStripMenuItem });
            clubsToolStripMenuItem.Name = "clubsToolStripMenuItem";
            clubsToolStripMenuItem.Size = new Size(154, 26);
            clubsToolStripMenuItem.Tag = "";
            clubsToolStripMenuItem.Text = "Clubs";
            // 
            // registerUpdateDeleteToolStripMenuItem
            // 
            registerUpdateDeleteToolStripMenuItem.Name = "registerUpdateDeleteToolStripMenuItem";
            registerUpdateDeleteToolStripMenuItem.Size = new Size(253, 26);
            registerUpdateDeleteToolStripMenuItem.Tag = "clubs";
            registerUpdateDeleteToolStripMenuItem.Text = "Register, Update, Delete";
            registerUpdateDeleteToolStripMenuItem.Click += ShowNewForm;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(253, 26);
            searchToolStripMenuItem.Tag = "searchClub";
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += ShowNewForm;
            // 
            // playersToolStripMenuItem
            // 
            playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            playersToolStripMenuItem.Size = new Size(154, 26);
            playersToolStripMenuItem.Tag = "players";
            playersToolStripMenuItem.Text = "Players";
            playersToolStripMenuItem.Click += ShowNewForm;
            // 
            // contractsToolStripMenuItem
            // 
            contractsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerUpdateDeleteToolStripMenuItem1, searchToolStripMenuItem1 });
            contractsToolStripMenuItem.Name = "contractsToolStripMenuItem";
            contractsToolStripMenuItem.Size = new Size(154, 26);
            contractsToolStripMenuItem.Tag = "";
            contractsToolStripMenuItem.Text = "Contracts";
            // 
            // registerUpdateDeleteToolStripMenuItem1
            // 
            registerUpdateDeleteToolStripMenuItem1.Name = "registerUpdateDeleteToolStripMenuItem1";
            registerUpdateDeleteToolStripMenuItem1.Size = new Size(253, 26);
            registerUpdateDeleteToolStripMenuItem1.Tag = "contracts";
            registerUpdateDeleteToolStripMenuItem1.Text = "Register, Update, Delete";
            registerUpdateDeleteToolStripMenuItem1.Click += ShowNewForm;
            // 
            // searchToolStripMenuItem1
            // 
            searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            searchToolStripMenuItem1.Size = new Size(253, 26);
            searchToolStripMenuItem1.Tag = "searchContracts";
            searchToolStripMenuItem1.Text = "Search";
            searchToolStripMenuItem1.Click += ShowNewForm;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Image = Properties.Resources.ic_about;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(84, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // frmMDI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(844, 706);
            Controls.Add(menuStrip);
            Controls.Add(statusStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMDI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Football Contracts History";
            FormClosed += frmMDI_FormClosed;
            Load += frmMDI_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem maintenanceToolStripMenuItem;
        private ToolStripMenuItem clubsToolStripMenuItem;
        private ToolStripMenuItem playersToolStripMenuItem;
        private ToolStripMenuItem contractsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem registerUpdateDeleteToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem registerUpdateDeleteToolStripMenuItem1;
        private ToolStripMenuItem searchToolStripMenuItem1;
    }
}



