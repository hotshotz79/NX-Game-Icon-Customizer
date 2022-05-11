
namespace NX_GIC
{
    partial class AddResize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddResize));
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUrl = new System.Windows.Forms.Button();
            this.radHori = new System.Windows.Forms.RadioButton();
            this.radVert = new System.Windows.Forms.RadioButton();
            this.radDefault = new System.Windows.Forms.RadioButton();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.picTheme = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_gameLookup = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbGameList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radManual = new System.Windows.Forms.RadioButton();
            this.radOnline = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stripBtn_Titles = new System.Windows.Forms.ToolStripMenuItem();
            this.stripBtn_Json = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdCsv = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTheme)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Load Image:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(140, 85);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(82, 37);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnUrl
            // 
            this.btnUrl.Location = new System.Drawing.Point(236, 85);
            this.btnUrl.Name = "btnUrl";
            this.btnUrl.Size = new System.Drawing.Size(82, 37);
            this.btnUrl.TabIndex = 2;
            this.btnUrl.Text = "URL";
            this.btnUrl.UseVisualStyleBackColor = true;
            this.btnUrl.Click += new System.EventHandler(this.btnUrl_Click);
            // 
            // radHori
            // 
            this.radHori.AutoSize = true;
            this.radHori.Location = new System.Drawing.Point(98, 25);
            this.radHori.Name = "radHori";
            this.radHori.Size = new System.Drawing.Size(106, 24);
            this.radHori.TabIndex = 4;
            this.radHori.Text = "Horizontal";
            this.radHori.UseVisualStyleBackColor = true;
            this.radHori.CheckedChanged += new System.EventHandler(this.radHori_CheckedChanged);
            // 
            // radVert
            // 
            this.radVert.AutoSize = true;
            this.radVert.Location = new System.Drawing.Point(210, 25);
            this.radVert.Name = "radVert";
            this.radVert.Size = new System.Drawing.Size(87, 24);
            this.radVert.TabIndex = 5;
            this.radVert.Text = "Vertical";
            this.radVert.UseVisualStyleBackColor = true;
            this.radVert.CheckedChanged += new System.EventHandler(this.radVert_CheckedChanged);
            // 
            // radDefault
            // 
            this.radDefault.AutoSize = true;
            this.radDefault.Checked = true;
            this.radDefault.Location = new System.Drawing.Point(6, 25);
            this.radDefault.Name = "radDefault";
            this.radDefault.Size = new System.Drawing.Size(86, 24);
            this.radDefault.TabIndex = 3;
            this.radDefault.TabStop = true;
            this.radDefault.Text = "Default";
            this.radDefault.UseVisualStyleBackColor = true;
            this.radDefault.CheckedChanged += new System.EventHandler(this.radDefault_CheckedChanged);
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.White;
            this.picPreview.Location = new System.Drawing.Point(105, 286);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(195, 200);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // picTheme
            // 
            this.picTheme.Image = global::NX_GIC.Properties.Resources.Default;
            this.picTheme.Location = new System.Drawing.Point(28, 138);
            this.picTheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picTheme.Name = "picTheme";
            this.picTheme.Size = new System.Drawing.Size(960, 554);
            this.picTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTheme.TabIndex = 14;
            this.picTheme.TabStop = false;
            // 
            // txt_gameLookup
            // 
            this.txt_gameLookup.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_gameLookup.Location = new System.Drawing.Point(20, 31);
            this.txt_gameLookup.Name = "txt_gameLookup";
            this.txt_gameLookup.Size = new System.Drawing.Size(170, 26);
            this.txt_gameLookup.TabIndex = 23;
            this.txt_gameLookup.Text = "<Enter Game Name>";
            this.txt_gameLookup.Click += new System.EventHandler(this.txt_gameLookup_Click);
            this.txt_gameLookup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Image = global::NX_GIC.Properties.Resources.icon_scan;
            this.button1.Location = new System.Drawing.Point(196, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 52);
            this.button1.TabIndex = 24;
            this.button1.Text = "Search";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Find:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(945, 554);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.Controls.Add(this.button2);
            this.searchPanel.Controls.Add(this.cmbGameList);
            this.searchPanel.Controls.Add(this.label5);
            this.searchPanel.Controls.Add(this.cmbSize);
            this.searchPanel.Controls.Add(this.label4);
            this.searchPanel.Controls.Add(this.tableLayoutPanel1);
            this.searchPanel.Controls.Add(this.label7);
            this.searchPanel.Controls.Add(this.txt_gameLookup);
            this.searchPanel.Controls.Add(this.button1);
            this.searchPanel.Location = new System.Drawing.Point(12, 74);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(994, 625);
            this.searchPanel.TabIndex = 23;
            this.searchPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Image = global::NX_GIC.Properties.Resources.icon_gallery;
            this.button2.Location = new System.Drawing.Point(882, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 52);
            this.button2.TabIndex = 27;
            this.button2.Text = "Pull";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbGameList
            // 
            this.cmbGameList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGameList.Enabled = false;
            this.cmbGameList.FormattingEnabled = true;
            this.cmbGameList.Location = new System.Drawing.Point(285, 30);
            this.cmbGameList.Name = "cmbGameList";
            this.cmbGameList.Size = new System.Drawing.Size(338, 28);
            this.cmbGameList.TabIndex = 25;
            this.cmbGameList.SelectedIndexChanged += new System.EventHandler(this.cmbGameList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Select:";
            // 
            // cmbSize
            // 
            this.cmbSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSize.Enabled = false;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "---GRID Style---",
            "Any Size",
            "1:1 Square -512x512",
            "1:1 Square -1024x1024",
            "2:3 Vertical -600x900",
            "92:43 Horizontal -460x215",
            "92:43 Horizontal -920x430",
            "",
            "---ICON (Square)",
            "---HERO (Widescreen)",
            "---LOGO (Horizontal)"});
            this.cmbSize.Location = new System.Drawing.Point(628, 30);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(247, 28);
            this.cmbSize.TabIndex = 26;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Image Size";
            // 
            // radManual
            // 
            this.radManual.AutoSize = true;
            this.radManual.Checked = true;
            this.radManual.Location = new System.Drawing.Point(6, 25);
            this.radManual.Name = "radManual";
            this.radManual.Size = new System.Drawing.Size(86, 24);
            this.radManual.TabIndex = 24;
            this.radManual.TabStop = true;
            this.radManual.Text = "Manual";
            this.radManual.UseVisualStyleBackColor = true;
            this.radManual.CheckedChanged += new System.EventHandler(this.radManual_CheckedChanged);
            // 
            // radOnline
            // 
            this.radOnline.AutoSize = true;
            this.radOnline.Location = new System.Drawing.Point(98, 25);
            this.radOnline.Name = "radOnline";
            this.radOnline.Size = new System.Drawing.Size(79, 24);
            this.radOnline.TabIndex = 25;
            this.radOnline.Text = "Online";
            this.radOnline.UseVisualStyleBackColor = true;
            this.radOnline.CheckedChanged += new System.EventHandler(this.radOnline_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radManual);
            this.groupBox1.Controls.Add(this.radOnline);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 60);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Method";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radDefault);
            this.groupBox2.Controls.Add(this.radHori);
            this.groupBox2.Controls.Add(this.radVert);
            this.groupBox2.Location = new System.Drawing.Point(608, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 60);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Icon Style";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 705);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 66);
            this.panel1.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(672, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Find...   |  ▼";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Image = global::NX_GIC.Properties.Resources.icon_add;
            this.btnAdd.Location = new System.Drawing.Point(899, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 37);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::NX_GIC.Properties.Resources.icon_csv;
            this.btnReset.Location = new System.Drawing.Point(800, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 37);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(434, 23);
            this.txtTitle.MaxLength = 16;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(232, 26);
            this.txtTitle.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Title ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 26);
            this.txtName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Icon Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripBtn_Titles,
            this.stripBtn_Json});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(280, 68);
            // 
            // stripBtn_Titles
            // 
            this.stripBtn_Titles.Name = "stripBtn_Titles";
            this.stripBtn_Titles.Size = new System.Drawing.Size(279, 32);
            this.stripBtn_Titles.Text = "CSV (Pulled from Switch)";
            this.stripBtn_Titles.Click += new System.EventHandler(this.stripBtn_Titles_Click);
            // 
            // stripBtn_Json
            // 
            this.stripBtn_Json.Name = "stripBtn_Json";
            this.stripBtn_Json.Size = new System.Drawing.Size(279, 32);
            this.stripBtn_Json.Text = "JSON (Online Database)";
            this.stripBtn_Json.Click += new System.EventHandler(this.stripBtn_Json_Click);
            // 
            // ofdCsv
            // 
            this.ofdCsv.FileName = "titles.csv";
            // 
            // AddResize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1018, 778);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.picTheme);
            this.Controls.Add(this.btnUrl);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "AddResize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Icon";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddResize_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTheme)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUrl;
        private System.Windows.Forms.RadioButton radHori;
        private System.Windows.Forms.RadioButton radVert;
        private System.Windows.Forms.RadioButton radDefault;
        private System.Windows.Forms.PictureBox picTheme;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_gameLookup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.RadioButton radManual;
        private System.Windows.Forms.RadioButton radOnline;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGameList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripBtn_Titles;
        private System.Windows.Forms.ToolStripMenuItem stripBtn_Json;
        private System.Windows.Forms.OpenFileDialog ofdCsv;
    }
}