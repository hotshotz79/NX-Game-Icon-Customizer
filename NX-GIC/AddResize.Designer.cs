
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUrl = new System.Windows.Forms.Button();
            this.radHori = new System.Windows.Forms.RadioButton();
            this.radVert = new System.Windows.Forms.RadioButton();
            this.radDefault = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.picTheme = new System.Windows.Forms.PictureBox();
            this.btnTitle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 430);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Icon Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 428);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(544, 425);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(55, 24);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(604, 424);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 24);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(301, 428);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitle.MaxLength = 16;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(156, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 430);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Load Image:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(91, 14);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(55, 24);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnUrl
            // 
            this.btnUrl.Location = new System.Drawing.Point(155, 14);
            this.btnUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUrl.Name = "btnUrl";
            this.btnUrl.Size = new System.Drawing.Size(55, 24);
            this.btnUrl.TabIndex = 2;
            this.btnUrl.Text = "URL";
            this.btnUrl.UseVisualStyleBackColor = true;
            this.btnUrl.Click += new System.EventHandler(this.btnUrl_Click);
            // 
            // radHori
            // 
            this.radHori.AutoSize = true;
            this.radHori.Location = new System.Drawing.Point(516, 18);
            this.radHori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radHori.Name = "radHori";
            this.radHori.Size = new System.Drawing.Size(72, 17);
            this.radHori.TabIndex = 4;
            this.radHori.TabStop = true;
            this.radHori.Text = "Horizontal";
            this.radHori.UseVisualStyleBackColor = true;
            this.radHori.CheckedChanged += new System.EventHandler(this.radHori_CheckedChanged);
            // 
            // radVert
            // 
            this.radVert.AutoSize = true;
            this.radVert.Location = new System.Drawing.Point(599, 18);
            this.radVert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radVert.Name = "radVert";
            this.radVert.Size = new System.Drawing.Size(60, 17);
            this.radVert.TabIndex = 5;
            this.radVert.TabStop = true;
            this.radVert.Text = "Vertical";
            this.radVert.UseVisualStyleBackColor = true;
            this.radVert.CheckedChanged += new System.EventHandler(this.radVert_CheckedChanged);
            // 
            // radDefault
            // 
            this.radDefault.AutoSize = true;
            this.radDefault.Checked = true;
            this.radDefault.Location = new System.Drawing.Point(440, 18);
            this.radDefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radDefault.Name = "radDefault";
            this.radDefault.Size = new System.Drawing.Size(59, 17);
            this.radDefault.TabIndex = 3;
            this.radDefault.TabStop = true;
            this.radDefault.Text = "Default";
            this.radDefault.UseVisualStyleBackColor = true;
            this.radDefault.CheckedChanged += new System.EventHandler(this.radDefault_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Icon style:";
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.White;
            this.picPreview.Location = new System.Drawing.Point(70, 148);
            this.picPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(130, 130);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // picTheme
            // 
            this.picTheme.Image = global::NX_GIC.Properties.Resources.Default;
            this.picTheme.Location = new System.Drawing.Point(19, 52);
            this.picTheme.Name = "picTheme";
            this.picTheme.Size = new System.Drawing.Size(640, 360);
            this.picTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTheme.TabIndex = 14;
            this.picTheme.TabStop = false;
            // 
            // btnTitle
            // 
            this.btnTitle.Location = new System.Drawing.Point(465, 425);
            this.btnTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(37, 24);
            this.btnTitle.TabIndex = 8;
            this.btnTitle.Text = "Find";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddResize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(677, 464);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.picTheme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radDefault);
            this.Controls.Add(this.radVert);
            this.Controls.Add(this.radHori);
            this.Controls.Add(this.btnUrl);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddResize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Icon";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddResize_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTheme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUrl;
        private System.Windows.Forms.RadioButton radHori;
        private System.Windows.Forms.RadioButton radVert;
        private System.Windows.Forms.RadioButton radDefault;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picTheme;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}