﻿namespace NX_GIC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goOfflineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showIconsForInstalledGamesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInstalledGamesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.downloadTitlesCSVFTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installNXTitlesListDumperNROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.dgvFolders = new System.Windows.Forms.DataGridView();
            this.Folder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQueue = new System.Windows.Forms.DataGridView();
            this.Output = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewImageColumn();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbRepo = new System.Windows.Forms.ComboBox();
            this.cmbSubfolders = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddResize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flowIcons = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmsTitleID = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdCsv = new System.Windows.Forms.OpenFileDialog();
            this.dgvInstalled = new System.Windows.Forms.DataGridView();
            this.btnAutoGic = new System.Windows.Forms.Button();
            this.btnAddtoOut = new System.Windows.Forms.Button();
            this.btnReloadCSV = new System.Windows.Forms.Button();
            this.cmbAutoStyle = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
            this.flowIcons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsTitleID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstalled)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1494, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.goOfflineToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(400, 34);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // goOfflineToolStripMenuItem
            // 
            this.goOfflineToolStripMenuItem.Checked = global::NX_GIC.Properties.Settings.Default.OfflineStatus;
            this.goOfflineToolStripMenuItem.Name = "goOfflineToolStripMenuItem";
            this.goOfflineToolStripMenuItem.Size = new System.Drawing.Size(400, 34);
            this.goOfflineToolStripMenuItem.Text = "Skip Icon Repo Check (Work Offline)";
            this.goOfflineToolStripMenuItem.Click += new System.EventHandler(this.goOfflineToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(397, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(400, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showIconsForInstalledGamesOnlyToolStripMenuItem,
            this.viewInstalledGamesListToolStripMenuItem,
            this.toolStripSeparator3,
            this.downloadTitlesCSVFTPToolStripMenuItem,
            this.installNXTitlesListDumperNROToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.viewToolStripMenuItem.Text = "Title IDs";
            // 
            // showIconsForInstalledGamesOnlyToolStripMenuItem
            // 
            this.showIconsForInstalledGamesOnlyToolStripMenuItem.Name = "showIconsForInstalledGamesOnlyToolStripMenuItem";
            this.showIconsForInstalledGamesOnlyToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.showIconsForInstalledGamesOnlyToolStripMenuItem.Text = "Show Icons for Installed Games only";
            this.showIconsForInstalledGamesOnlyToolStripMenuItem.Click += new System.EventHandler(this.showIconsForInstalledGamesOnlyToolStripMenuItem_Click);
            // 
            // viewInstalledGamesListToolStripMenuItem
            // 
            this.viewInstalledGamesListToolStripMenuItem.Name = "viewInstalledGamesListToolStripMenuItem";
            this.viewInstalledGamesListToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.viewInstalledGamesListToolStripMenuItem.Text = "Show List of Installed Games (CSV)";
            this.viewInstalledGamesListToolStripMenuItem.Click += new System.EventHandler(this.viewInstalledGamesListToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(399, 6);
            // 
            // downloadTitlesCSVFTPToolStripMenuItem
            // 
            this.downloadTitlesCSVFTPToolStripMenuItem.Name = "downloadTitlesCSVFTPToolStripMenuItem";
            this.downloadTitlesCSVFTPToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.downloadTitlesCSVFTPToolStripMenuItem.Text = "Refresh Titles.CSV (FTP)";
            this.downloadTitlesCSVFTPToolStripMenuItem.Click += new System.EventHandler(this.downloadTitlesCSVFTPToolStripMenuItem_Click);
            // 
            // installNXTitlesListDumperNROToolStripMenuItem
            // 
            this.installNXTitlesListDumperNROToolStripMenuItem.Name = "installNXTitlesListDumperNROToolStripMenuItem";
            this.installNXTitlesListDumperNROToolStripMenuItem.Size = new System.Drawing.Size(402, 34);
            this.installNXTitlesListDumperNROToolStripMenuItem.Text = "Install NX Titles List Dumper (NRO)";
            this.installNXTitlesListDumperNROToolStripMenuItem.Click += new System.EventHandler(this.installNXTitlesListDumperNROToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.tutorialToolStripMenuItem.Text = "Tutorial";
            this.tutorialToolStripMenuItem.Click += new System.EventHandler(this.tutorialToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.aboutToolStripMenuItem.Text = "Wiki";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(173, 34);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 948);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1494, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 23);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(393, 22);
            // 
            // dgvFolders
            // 
            this.dgvFolders.AllowUserToAddRows = false;
            this.dgvFolders.AllowUserToDeleteRows = false;
            this.dgvFolders.AllowUserToResizeRows = false;
            this.dgvFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFolders.BackgroundColor = System.Drawing.Color.White;
            this.dgvFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFolders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folder});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFolders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFolders.Location = new System.Drawing.Point(21, 165);
            this.dgvFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFolders.Name = "dgvFolders";
            this.dgvFolders.ReadOnly = true;
            this.dgvFolders.RowHeadersVisible = false;
            this.dgvFolders.RowHeadersWidth = 72;
            this.dgvFolders.Size = new System.Drawing.Size(116, 599);
            this.dgvFolders.TabIndex = 8;
            this.dgvFolders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFolders_CellDoubleClick);
            // 
            // Folder
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Folder.DefaultCellStyle = dataGridViewCellStyle1;
            this.Folder.HeaderText = "";
            this.Folder.MinimumWidth = 50;
            this.Folder.Name = "Folder";
            this.Folder.ReadOnly = true;
            this.Folder.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Folder.Width = 50;
            // 
            // dgvQueue
            // 
            this.dgvQueue.AllowUserToAddRows = false;
            this.dgvQueue.AllowUserToDeleteRows = false;
            this.dgvQueue.AllowUserToResizeRows = false;
            this.dgvQueue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQueue.BackgroundColor = System.Drawing.Color.White;
            this.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Output,
            this.Title_ID,
            this.CustomTitle,
            this.CustomAuthor,
            this.CustomVersion,
            this.View,
            this.Remove});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQueue.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvQueue.Location = new System.Drawing.Point(21, 774);
            this.dgvQueue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvQueue.MultiSelect = false;
            this.dgvQueue.Name = "dgvQueue";
            this.dgvQueue.RowHeadersVisible = false;
            this.dgvQueue.RowHeadersWidth = 72;
            this.dgvQueue.Size = new System.Drawing.Size(1452, 169);
            this.dgvQueue.TabIndex = 13;
            this.dgvQueue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQueue_CellContentClick);
            this.dgvQueue.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQueue_CellEndEdit);
            // 
            // Output
            // 
            this.Output.HeaderText = "Icon Name";
            this.Output.MinimumWidth = 200;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Width = 200;
            // 
            // Title_ID
            // 
            this.Title_ID.HeaderText = "Title ID";
            this.Title_ID.MinimumWidth = 120;
            this.Title_ID.Name = "Title_ID";
            this.Title_ID.Width = 120;
            // 
            // CustomTitle
            // 
            this.CustomTitle.HeaderText = "Custom Title";
            this.CustomTitle.MinimumWidth = 150;
            this.CustomTitle.Name = "CustomTitle";
            this.CustomTitle.Width = 150;
            // 
            // CustomAuthor
            // 
            this.CustomAuthor.HeaderText = "Custom Author";
            this.CustomAuthor.MinimumWidth = 100;
            this.CustomAuthor.Name = "CustomAuthor";
            this.CustomAuthor.Width = 150;
            // 
            // CustomVersion
            // 
            this.CustomVersion.HeaderText = "Custom Version";
            this.CustomVersion.MinimumWidth = 120;
            this.CustomVersion.Name = "CustomVersion";
            this.CustomVersion.Width = 120;
            // 
            // View
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            this.View.DefaultCellStyle = dataGridViewCellStyle3;
            this.View.HeaderText = "View";
            this.View.Image = global::NX_GIC.Properties.Resources.image_file;
            this.View.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.View.MinimumWidth = 40;
            this.View.Name = "View";
            this.View.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.View.Width = 40;
            // 
            // Remove
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            this.Remove.DefaultCellStyle = dataGridViewCellStyle4;
            this.Remove.HeaderText = "Delete";
            this.Remove.Image = global::NX_GIC.Properties.Resources.remove;
            this.Remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Remove.MinimumWidth = 40;
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remove.ToolTipText = "Remove icon from Queue";
            this.Remove.Width = 40;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Image = global::NX_GIC.Properties.Resources.icon_scan;
            this.btnConnect.Location = new System.Drawing.Point(21, 52);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(116, 38);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Scan";
            this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbRepo
            // 
            this.cmbRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRepo.FormattingEnabled = true;
            this.cmbRepo.Location = new System.Drawing.Point(798, 57);
            this.cmbRepo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRepo.Name = "cmbRepo";
            this.cmbRepo.Size = new System.Drawing.Size(235, 28);
            this.cmbRepo.TabIndex = 4;
            this.cmbRepo.Text = "<Start Scan>";
            this.cmbRepo.Visible = false;
            this.cmbRepo.SelectedIndexChanged += new System.EventHandler(this.cmbRepo_SelectedIndexChanged);
            // 
            // cmbSubfolders
            // 
            this.cmbSubfolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubfolders.FormattingEnabled = true;
            this.cmbSubfolders.Location = new System.Drawing.Point(21, 123);
            this.cmbSubfolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSubfolders.Name = "cmbSubfolders";
            this.cmbSubfolders.Size = new System.Drawing.Size(114, 28);
            this.cmbSubfolders.TabIndex = 7;
            this.cmbSubfolders.Text = "<Hit Scan>";
            this.cmbSubfolders.SelectedIndexChanged += new System.EventHandler(this.cmbSubfolders_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::NX_GIC.Properties.Resources.icon_transfer;
            this.button1.Location = new System.Drawing.Point(404, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Transfer";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddResize
            // 
            this.btnAddResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddResize.Image = global::NX_GIC.Properties.Resources.icon_add;
            this.btnAddResize.Location = new System.Drawing.Point(144, 52);
            this.btnAddResize.Name = "btnAddResize";
            this.btnAddResize.Size = new System.Drawing.Size(116, 38);
            this.btnAddResize.TabIndex = 2;
            this.btnAddResize.Text = "Add New";
            this.btnAddResize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddResize.UseVisualStyleBackColor = true;
            this.btnAddResize.Click += new System.EventHandler(this.btnAddResize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(676, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Folder:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Style:";
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomOut.BackgroundImage = global::NX_GIC.Properties.Resources.ZoomOut;
            this.btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.Location = new System.Drawing.Point(1332, 52);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(38, 38);
            this.btnZoomOut.TabIndex = 5;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomIn.BackgroundImage = global::NX_GIC.Properties.Resources.ZoomIn;
            this.btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Location = new System.Drawing.Point(1436, 52);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(38, 38);
            this.btnZoomIn.TabIndex = 6;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1372, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "[Zoom]";
            // 
            // flowIcons
            // 
            this.flowIcons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowIcons.AutoScroll = true;
            this.flowIcons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowIcons.Controls.Add(this.pictureBox1);
            this.flowIcons.Location = new System.Drawing.Point(144, 98);
            this.flowIcons.Name = "flowIcons";
            this.flowIcons.Size = new System.Drawing.Size(1328, 666);
            this.flowIcons.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 408);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // cmsTitleID
            // 
            this.cmsTitleID.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTitleID.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsTitleID.Name = "cmsTitleID";
            this.cmsTitleID.Size = new System.Drawing.Size(205, 36);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(204, 32);
            this.toolStripMenuItem1.Text = "Change Title ID";
            // 
            // ofdCsv
            // 
            this.ofdCsv.FileName = "openFileDialog1";
            // 
            // dgvInstalled
            // 
            this.dgvInstalled.AllowUserToAddRows = false;
            this.dgvInstalled.AllowUserToDeleteRows = false;
            this.dgvInstalled.AllowUserToResizeRows = false;
            this.dgvInstalled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInstalled.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInstalled.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvInstalled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstalled.Location = new System.Drawing.Point(1098, 98);
            this.dgvInstalled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInstalled.MultiSelect = false;
            this.dgvInstalled.Name = "dgvInstalled";
            this.dgvInstalled.ReadOnly = true;
            this.dgvInstalled.RowHeadersVisible = false;
            this.dgvInstalled.RowHeadersWidth = 62;
            this.dgvInstalled.Size = new System.Drawing.Size(375, 666);
            this.dgvInstalled.TabIndex = 12;
            this.dgvInstalled.Visible = false;
            this.dgvInstalled.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstalled_CellContentClick);
            // 
            // btnAutoGic
            // 
            this.btnAutoGic.Image = global::NX_GIC.Properties.Resources.icon_auto;
            this.btnAutoGic.Location = new System.Drawing.Point(267, 52);
            this.btnAutoGic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAutoGic.Name = "btnAutoGic";
            this.btnAutoGic.Size = new System.Drawing.Size(129, 38);
            this.btnAutoGic.TabIndex = 3;
            this.btnAutoGic.Text = "Auto GIC";
            this.btnAutoGic.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAutoGic.UseVisualStyleBackColor = true;
            this.btnAutoGic.Click += new System.EventHandler(this.btnAutoGic_Click);
            // 
            // btnAddtoOut
            // 
            this.btnAddtoOut.Enabled = false;
            this.btnAddtoOut.Image = global::NX_GIC.Properties.Resources.icon_all;
            this.btnAddtoOut.Location = new System.Drawing.Point(336, 98);
            this.btnAddtoOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddtoOut.Name = "btnAddtoOut";
            this.btnAddtoOut.Size = new System.Drawing.Size(185, 38);
            this.btnAddtoOut.TabIndex = 11;
            this.btnAddtoOut.Text = "Add All to Output";
            this.btnAddtoOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddtoOut.UseVisualStyleBackColor = true;
            this.btnAddtoOut.Visible = false;
            this.btnAddtoOut.Click += new System.EventHandler(this.btnAddtoOut_Click);
            // 
            // btnReloadCSV
            // 
            this.btnReloadCSV.Image = global::NX_GIC.Properties.Resources.icon_csv;
            this.btnReloadCSV.Location = new System.Drawing.Point(194, 98);
            this.btnReloadCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReloadCSV.Name = "btnReloadCSV";
            this.btnReloadCSV.Size = new System.Drawing.Size(134, 38);
            this.btnReloadCSV.TabIndex = 10;
            this.btnReloadCSV.Text = "Reload CSV";
            this.btnReloadCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReloadCSV.UseVisualStyleBackColor = true;
            this.btnReloadCSV.Visible = false;
            this.btnReloadCSV.Click += new System.EventHandler(this.btnReloadCSV_Click);
            // 
            // cmbAutoStyle
            // 
            this.cmbAutoStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAutoStyle.FormattingEnabled = true;
            this.cmbAutoStyle.Location = new System.Drawing.Point(21, 103);
            this.cmbAutoStyle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAutoStyle.Name = "cmbAutoStyle";
            this.cmbAutoStyle.Size = new System.Drawing.Size(162, 28);
            this.cmbAutoStyle.TabIndex = 19;
            this.cmbAutoStyle.Text = "<Select Icon Style>";
            this.cmbAutoStyle.Visible = false;
            this.cmbAutoStyle.SelectedIndexChanged += new System.EventHandler(this.cmbAutoStyle_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 978);
            this.Controls.Add(this.cmbAutoStyle);
            this.Controls.Add(this.btnReloadCSV);
            this.Controls.Add(this.btnAddtoOut);
            this.Controls.Add(this.btnAutoGic);
            this.Controls.Add(this.dgvInstalled);
            this.Controls.Add(this.flowIcons);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddResize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSubfolders);
            this.Controls.Add(this.cmbRepo);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.dgvQueue);
            this.Controls.Add(this.dgvFolders);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "[NX-GIC] Nintendo Switch - Game Icon Customizer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
            this.flowIcons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsTitleID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstalled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgvFolders;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvQueue;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbRepo;
        private System.Windows.Forms.ComboBox cmbSubfolders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddResize;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem goOfflineToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowIcons;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ContextMenuStrip cmsTitleID;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showIconsForInstalledGamesOnlyToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdCsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folder;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dgvInstalled;
        private System.Windows.Forms.Button btnAutoGic;
        private System.Windows.Forms.Button btnAddtoOut;
        private System.Windows.Forms.ToolStripMenuItem viewInstalledGamesListToolStripMenuItem;
        private System.Windows.Forms.Button btnReloadCSV;
        private System.Windows.Forms.ComboBox cmbAutoStyle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem installNXTitlesListDumperNROToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Output;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomVersion;
        private System.Windows.Forms.DataGridViewImageColumn View;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem downloadTitlesCSVFTPToolStripMenuItem;
    }
}

