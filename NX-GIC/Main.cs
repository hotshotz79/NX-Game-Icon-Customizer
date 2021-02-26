using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace NX_GIC
{
    public partial class Main : Form
    {
        string path = Directory.GetCurrentDirectory();
        string selectedPath = "";
        string subPath = "";
        string iconFolder = "";
        bool moveFiles = false;
        decimal zoomLvl = Properties.Settings.Default.ZoomLevel;

        public Main()
        {
            InitializeComponent();
        }

        private async Task DownloadFromGitHubRepo()
        {
            Cursor.Current = Cursors.WaitCursor;
            //Split repos into arrays
            var gitUserRepo = Properties.Settings.Default.GitHubs.Split(';').Select(x => x.Split('/')).ToArray();

            //Loop through all Repos and download/extract as needed
            for (int x = 0; x < gitUserRepo.Length; x++)
            {
                //Get all releases from GitHub
                //Source: https://octokitnet.readthedocs.io/en/latest/getting-started/
                GitHubClient client = new GitHubClient(new ProductHeaderValue("nxgic"));
                IReadOnlyList<Release> releases = await client.Repository.Release.GetAll(gitUserRepo[x][0].ToString(), gitUserRepo[x][1].ToString());
                IReadOnlyList<RepositoryTag> tags = await client.Repository.GetAllTags(gitUserRepo[x][0].ToString(), gitUserRepo[x][1].ToString());

                string fileName = gitUserRepo[x][0] + "." + tags[0].Name + ".zip";

                //Download/Extract if new
                if (!File.Exists(path + @"\" + fileName))
                {
                    //Download Latest Zip/Tag
                    using (var clientWeb = new WebClient())
                    {
                        clientWeb.Headers.Add("User-Agent: Other");
                        clientWeb.DownloadFile(tags[0].ZipballUrl, fileName);
                    }
                    //Extract zip file
                    ZipFile.ExtractToDirectory(fileName, path);

                    //Delete the zip file to save space
                    File.Delete(path + @"\" + fileName);
                    //Then generate a dummy file for Version check purposes
                    File.Create(path + @"\" + fileName);
                    moveFiles = true;
                }
            }

            string[] subdirectoryEntries = Directory.GetDirectories(path);
            for (int x = 0; x < subdirectoryEntries.Length; x++)
            {
                // Move Extracted folders into MAIN\
                if (moveFiles)
                {
                    if (!subdirectoryEntries[x].ToString().Contains("OUTPUT") &&
                        !subdirectoryEntries[x].ToString().Contains("Main"))
                    {
                        string sourceDirectory = subdirectoryEntries[x];
                        string targetDirectory = path + @"\Main";
                        string gitUser = Path.GetFileName(sourceDirectory).Substring(0,4);
                        DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
                        DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

                        CopyAll(diSource, diTarget, gitUser);
                        Directory.Delete(sourceDirectory, true);
                    }
                }
                Cursor.Current = Cursors.Default;
            }
        }

        //Copy Downloaded Repo folders into one; Main
        public static void CopyAll(DirectoryInfo source, DirectoryInfo target, string iconName)
        {
            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }

            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                //Tag each icon with the github user name to prevent from overwriting
                string replacedName = Regex.Replace(fi.Name, "-icon", "-(" + iconName + ")-icon", RegexOptions.IgnoreCase);
                fi.CopyTo(Path.Combine(target.ToString(), replacedName), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir, iconName);
            }
        }

        //Scan Button
        private async void btnConnect_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //Create OUTPUT & Main folder if they don't exist
            if (!Directory.Exists(path + "\\OUTPUT"))  Directory.CreateDirectory(path + "\\OUTPUT");
            if (!Directory.Exists(path + "\\Main")) Directory.CreateDirectory(path + "\\Main");

            //Check updates and download icons from Github
            await DownloadFromGitHubRepo();

            //Get list of all existing folders
            string[] subdirectoryEntries = Directory.GetDirectories(path);

            cmbRepo.Items.Clear();
            selectedPath = "";

            for (int x = 0; x < subdirectoryEntries.Length; x++)
            {
                //Ignoring OUTPUT folder
                if (!subdirectoryEntries[x].ToString().Contains("OUTPUT"))
                {
                    DirectoryInfo dir_info = new DirectoryInfo(subdirectoryEntries[x]);
                    string directory = dir_info.Name;
                    cmbRepo.Items.Add(directory);
                }
            }

            //Select the folder if only 1, otherwise ask 
            if (cmbRepo.Items.Count == 1)
                cmbRepo.SelectedIndex = 0;
            else
                cmbRepo.Text = "<Select a folder>";

            Cursor.Current = Cursors.Default;
        }

        private void dgvFolders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayIcons(zoomLvl);
        }

        //Populate all available icons in the grid
        public void DisplayIcons(decimal zoom)
        {
            //Change Image Layout depending on folder selection
            DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dgvIconList.Columns[0];
            dgvIconList.RowTemplate.Height = Convert.ToInt32(256 * zoom);

            if (cmbSubfolders.SelectedItem.ToString() == "Vertical")
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imgCol.Width = Convert.ToInt32(155 * zoom);
            }
            else if (cmbSubfolders.SelectedItem.ToString() == "Horizontal")
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imgCol.Width = Convert.ToInt32(397 * zoom);
            }
            else
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.Width = Convert.ToInt32(256 * zoom);
            }

            iconFolder = subPath + "\\" + dgvFolders.SelectedCells[0].Value;

            dgvIconList.AllowUserToAddRows = true;
            dgvIconList.Rows.Clear();
            dgvIconList.DataSource = null;

            string[] fileEntries = Directory.GetFiles(iconFolder);

            for (int x = 0; x < fileEntries.Length; x++)
            {
                DirectoryInfo dir_info = new DirectoryInfo(fileEntries[x]);
                string fileName = dir_info.Name;

                if (fileName.Contains(".jpg"))
                {
                    //Break filename into name and title id
                    string[] splitFileName = fileName.Split('[', ']');
                    if (splitFileName.Length == 1)
                    {
                        Array.Resize(ref splitFileName, 2);
                        splitFileName[2 - 1] = "0";   //Missing Title ID
                    }

                    //Insert row into DataGridView
                    DataGridViewRow row = (DataGridViewRow)dgvIconList.Rows[0].Clone();
                    row.Cells[0].Value = Image.FromFile(dir_info.ToString());
                    row.Cells[1].Value = splitFileName[0].Replace('-', ' ').Trim(); //Game Name
                    row.Cells[2].Value = splitFileName[1]; //TitleID
                    row.Cells[3].Value = dir_info;
                    dgvIconList.Rows.Insert(dgvIconList.Rows.Count - 1, row);
                }
            }
            dgvIconList.AllowUserToAddRows = false;
        }

        //Icon Double Click = Copy to OUTPUT folder
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Copy current selected image
            string copyPath = dgvIconList.Rows[e.RowIndex].Cells[3].Value.ToString();
            string PastePath = path + "\\OUTPUT\\" + dgvIconList.Rows[e.RowIndex].Cells[2].Value.ToString();
            Directory.CreateDirectory(PastePath);
            //Paste & Rename @ ..\OUTPUT\{Title ID}\icon.jpg
            File.Copy(copyPath, PastePath + "\\icon.jpg", true);
            //Add Name to dgvQueue
            dgvQueue.Rows.Add(dgvIconList.Rows[e.RowIndex].Cells[1].Value);
        }

        private void cmbRepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateIconStyle();
        }

        //Drop Down for selecting style (Horizontal, Vertical, etc)
        public void GenerateIconStyle()
        {
            dgvFolders.DataSource = null;
            dgvFolders.Rows.Clear();
            cmbSubfolders.Items.Clear();
            selectedPath = path + "\\" + cmbRepo.SelectedItem;
            string[] subdirectoryEntries = Directory.GetDirectories(selectedPath);

            for (int x = 0; x < subdirectoryEntries.Length; x++)
            {
                DirectoryInfo dir_info = new DirectoryInfo(subdirectoryEntries[x]);
                string directory = dir_info.Name;
                //Ignore folders starting with . (i.e. .git)
                if (directory.Substring(0, 1) != ".")
                    cmbSubfolders.Items.Add(directory);
            }

            if (cmbSubfolders.Items.Count == 1)
                cmbSubfolders.SelectedIndex = 0;
            else
                cmbSubfolders.Text = "<Select a folder>";
        }

        private void cmbSubfolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateSubFolders();
        }

        //Sub Folder selection
        public void GenerateSubFolders()
        {
            dgvFolders.DataSource = null;
            dgvFolders.Rows.Clear();

            subPath = selectedPath + "\\" + cmbSubfolders.SelectedItem;
            string[] subdirectoryEntries = Directory.GetDirectories(subPath);
            for (int x = 0; x < subdirectoryEntries.Length; x++)
            {
                DirectoryInfo dir_info = new DirectoryInfo(subdirectoryEntries[x]);
                string subF = dir_info.Name;
                //Ignore folders starting with . (i.e. .git)
                if (subF.Substring(0, 1) != ".")
                {
                    dgvFolders.Rows.Add(subF);
                }
            }
        }

        //File > Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //About
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nintendo Switch - Game Icon Changer [NX-GIC]" +
                "\n\nCreated by github.com/hotshotz79");
        }

        //Transfer Button
        private void button1_Click(object sender, EventArgs e)
        {
            Transfer frmTrans = new Transfer();
            frmTrans.Show();
            //Refresh Queue
        }

        //Add New Button
        private void btnAddResize_Click(object sender, EventArgs e)
        {
            AddResize frmAdd = new AddResize();
            if (frmAdd.ShowDialog(this) == DialogResult.OK)
            {
                dgvQueue.Rows.Add(frmAdd.iconText);
                if (cmbSubfolders.SelectedIndex != -1)
                    GenerateSubFolders();
            }
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings frmSettings = new Settings();
            frmSettings.Show();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (dgvIconList.DataSource != null)
            {
                zoomLvl -= 0.25m;
                Properties.Settings.Default.ZoomLevel = zoomLvl;
                Properties.Settings.Default.Save();
                DisplayIcons(zoomLvl);
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (dgvIconList.DataSource != null)
            {
                zoomLvl += 0.25m;
                Properties.Settings.Default.ZoomLevel = zoomLvl;
                Properties.Settings.Default.Save();
                DisplayIcons(zoomLvl);
            }
        }
    }
}
