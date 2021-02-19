namespace NX_GIC
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgvFolders = new System.Windows.Forms.DataGridView();
            this.Folder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQueue = new System.Windows.Forms.DataGridView();
            this.Output = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbRepo = new System.Windows.Forms.ComboBox();
            this.dgvIconList = new System.Windows.Forms.DataGridView();
            this.cmbSubfolders = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddResize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IconArt = new System.Windows.Forms.DataGridViewImageColumn();
            this.Game = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIconList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1824, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Enabled = false;
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repositoriesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(105, 34);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Visible = false;
            // 
            // repositoriesToolStripMenuItem
            // 
            this.repositoriesToolStripMenuItem.Name = "repositoriesToolStripMenuItem";
            this.repositoriesToolStripMenuItem.Size = new System.Drawing.Size(243, 40);
            this.repositoriesToolStripMenuItem.Text = "Repositories";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(74, 34);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(268, 40);
            this.aboutToolStripMenuItem.Text = "Guide (GitHub)";
            this.aboutToolStripMenuItem.Visible = false;
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(268, 40);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Location = new System.Drawing.Point(0, 1222);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1824, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgvFolders
            // 
            this.dgvFolders.AllowUserToAddRows = false;
            this.dgvFolders.AllowUserToDeleteRows = false;
            this.dgvFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFolders.BackgroundColor = System.Drawing.Color.White;
            this.dgvFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFolders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folder});
            this.dgvFolders.Location = new System.Drawing.Point(24, 202);
            this.dgvFolders.Margin = new System.Windows.Forms.Padding(6);
            this.dgvFolders.Name = "dgvFolders";
            this.dgvFolders.ReadOnly = true;
            this.dgvFolders.RowHeadersVisible = false;
            this.dgvFolders.RowHeadersWidth = 72;
            this.dgvFolders.Size = new System.Drawing.Size(440, 608);
            this.dgvFolders.TabIndex = 6;
            this.dgvFolders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFolders_CellDoubleClick);
            // 
            // Folder
            // 
            this.Folder.HeaderText = "Folder";
            this.Folder.MinimumWidth = 9;
            this.Folder.Name = "Folder";
            this.Folder.ReadOnly = true;
            this.Folder.Width = 175;
            // 
            // dgvQueue
            // 
            this.dgvQueue.AllowUserToAddRows = false;
            this.dgvQueue.AllowUserToDeleteRows = false;
            this.dgvQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQueue.BackgroundColor = System.Drawing.Color.White;
            this.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Output});
            this.dgvQueue.Location = new System.Drawing.Point(24, 829);
            this.dgvQueue.Margin = new System.Windows.Forms.Padding(6);
            this.dgvQueue.Name = "dgvQueue";
            this.dgvQueue.ReadOnly = true;
            this.dgvQueue.RowHeadersVisible = false;
            this.dgvQueue.RowHeadersWidth = 72;
            this.dgvQueue.Size = new System.Drawing.Size(440, 369);
            this.dgvQueue.TabIndex = 8;
            // 
            // Output
            // 
            this.Output.HeaderText = "Output";
            this.Output.MinimumWidth = 9;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Width = 112;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(24, 63);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(141, 42);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Scan";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbRepo
            // 
            this.cmbRepo.FormattingEnabled = true;
            this.cmbRepo.Location = new System.Drawing.Point(174, 114);
            this.cmbRepo.Margin = new System.Windows.Forms.Padding(6);
            this.cmbRepo.Name = "cmbRepo";
            this.cmbRepo.Size = new System.Drawing.Size(291, 32);
            this.cmbRepo.TabIndex = 4;
            this.cmbRepo.Text = "<Start Scan>";
            this.cmbRepo.SelectedIndexChanged += new System.EventHandler(this.cmbRepo_SelectedIndexChanged);
            // 
            // dgvIconList
            // 
            this.dgvIconList.AllowUserToDeleteRows = false;
            this.dgvIconList.AllowUserToResizeRows = false;
            this.dgvIconList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIconList.BackgroundColor = System.Drawing.Color.White;
            this.dgvIconList.ColumnHeadersHeight = 40;
            this.dgvIconList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IconArt,
            this.Game,
            this.TitleID,
            this.FilePath});
            this.dgvIconList.Location = new System.Drawing.Point(477, 63);
            this.dgvIconList.Margin = new System.Windows.Forms.Padding(6);
            this.dgvIconList.MultiSelect = false;
            this.dgvIconList.Name = "dgvIconList";
            this.dgvIconList.RowHeadersVisible = false;
            this.dgvIconList.RowHeadersWidth = 72;
            this.dgvIconList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIconList.Size = new System.Drawing.Size(1326, 1135);
            this.dgvIconList.TabIndex = 7;
            this.dgvIconList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cmbSubfolders
            // 
            this.cmbSubfolders.FormattingEnabled = true;
            this.cmbSubfolders.Location = new System.Drawing.Point(174, 157);
            this.cmbSubfolders.Margin = new System.Windows.Forms.Padding(6);
            this.cmbSubfolders.Name = "cmbSubfolders";
            this.cmbSubfolders.Size = new System.Drawing.Size(290, 32);
            this.cmbSubfolders.TabIndex = 5;
            this.cmbSubfolders.SelectedIndexChanged += new System.EventHandler(this.cmbSubfolders_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Transfer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddResize
            // 
            this.btnAddResize.Location = new System.Drawing.Point(174, 63);
            this.btnAddResize.Name = "btnAddResize";
            this.btnAddResize.Size = new System.Drawing.Size(146, 42);
            this.btnAddResize.TabIndex = 2;
            this.btnAddResize.Text = "Add New";
            this.btnAddResize.UseVisualStyleBackColor = true;
            this.btnAddResize.Click += new System.EventHandler(this.btnAddResize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Main Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sub Folder";
            // 
            // IconArt
            // 
            this.IconArt.HeaderText = "Icon Art";
            this.IconArt.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.IconArt.MinimumWidth = 9;
            this.IconArt.Name = "IconArt";
            this.IconArt.Width = 256;
            // 
            // Game
            // 
            this.Game.HeaderText = "Icon Name";
            this.Game.MinimumWidth = 9;
            this.Game.Name = "Game";
            this.Game.Width = 150;
            // 
            // TitleID
            // 
            this.TitleID.HeaderText = "Title ID";
            this.TitleID.MinimumWidth = 9;
            this.TitleID.Name = "TitleID";
            this.TitleID.Width = 150;
            // 
            // FilePath
            // 
            this.FilePath.HeaderText = "FilePath";
            this.FilePath.MinimumWidth = 9;
            this.FilePath.Name = "FilePath";
            this.FilePath.Visible = false;
            this.FilePath.Width = 175;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 1244);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddResize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSubfolders);
            this.Controls.Add(this.dgvIconList);
            this.Controls.Add(this.cmbRepo);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.dgvQueue);
            this.Controls.Add(this.dgvFolders);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "[NX-GIC] Nintendo Switch - Game Icon Customizer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIconList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgvFolders;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvQueue;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbRepo;
        private System.Windows.Forms.DataGridView dgvIconList;
        private System.Windows.Forms.ComboBox cmbSubfolders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddResize;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Output;
        private System.Windows.Forms.DataGridViewImageColumn IconArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Game;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
    }
}

