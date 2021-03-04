using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using MediaDevices;
using WinSCP;

namespace NX_GIC
{
    public partial class Transfer : Form
    {
        bool statusSuccess = true;
        string sourcePath = Directory.GetCurrentDirectory() + @"\Output\";
        public Transfer()
        {
            InitializeComponent();
            txtIP.Text = Properties.Settings.Default.IPAddress;

            //Populate Drop Down List with Drives
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.Name != "C:\\")
                    cmbDrives.Items.Add(drive.Name + " - (" + drive.VolumeLabel + ")");
            }

            foreach (var devices in MediaDevice.GetDevices())
            {
                cmbDevice.Items.Add(devices.Description);
            }
        }

        private void usbTransfer()
        {
            if (cmbDrives.SelectedIndex == -1) {
                MessageBox.Show("No Drive Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusSuccess = false;
                return;
            }
            string pathToCopy = cmbDrives.SelectedItem.ToString().Substring(0, 3) + "atmosphere\\contents\\";
            //Check if the path exists
            if (!Directory.Exists(pathToCopy))
            { 
                MessageBox.Show(pathToCopy + " does not exist. \n\nMake sure your Switch is connected via USB mode (or any " +
                    "other method to view the drive) is enabled.",
                    "Path Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                statusSuccess = false;
            }
            else
            {
                //Transfer
                File.Copy(sourcePath, pathToCopy, true);
                statusSuccess = true;
            }
        }

        private void mtpTransfer()
        {
            var devices = MediaDevice.GetDevices();
            string destPath = @"\SdCard\atmosphere\contents";
            try
            {
                using (var device = devices.First(d => d.Description == cmbDevice.SelectedItem.ToString()))
                {
                    device.Connect();
                    device.UploadFolder(sourcePath, destPath, true);
                    device.Disconnect();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                statusSuccess = false;
            }
        }

        private void ftpTransfer()
        {
            //re-coded to use winSCP
            using (Session session = new Session())
            {
                try
                {
                    Console.WriteLine(Properties.Settings.Default.IPAddress);
                    sessionOptions.HostName = Properties.Settings.Default.IPAddress;
                    // Connect
                    session.Open(sessionOptions);
                    // Upload
                    session.PutFilesToDirectory(sourcePath, "/atmosphere/contents").Check();
                    statusSuccess = true;
                }
                catch (Exception err)
                {
                    statusSuccess = false;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Transfer via IP
            // root path must exist
            //string url = @"ftp://" + txtIP.Text + @":5000/atmosphere/contents/";
            //NetworkCredential credentials = new NetworkCredential("", "");

            //UploadFtpDirectory(sourcePath, url, credentials);

        }

        // Setup session options
        SessionOptions sessionOptions = new SessionOptions
        {
            Protocol = Protocol.Ftp,
            HostName = Properties.Settings.Default.IPAddress,
            PortNumber = 5000,
            UserName = " ",
            Password = "",
        };

        void UploadFtpDirectory(string sourcePath, string url, NetworkCredential credentials)
        {
            IEnumerable<string> files = Directory.EnumerateFiles(sourcePath);
            foreach (string file in files)
            {
                using (WebClient client = new WebClient())
                {
                    //Console.WriteLine($"Uploading {file}");
                    client.Credentials = credentials;
                    client.UploadFile(url + Path.GetFileName(file), file);
                }
            }

            IEnumerable<string> directories = Directory.EnumerateDirectories(sourcePath);
            foreach (string directory in directories)
            {
                string name = Path.GetFileName(directory);
                string directoryUrl = url + name;

                lblStatus.Text = "Connecting...";
                lblStatus.BackColor = Color.Orange;
                lblStatus.ForeColor = Color.Black;

                try
                {
                    //Console.WriteLine($"Creating {name}");
                    FtpWebRequest requestDir = (FtpWebRequest)WebRequest.Create(directoryUrl);
                    requestDir.Method = WebRequestMethods.Ftp.MakeDirectory;
                    requestDir.Credentials = credentials;
                    requestDir.GetResponse().Close();
                }
                catch (WebException ex)
                {
                    statusSuccess = false;
                    FtpWebResponse response = (FtpWebResponse)ex.Response;
                    if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    {
                        // probably exists already
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show(ex.Message, ex.Status.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatus.Text = "Error";
                        lblStatus.BackColor = Color.Red;
                        lblStatus.ForeColor = Color.White;
                        throw;
                    }
                }

                UploadFtpDirectory(directory, directoryUrl + "/", credentials);
                statusSuccess = true;
            }
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IPAddress = txtIP.Text;
            Properties.Settings.Default.Save();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (radUsb.Checked) usbTransfer();
            else if (radMtp.Checked) mtpTransfer();
            else if (radFtp.Checked) ftpTransfer();
            else
            {
                MessageBox.Show("Please select a transfer method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cursor.Current = Cursors.Default;
                return;
            }

            //Queue Clear
            if (ckbDelTemp.Checked)
            {
                //Delete all subfolders within /OUTPUT/
            }

            //Status Update
            if (statusSuccess)
            {
                lblStatus.Text = "Success";
                lblStatus.BackColor = Color.Green;
                lblStatus.ForeColor = Color.White;

                //Delete Output
                Directory.Delete(sourcePath, true);
                Directory.CreateDirectory(sourcePath);
            }
            else
            {
                lblStatus.Text = "Error";
                lblStatus.BackColor = Color.Red;
                lblStatus.ForeColor = Color.White;
            }
            Cursor.Current = Cursors.Default;
        }

        private void radUsb_CheckedChanged(object sender, EventArgs e)
        {
            if (radUsb.Checked) cmbDrives.Enabled = true; else cmbDrives.Enabled = false;
        }

        private void radFtp_CheckedChanged(object sender, EventArgs e)
        {
            if (radFtp.Checked) txtIP.Enabled = true; else txtIP.Enabled = false;
        }

        private void ckbSysTweak_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSysTweak.Checked)
                MessageBox.Show("NOTE: This will copy sys-tweak files to the atmosphere/contents/00FF747765616BFF/ folder" +
                    "\n\nIf Atmosphere fails to boot up after installing this, simply delete the [00FF747765616BFF] folder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Transfer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void radMtp_CheckedChanged(object sender, EventArgs e)
        {
            if (radMtp.Checked) cmbDevice.Enabled = true; else cmbDevice.Enabled = false; 
        }
    }
}
