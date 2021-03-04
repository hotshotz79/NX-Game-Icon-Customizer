
namespace NX_GIC
{
    partial class Transfer
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
            this.cmbDrives = new System.Windows.Forms.ComboBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.ckbDelTemp = new System.Windows.Forms.CheckBox();
            this.radUsb = new System.Windows.Forms.RadioButton();
            this.radFtp = new System.Windows.Forms.RadioButton();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ckbSysTweak = new System.Windows.Forms.CheckBox();
            this.radMtp = new System.Windows.Forms.RadioButton();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Transfer Method:";
            // 
            // cmbDrives
            // 
            this.cmbDrives.Enabled = false;
            this.cmbDrives.FormattingEnabled = true;
            this.cmbDrives.Location = new System.Drawing.Point(113, 27);
            this.cmbDrives.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDrives.Name = "cmbDrives";
            this.cmbDrives.Size = new System.Drawing.Size(134, 21);
            this.cmbDrives.TabIndex = 4;
            this.cmbDrives.Text = "Select a drive";
            this.cmbDrives.Visible = false;
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(113, 72);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(134, 20);
            this.txtIP.TabIndex = 5;
            this.txtIP.Text = "0.0.0.0";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // ckbDelTemp
            // 
            this.ckbDelTemp.AutoSize = true;
            this.ckbDelTemp.Checked = true;
            this.ckbDelTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbDelTemp.Location = new System.Drawing.Point(18, 99);
            this.ckbDelTemp.Margin = new System.Windows.Forms.Padding(2);
            this.ckbDelTemp.Name = "ckbDelTemp";
            this.ckbDelTemp.Size = new System.Drawing.Size(194, 17);
            this.ckbDelTemp.TabIndex = 6;
            this.ckbDelTemp.Text = "Clear queue/output after transfering";
            this.ckbDelTemp.UseVisualStyleBackColor = true;
            // 
            // radUsb
            // 
            this.radUsb.AutoSize = true;
            this.radUsb.Location = new System.Drawing.Point(18, 28);
            this.radUsb.Margin = new System.Windows.Forms.Padding(2);
            this.radUsb.Name = "radUsb";
            this.radUsb.Size = new System.Drawing.Size(47, 17);
            this.radUsb.TabIndex = 9;
            this.radUsb.TabStop = true;
            this.radUsb.Text = "USB";
            this.radUsb.UseVisualStyleBackColor = true;
            this.radUsb.Visible = false;
            this.radUsb.CheckedChanged += new System.EventHandler(this.radUsb_CheckedChanged);
            // 
            // radFtp
            // 
            this.radFtp.AutoSize = true;
            this.radFtp.Location = new System.Drawing.Point(18, 73);
            this.radFtp.Margin = new System.Windows.Forms.Padding(2);
            this.radFtp.Name = "radFtp";
            this.radFtp.Size = new System.Drawing.Size(45, 17);
            this.radFtp.TabIndex = 10;
            this.radFtp.TabStop = true;
            this.radFtp.Text = "FTP";
            this.radFtp.UseVisualStyleBackColor = true;
            this.radFtp.CheckedChanged += new System.EventHandler(this.radFtp_CheckedChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(185, 149);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(61, 25);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblStatus.Location = new System.Drawing.Point(64, 155);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Standing By";
            // 
            // ckbSysTweak
            // 
            this.ckbSysTweak.AutoSize = true;
            this.ckbSysTweak.Enabled = false;
            this.ckbSysTweak.Location = new System.Drawing.Point(18, 128);
            this.ckbSysTweak.Margin = new System.Windows.Forms.Padding(2);
            this.ckbSysTweak.Name = "ckbSysTweak";
            this.ckbSysTweak.Size = new System.Drawing.Size(243, 17);
            this.ckbSysTweak.TabIndex = 14;
            this.ckbSysTweak.Text = "Install Sys-Tweak (Required for Custom Icons)";
            this.ckbSysTweak.UseVisualStyleBackColor = true;
            this.ckbSysTweak.Visible = false;
            this.ckbSysTweak.CheckedChanged += new System.EventHandler(this.ckbSysTweak_CheckedChanged);
            // 
            // radMtp
            // 
            this.radMtp.AutoSize = true;
            this.radMtp.Location = new System.Drawing.Point(18, 48);
            this.radMtp.Margin = new System.Windows.Forms.Padding(2);
            this.radMtp.Name = "radMtp";
            this.radMtp.Size = new System.Drawing.Size(48, 17);
            this.radMtp.TabIndex = 16;
            this.radMtp.TabStop = true;
            this.radMtp.Text = "MTP";
            this.radMtp.UseVisualStyleBackColor = true;
            this.radMtp.CheckedChanged += new System.EventHandler(this.radMtp_CheckedChanged);
            // 
            // cmbDevice
            // 
            this.cmbDevice.Enabled = false;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(113, 48);
            this.cmbDevice.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(134, 21);
            this.cmbDevice.TabIndex = 15;
            this.cmbDevice.Text = "Select device";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 186);
            this.Controls.Add(this.radMtp);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.ckbSysTweak);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.radFtp);
            this.Controls.Add(this.radUsb);
            this.Controls.Add(this.ckbDelTemp);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.cmbDrives);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transfer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Transfer_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDrives;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.CheckBox ckbDelTemp;
        private System.Windows.Forms.RadioButton radUsb;
        private System.Windows.Forms.RadioButton radFtp;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox ckbSysTweak;
        private System.Windows.Forms.RadioButton radMtp;
        private System.Windows.Forms.ComboBox cmbDevice;
    }
}