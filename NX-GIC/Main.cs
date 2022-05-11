using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text.RegularExpressions;
using WinSCP;

namespace NX_GIC
{
    public partial class Main : Form
    {
        string localVer = "1.4.0";

        string path = Directory.GetCurrentDirectory();
        string selectedPath = "";
        string subPath = "";
        string iconFolder = "";
        string origTitleID = "";
        bool offlineMode = Properties.Settings.Default.OfflineStatus;
        bool moveFiles = false;
        bool gicMode = false;
        bool matchingDone = false;
        decimal zoomLvl = Properties.Settings.Default.ZoomLevel;
        string csvPath = Properties.Settings.Default.csvInstalled;
        DataTable dtCSV = new DataTable();

        public Main()
        {
            InitializeComponent();
            if (!offlineMode)
                VerCheck();
            else
                toolStripStatusLabel1.Text = "Offline";

            this.Text += " - v" + localVer;

            if (Directory.Exists(path + "\\Output"))
                Directory.Delete(path + "\\Output", true);
        }

        private async void VerCheck()
        {
            //Confirm Internet is working before checking for Updates
            try
            {
                using (var client = new WebClient())
                    using (client.OpenRead("http://google.com/generate_204"))
                        await VersionCheckAsync();
            }
            catch
            {
                //Do Nothing
            }
            
        }

        private async Task VersionCheckAsync()
        {
            GitHubClient client = new GitHubClient(new ProductHeaderValue("nxgic"));
            IReadOnlyList<Release> releases = await client.Repository.Release.GetAll("hotshotz79", "NX-Game-Icon-Customizer");
            Version latestGitHubVersion = new Version(releases[0].TagName);
            Version localVersion = new Version(localVer);

            int versionComparison = localVersion.CompareTo(latestGitHubVersion);
            if (versionComparison < 0)
            {
                DialogResult versionUpd = MessageBox.Show("A new version of NX-GIC is available, Click OK to go to GitHub Release page.\n\nPatch Notes " + releases[0].TagName + "\n\n" +
                    releases[0].Body, "Update Available", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (versionUpd == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("https://github.com/hotshotz79/NX-Game-Icon-Customizer/releases");
                }
            }
        }

        private async Task DownloadFromGitHubRepo()
        {
            toolStripStatusLabel1.Text = "Downloading...";
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 5;
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
                toolStripProgressBar1.Value = 10;
                string fileName = gitUserRepo[x][0] + "." + tags[0].Name + ".zip";

                //Download/Extract if new
                if (!File.Exists(path + @"\" + fileName))
                {
                    toolStripStatusLabel1.Text = "Extracting...";
                    toolStripProgressBar1.Value = 25;
                    //Download Latest Zip/Tag
                    using (var clientWeb = new WebClient())
                    {
                        clientWeb.Headers.Add("User-Agent: Other");
                        clientWeb.DownloadFile(tags[0].ZipballUrl, fileName);
                    }
                    toolStripProgressBar1.Value = 50;
                    //Extract zip file
                    ZipFile.ExtractToDirectory(fileName, path);
                    toolStripStatusLabel1.Text = "Organizing Folders...";
                    toolStripProgressBar1.Value = 75;
                    //Delete the zip file to save space
                    File.Delete(path + @"\" + fileName);
                    //Then generate a dummy file for Version check purposes
                    File.Create(path + @"\" + fileName);
                    moveFiles = true;

                    //Delete previous zip file(s)
                    DirectoryInfo di = new DirectoryInfo(path);
                    FileInfo[] ZipFiles = di.GetFiles(gitUserRepo[x][0] + "*.zip");
                    foreach (var fi in ZipFiles)
                    {
                        if (fi.Name != fileName)
                            File.Delete(path + @"\" + fi.Name);
                    }
                    toolStripStatusLabel1.Text = "Clean up...";
                    toolStripProgressBar1.Value = 90;
                }
            }

            string[] subdirectoryEntries = Directory.GetDirectories(path);
            for (int x = 0; x < subdirectoryEntries.Length; x++)
            {
                // Move Extracted folders into MAIN\
                if (moveFiles)
                {
                    if (!subdirectoryEntries[x].ToString().Contains("Output") &&
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
            toolStripProgressBar1.Value = 100;
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel1.Text = "Ready";
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
            //Create Main & Output folder if it doesn't exist
            if (Directory.Exists(path + "\\Output")) Directory.CreateDirectory(path + "\\Output");
            if (!Directory.Exists(path + "\\Main")) Directory.CreateDirectory(path + "\\Main");

            //Check updates and download icons from Github
            if (!offlineMode)
            {
                MessageBox.Show("Now downloading from GitHub Repo... this can take a few minutes", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                await DownloadFromGitHubRepo();
            }

            //Get list of all existing folders
            string[] subdirectoryEntries = Directory.GetDirectories(path);

            cmbRepo.Items.Clear();
            selectedPath = "";

            for (int x = 0; x < subdirectoryEntries.Length; x++)
            {
                //Ignoring OUTPUT folder
                if (!subdirectoryEntries[x].ToString().Contains("Output"))
                {
                    DirectoryInfo dir_info = new DirectoryInfo(subdirectoryEntries[x]);
                    string directory = dir_info.Name;
                    cmbRepo.Items.Add(directory);
                }
            }

            //Select the folder if only 1, otherwise ask 
            /*if (cmbRepo.Items.Count == 1)
                cmbRepo.SelectedIndex = 0;
            else
                cmbRepo.Text = "<Select a folder>";*/

            cmbRepo.SelectedItem = "Main";
            Cursor.Current = Cursors.Default;
        }

        private void dgvFolders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayIcons(zoomLvl);
        }

        //Populate all available icons in the grid
        public void DisplayIcons(decimal zoom)
        {
            //Set the Icon Size
            int iconSize = 0;
            if (cmbSubfolders.SelectedItem.ToString() == "Vertical")
                iconSize = Convert.ToInt32(155 * zoom);
            else if (cmbSubfolders.SelectedItem.ToString() == "Horizontal")
                iconSize = Convert.ToInt32(397 * zoom);
            else
                iconSize = Convert.ToInt32(256 * zoom);

            iconFolder = subPath + "\\" + dgvFolders.SelectedCells[0].Value;

            flowIcons.Controls.Clear();

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

                    if (showIconsForInstalledGamesOnlyToolStripMenuItem.Checked)
                    {
                        foreach (DataRow csvRow in dtCSV.Rows)
                        {
                            Console.WriteLine(csvRow.ItemArray[0]);

                            if (splitFileName[1].ToString() == csvRow.ItemArray[0].ToString())
                            {
                                PictureBox pbIcon = new PictureBox();
                                pbIcon.ImageLocation = dir_info.ToString();
                                pbIcon.Name = splitFileName[0].Replace('-', ' ').Trim();
                                pbIcon.Tag = splitFileName[1];
                                pbIcon.Size = new Size(iconSize, Convert.ToInt32(256 * zoom));
                                pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                                pbIcon.DoubleClick += new EventHandler(this.iconClicked);
                                flowIcons.Controls.Add(pbIcon);
                                break;
                            }
                            
                        }
                    }
                    else
                    {
                        //Populate the Flow Panel
                        PictureBox pbIcon = new PictureBox();
                        pbIcon.ImageLocation = dir_info.ToString();
                        pbIcon.Name = splitFileName[0].Replace('-', ' ').Trim();
                        pbIcon.Tag = splitFileName[1];
                        pbIcon.Size = new Size(iconSize, Convert.ToInt32(256 * zoom));
                        pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbIcon.DoubleClick += new EventHandler(this.iconClicked);
                        flowIcons.Controls.Add(pbIcon);
                    }
                }
            }
        }

        //When a picture is double clicked
        void iconClicked(object sender, EventArgs e)
        {
            //if via Google Search
                //Do this
            //else
            PictureBox pb = (PictureBox)sender;

            string copyPath = pb.ImageLocation.ToString();
            string pastePath = path + "\\Output\\" + pb.Tag.ToString();
            Directory.CreateDirectory(pastePath);
            //Paste & Rename @ ..\Output\{Title ID}\icon.jpg
            File.Copy(copyPath, pastePath + "\\icon.jpg", true);

            AddtoQueue(pb.Name, pb.Tag.ToString());
        }

        public void AddtoQueue (string iconName, string titleID)
        {
            //Check if same another icon exist for same title id
            for (int x = 0; x < dgvQueue.Rows.Count; x++)
            {
                if (dgvQueue.Rows[x].Cells[1].Value.ToString() == titleID.ToString())
                {
                    dgvQueue.Rows.RemoveAt(x);
                }
            }

            //Add Name to dgvQueue
            dgvQueue.Rows.Add(iconName, titleID);
        }

        private void cmbRepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateFolderStyles();
        }

        //Drop Down for selecting style (Horizontal, Vertical, etc)
        public void GenerateFolderStyles()
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
                //Ignore folders starting with . (i.e. .git) and exclude Themes folder
                //if (directory.Substring(0, 1) != "." &&
                    //!directory.ToUpper().Contains("THEME"))
                if (directory.Contains("Default") || directory.Contains("Horizontal") || directory.Contains("Vertical"))
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

        //Generate sub folders (A-Z)
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
            About frmAbout = new About();
            frmAbout.ShowDialog();
        }

        //Transfer Button
        private void button1_Click(object sender, EventArgs e)
        {
            Transfer frmTrans = new Transfer();
            frmTrans.ShowDialog();
            //Clear Queue
            if (frmTrans.statusSuccess)
            {
                dgvQueue.DataSource = null;
                dgvQueue.Rows.Clear();
            }
        }

        //Add New Button
        private void btnAddResize_Click(object sender, EventArgs e)
        {
            AddResize frmAdd = new AddResize();
            if (frmAdd.ShowDialog(this) == DialogResult.OK)
            {
                //dgvQueue.Rows.Add(frmAdd.iconText, frmAdd.iconID);
                AddtoQueue(frmAdd.iconText, frmAdd.iconID);
                if (cmbSubfolders.SelectedIndex != -1)
                    GenerateSubFolders();
            }
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings frmSettings = new Settings();
            frmSettings.ShowDialog();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (flowIcons.Controls.Count > 0)
            {
                zoomLvl -= 0.25m;
                Properties.Settings.Default.ZoomLevel = zoomLvl;
                Properties.Settings.Default.Save();
                DisplayIcons(zoomLvl);
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (flowIcons.Controls.Count > 0)
            {
                zoomLvl += 0.25m;
                Properties.Settings.Default.ZoomLevel = zoomLvl;
                Properties.Settings.Default.Save();
                DisplayIcons(zoomLvl);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/hotshotz79/NX-Game-Icon-Customizer/wiki");
        }

        //Change status to stay Offline
        private void goOfflineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!goOfflineToolStripMenuItem.Checked)
            {
                DialogResult modeResult = MessageBox.Show("Change working mode to Offline?\n\nNote: If you wish to view pre-made custom icons, you will need to be manually download and extract Icon Repository(s)" +
                      "\nTitle ID database will also need to be downloaded seperately in order to automatically find IDs for games",
                      "Mode Change",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (modeResult == DialogResult.OK)
                {
                    goOfflineToolStripMenuItem.Checked = true;
                    offlineMode = true;
                    toolStripStatusLabel1.Text = "Offline";
                    Properties.Settings.Default.OfflineStatus = true;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                goOfflineToolStripMenuItem.Checked = false;
                offlineMode = false;
                toolStripStatusLabel1.Text = "";
                Properties.Settings.Default.OfflineStatus = false;
                Properties.Settings.Default.Save();
            }

        }

        //Queue | Output - Buttons
        private void dgvQueue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexView = dgvQueue.Columns[5].Index;
            int indexDel = dgvQueue.Columns[6].Index;
            string titleID = "";

            //Seperate the Title IDs (Original and Modified)
            if (e.RowIndex >= 0)
            {
                origTitleID = dgvQueue.Rows[e.RowIndex].Cells[1].Value.ToString();
                titleID = dgvQueue.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

            //View Button - Open icon in default picture viewer
            if (e.ColumnIndex == indexView && e.RowIndex >= 0)
                System.Diagnostics.Process.Start(path + @"\Output\" + titleID + @"\icon.jpg");

            //Delete Button - Remove the selected icon
            if (e.ColumnIndex == indexDel && e.RowIndex >= 0)
            {
                Directory.Delete(path + @"\Output\" + titleID, true);
                dgvQueue.Rows.RemoveAt(e.RowIndex);
            }
        }

        //Queue - Title ID Change
        private void dgvQueue_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int indexTid = dgvQueue.Columns[1].Index;
            int indexTname = dgvQueue.Columns[2].Index;
            int indexAuthor = dgvQueue.Columns[3].Index;
            int indexVer = dgvQueue.Columns[4].Index;

            string titleID = dgvQueue.Rows[e.RowIndex].Cells[1].Value.ToString();

            //Title ID Change
            if (e.ColumnIndex == indexTid && e.RowIndex >= 0)
            {
                if (titleID.Length != 16)
                {
                    MessageBox.Show("Title ID needs to be exactly 16 characters", "Incorrect Title ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvQueue.Rows[e.RowIndex].Cells[1].Value = origTitleID;
                    return;
                }
                else
                {
                    if (origTitleID != titleID)
                        Directory.Move(path + @"\Output\" + origTitleID, path + @"\Output\" + titleID);
                }
            }
            
            //CONFIG.INI SETUP
            string configFile = path + @"\Output\" + dgvQueue.Rows[e.RowIndex].Cells[1].Value.ToString() + @"\config.ini";
            string configFileTemp = path + @"\Output\" + dgvQueue.Rows[e.RowIndex].Cells[1].Value.ToString() + @"\config.txt";
            string customTitle = "";
            string customAuthor = "";
            string customVersion = "";
            if (dgvQueue.Rows[e.RowIndex].Cells[2].Value != null)
                customTitle = dgvQueue.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dgvQueue.Rows[e.RowIndex].Cells[3].Value != null)
                customAuthor = dgvQueue.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dgvQueue.Rows[e.RowIndex].Cells[4].Value != null)
                customVersion = dgvQueue.Rows[e.RowIndex].Cells[4].Value.ToString();

            //Create the ini
            if (!File.Exists(configFile))
            {
                using (StreamWriter sw = File.CreateText(configFile))
                {
                    sw.WriteLine("[override_nacp]");
                }
            }

            if (e.ColumnIndex == indexTname && e.RowIndex >= 0)
            {
                ConfigINI(configFile, configFileTemp, "name", customTitle);
            }
            if (e.ColumnIndex == indexAuthor && e.RowIndex >= 0)
            {
                ConfigINI(configFile, configFileTemp, "author", customAuthor);
            }
            if (e.ColumnIndex == indexVer && e.RowIndex >= 0)
            {
                if (customVersion.Length == 5 || customVersion.Length == 0)
                {
                    ConfigINI(configFile, configFileTemp, "display_version", customVersion);
                }
                else
                {
                    MessageBox.Show("Custom Version format needs to be #.#.#\n\nExample: 1.0.0", "Version Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvQueue.Rows[e.RowIndex].Cells[4].Value = "";
                    return;
                }
            }

            //If all 3 Custom fields are empty; Delete config.ini
            if (e.RowIndex >= 0) 
                if (customTitle == "" && customAuthor == "" && customVersion == "")
                    File.Delete(configFile);
        }

        //Generates the CONFIG.ini file for a title
        public void ConfigINI(string iniPath, string txtPath, string field, string value)
        {
            string line = null;
            string line_to_delete = field + "=";

            using (StreamReader reader = new StreamReader(iniPath))
            {
                //Write to new .txt file
                using (StreamWriter writer = new StreamWriter(txtPath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Copy from ini to txt if field doesn't exist
                        //if (String.Compare(line, line_to_delete) == -1)
                        if (!line.Contains(line_to_delete))
                            writer.WriteLine(line);
                    }
                    if (value != "")
                        writer.WriteLine(field + "=" + value);
                }
            }
            File.Delete(iniPath); //Delete .ini
            File.Move(txtPath, iniPath);  //Replace modifed .txt to .ini
        }

        private void showIconsForInstalledGamesOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!showIconsForInstalledGamesOnlyToolStripMenuItem.Checked)
            {
                if (Properties.Settings.Default.csvInstalled == "")
                    if (!csvCheck())
                        return;
                csvLoad();
                showIconsForInstalledGamesOnlyToolStripMenuItem.Checked = true;
            }
            else
                showIconsForInstalledGamesOnlyToolStripMenuItem.Checked = false;

            if (flowIcons.Controls.Count > 0)
                DisplayIcons(zoomLvl);
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sodasoba1.github.io/NSW-Custom-Game-Icons/");
        }

        public bool csvCheck()
        {
            DialogResult csvDialog = MessageBox.Show("Import Titles list (.csv)?",
                    "Set CSV Path",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (csvDialog == DialogResult.OK)
            {
                //Pop up browse dialog
                ofdCsv.InitialDirectory = Directory.GetCurrentDirectory();
                ofdCsv.Title = "Browse Titles CSV";
                ofdCsv.DefaultExt = "csv";
                ofdCsv.Filter = "csv file (*.csv)|*.csv";

                if (ofdCsv.ShowDialog() == DialogResult.OK)
                {
                    //If selected csv was in the previous saved path, do nothing
                    if (ofdCsv.FileName != csvPath)
                    {
                        //Copy where ever the file was found and save under nxGIC directory
                        File.Copy(ofdCsv.FileName, path + @"\titles" + DateTime.Now.ToString("MMddyyyy_HHmmss") + ".csv");
                    }
                    Properties.Settings.Default.csvInstalled = path + @"\titles" + DateTime.Now.ToString("MMddyyyy_HHmmss") + ".csv";
                    csvPath = path + @"\titles" + DateTime.Now.ToString("MMddyyyy_HHmmss") + ".csv";
                    Properties.Settings.Default.Save();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void csvLoad()
        {
            csvPath = Properties.Settings.Default.csvInstalled;
            dtCSV.Clear();
            dtCSV = new DataTable();
            using (StreamReader sr = new StreamReader(csvPath))
            {
                string[] headers = sr.ReadLine().Split('|');
                foreach (string header in headers)
                {
                    dtCSV.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split('|');
                    if (rows[0].ToString() != "")
                    {
                        DataRow dr = dtCSV.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i];
                        }
                        dtCSV.Rows.Add(dr);
                    }
                }
            }
            dgvInstalled.DataSource = null;
            dgvInstalled.Rows.Clear();
            dgvInstalled.Columns.Clear();
            dgvInstalled.DataSource = dtCSV;
            dgvInstalled.Columns.Add("Match", "Match");
            dgvInstalled.Columns.Add("Path", "Path");
            dgvInstalled.Columns["Path"].Visible = false;
            dgvInstalled.Columns[0].Width = 120;    //Title ID
            dgvInstalled.Columns[1].Width = 200;    //Title Name
            dgvInstalled.Columns["Match"].Width = 50;


            //DataGridViewButtonColumn btnAdd = new DataGridViewButtonColumn();
            DataGridViewImageColumn btnAdd = new DataGridViewImageColumn();
            dgvInstalled.Columns.Add(btnAdd);
            btnAdd.HeaderText = "Add";
            //btnAdd.Text = "+";
            btnAdd.Image = Properties.Resources.plus;
            btnAdd.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnAdd.Name = "btnAdd";
            btnAdd.DefaultCellStyle.SelectionBackColor = Color.White;
            //btnAdd.UseColumnTextForButtonValue = true;
            dgvInstalled.Columns["btnAdd"].Width = 35;

            //DataGridViewButtonColumn btnRem = new DataGridViewButtonColumn();
            DataGridViewImageColumn btnRem = new DataGridViewImageColumn();
            dgvInstalled.Columns.Add(btnRem);
            btnRem.HeaderText = "Skip";
            btnRem.Image = Properties.Resources.remove;
            btnRem.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //btnRem.Text = "X";
            btnRem.Name = "btnRem";
            btnRem.DefaultCellStyle.SelectionBackColor = Color.White;
            //btnRem.UseColumnTextForButtonValue = true;
            dgvInstalled.Columns["btnRem"].Width = 35;

            dgvInstalled.Sort(dgvInstalled.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
        }

        //Button: Auto GIC
        private void btnAutoGic_Click(object sender, EventArgs e)
        {
            //Auto GIC mode enabled
            if (!gicMode)
            {
                if (Properties.Settings.Default.csvInstalled == "")
                {
                    if (!csvCheck())
                        return;
                }
                csvLoad();
                dgvInstalled.Visible = true;
                flowIcons.Visible = false;
                dgvInstalled.Size = new Size(flowIcons.Size.Width + 82, flowIcons.Size.Height - 33);
                dgvInstalled.Location = new System.Drawing.Point(14, 97);
                btnAutoGic.BackColor = Color.SteelBlue;
                label2.Visible = false;
                cmbSubfolders.Visible = false;
                gicMode = true;
                btnAddtoOut.Visible = true;
                btnReloadCSV.Visible = true;
                cmbAutoStyle.Visible = true;
            }
            //Unclick Auto-GIC button
            else
            {
                dgvInstalled.Visible = false;
                flowIcons.Visible = true;
                btnAutoGic.BackColor = Color.FromName("Control");
                label2.Visible = true;
                cmbSubfolders.Visible = true;
                gicMode = false;
                btnAddtoOut.Visible = false;
                btnReloadCSV.Visible = false;
                cmbAutoStyle.Visible = false;
            }

            //Read all folders in Main directory
            string[] subdirectoryEntries = Directory.GetDirectories(path + @"\Main");

            //Populate Drop Down box for icon style
            if (subdirectoryEntries.Length > 0)
            {
                cmbAutoStyle.Items.Clear();
                cmbAutoStyle.Text = "<Select Icon Style>";
                for (int x = 0; x < subdirectoryEntries.Length; x++)
                {
                    DirectoryInfo dir_info = new DirectoryInfo(subdirectoryEntries[x]);
                    string directory = dir_info.Name;
                    //Ignore folders starting with . (i.e. .git) and exclude Themes folder
                    //if (directory.Substring(0, 1) != "." &&
                    //    !directory.ToUpper().Contains("THEME"))
                    //    cmbAutoStyle.Items.Add(directory);

                    if (directory.Contains("Default") || directory.Contains("Horizontal") || directory.Contains("Vertical"))
                        cmbAutoStyle.Items.Add(directory);
                }
            }
            else
            {
                MessageBox.Show("No icon folders found under Main directory\n\nRun Scan in Online mode to download icons first", "No Icons found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Find icons matching with titles.csv
        private void AutoGIC(string iconStyle)
        {

            foreach (DataGridViewRow row in dgvInstalled.Rows)
            {
                //Clear any previous matches
                row.Cells["Match"].Value = "";
                //Go through each folder in MAIN / <selected style> and check if match is found
                var iconArr = Directory.GetFiles(path + @"\Main\" + iconStyle, 
                    "*" + row.Cells["Title ID"].Value  + "*", SearchOption.AllDirectories);

                //randomly pick one from the array

                //Indicate if Match was Found
                if (iconArr.Length > 0)
                {
                    Random rand = new Random();
                    int randId = rand.Next(iconArr.Length);
                    row.Cells["Match"].Value = "Found";
                    //Add icon file path to a hidden column 
                    row.Cells["Path"].Value = iconArr[randId].ToString();
                }
            }

            matchingDone = true;
        }

        //Auto GIC - 1 Click to Add all Matched icons to Queue
        private void btnAddtoOut_Click(object sender, EventArgs e)
        {
            if (matchingDone)
            {
                foreach (DataGridViewRow row in dgvInstalled.Rows)
                {
                    if (row.Cells["Match"].Value.ToString() == "Found")
                    {
                        //Send to Queue
                        string copyPath = row.Cells["Path"].Value.ToString();
                        string PastePath = path + "\\Output\\" + row.Cells["Title ID"].Value.ToString();
                        Directory.CreateDirectory(PastePath);
                        //Paste & Rename @ ..\Output\{Title ID}\icon.jpg
                        File.Copy(copyPath, PastePath + "\\icon.jpg", true);
                        //Add Name to dgvQueue
                        //dgvQueue.Rows.Add(row.Cells["Title Name"].Value.ToString(),
                            //row.Cells["Title ID"].Value.ToString());
                        AddtoQueue(row.Cells["Title Name"].Value.ToString(),
                            row.Cells["Title ID"].Value.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("No matching was done, select an Icon Style from the drop down selection", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        //Pop up a form to display List of Title IDs and Name for reference only
        private void viewInstalledGamesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.csvInstalled == "")
            {
                if (!csvCheck())
                    return;
            }
            csvLoad();
            CSVList csvForm = new CSVList(dtCSV);
            csvForm.Show();
        }

        //Auto GIC - drop current titles.csv and import new one
        private void btnReloadCSV_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.csvInstalled = "";
            Properties.Settings.Default.Save();
            if (!csvCheck())
                return;
            csvLoad();
        }

        //Auto GIC - icon style changed
        private void cmbAutoStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddtoOut.Enabled = true;
            AutoGIC(cmbAutoStyle.SelectedItem.ToString());
        }

        private void dgvInstalled_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexAdd = dgvInstalled.Columns["btnAdd"].Index;
            int indexRem = dgvInstalled.Columns["btnRem"].Index;

            //Single add icon to Transfer Queue
            if (e.ColumnIndex == indexAdd && e.RowIndex >= 0)
            {
                if (!matchingDone)
                    MessageBox.Show("No matching was done, select an Icon Style from the drop down selection", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                {
                    //If there is no match found and Add (+) button is clicked
                    if (dgvInstalled.Rows[e.RowIndex].Cells["Match"].Value == null ||
                        dgvInstalled.Rows[e.RowIndex].Cells["Match"].Value == DBNull.Value || 
                        String.IsNullOrWhiteSpace(dgvInstalled.Rows[e.RowIndex].Cells["Match"].Value.ToString()))
                    {
                        Console.WriteLine("Match column value is NULL");
                        return;
                    }

                    //If match result is 'Found'
                    if (dgvInstalled.Rows[e.RowIndex].Cells["Match"].Value.ToString() == "Found")
                    {
                        //Send to Queue
                        string copyPath = dgvInstalled.Rows[e.RowIndex].Cells["Path"].Value.ToString();
                        string PastePath = path + "\\Output\\" + dgvInstalled.Rows[e.RowIndex].Cells["Title ID"].Value.ToString();
                        Directory.CreateDirectory(PastePath);
                        //Paste & Rename @ ..\Output\{Title ID}\icon.jpg
                        File.Copy(copyPath, PastePath + "\\icon.jpg", true);
                        //Add Name to dgvQueue
                        //dgvQueue.Rows.Add(dgvInstalled.Rows[e.RowIndex].Cells["Title Name"].Value.ToString(),
                            //dgvInstalled.Rows[e.RowIndex].Cells["Title ID"].Value.ToString());
                        AddtoQueue(dgvInstalled.Rows[e.RowIndex].Cells["Title Name"].Value.ToString(),
                            dgvInstalled.Rows[e.RowIndex].Cells["Title ID"].Value.ToString());
                    }
                }
            }
            //Remove record if X is clicked
            if (e.ColumnIndex == indexRem && e.RowIndex >= 0)
            {
                dgvInstalled.Rows.RemoveAt(e.RowIndex);
            }
        }

        //Install NX Titles List Dumper NRO
        private void installNXTitlesListDumperNROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NROInstall();
        }

        public void NROInstall()
        {
            DialogResult nroResult = MessageBox.Show("This function will automatically download & transfer NX Titles List Dumper (.nro) to your switch via FTP" +
            "\n\nPlease perform the following steps:" +
            "\n1. On your Switch, run FTP client" +
            "\n2. Confirm IP saved in NX GIC matches Switch's IP: " + Properties.Settings.Default.IPAddress +
            "\n3. If the IP Addresses do not match, click [Cancel] and update it under NX GIC > File > Settings" +
            "\n4. Click [Yes]" +
            "\n\nIf you like to do these steps manually, click [No] to navigate to NX TLD GitHub page",
            "Download & Install NX TLD", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (nroResult == DialogResult.Yes)
            {
                bool statusSuccess = false;
                
                using (var clientWeb = new WebClient())
                {
                    clientWeb.Headers.Add("User-Agent: Other");
                    clientWeb.DownloadFile("https://github.com/HamletDuFromage/nx-titles-list-dumper/releases/download/1.0.2/nx-titles-list-dumper.nro", 
                        "nx-titles-list-dumper.nro");
                }

                //FTP path + nro to IPAddress/switch/
                using (Session session = new Session())
                {
                    try
                    {
                        sessionOptions.HostName = Properties.Settings.Default.IPAddress;
                        // Connect
                        if (Properties.Settings.Default.FTPUser == "")
                            session.Open(blankSession);
                        else
                            session.Open(sessionOptions);
                        // Upload
                        Console.WriteLine(path+@"\nx-titles-list-dumper.nro");
                        session.PutFileToDirectory(path + @"\nx-titles-list-dumper.nro", "/switch/",false); //.Check();
                        statusSuccess = true;
                    }
                    catch (Exception err)
                    {
                        statusSuccess = false;
                        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //Ask user if they wish to load the CSV
                if (statusSuccess)
                {
                    DialogResult dlResult = MessageBox.Show("NRO successfully transfered, would you like to load Title IDs into NX GIC via FTP?", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dlResult == DialogResult.Yes)
                    {
                        ftpPullCSV();
                    }
                }
            }
            else if (nroResult == DialogResult.No)
            {
                System.Diagnostics.Process.Start("https://github.com/HamletDuFromage/nx-titles-list-dumper/releases");
            }
        }

        private void ftpPullCSV()
        {
            DialogResult csvPull = MessageBox.Show("This function will automatically download the dumped titles.csv from your Switch via FTP" +
                           "\n\nPlease perform the following steps:" +
                           "\n1. On your Switch, run NX Titles List Dumper (NRO)" +
                           "\n2. Press (A) button to generate the csv" +
                           "\n3. Close NRO and run FTP Client on your Switch" +
                           "\n4. Confirm NX GIC IP under settings (" + Properties.Settings.Default.IPAddress +") matches Switch's IP" + 
                           "\n5. Click [OK]",
                           "Download & Retrieve CSV", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            bool statusSuccess = false;
            if (csvPull == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                using (Session session = new Session())
                {
                    try
                    {
                        sessionOptions.HostName = Properties.Settings.Default.IPAddress;
                        // Connect
                        if (Properties.Settings.Default.FTPUser == "")
                            session.Open(blankSession);
                        else
                            session.Open(sessionOptions);
                        // Upload
                        session.GetFileToDirectory("/titles.csv", path, false);
                        // Add timestamp to csv file
                        FileInfo fi = new FileInfo(path+@"\titles.csv");
                        fi.MoveTo(path+@"/titles"+ DateTime.Now.ToString("MMddyyyy_HHmmss") + ".csv");
                        File.Delete(path+@"/titles.csv");
                        statusSuccess = true;
                    }
                    catch (Exception err)
                    {
                        statusSuccess = false;
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (statusSuccess)
                {
                    Properties.Settings.Default.csvInstalled = path + @"\titles" + DateTime.Now.ToString("MMddyyyy_HHmmss") + ".csv";
                    csvPath = path + @"\titles" + DateTime.Now.ToString("MMddyyyy_HHmmss") + ".csv";
                    Properties.Settings.Default.Save();

                    csvLoad();
                }
                Cursor.Current = Cursors.Default;
                MessageBox.Show("CSV Locked and Loaded", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Setup FTP session options
        SessionOptions sessionOptions = new SessionOptions
        {
            Protocol = Protocol.Ftp,
            HostName = Properties.Settings.Default.IPAddress,
            PortNumber = Properties.Settings.Default.FTPPort,
            UserName = Properties.Settings.Default.FTPUser,
            Password = Properties.Settings.Default.FTPPass,
        };

        SessionOptions blankSession = new SessionOptions
        {
            Protocol = Protocol.Ftp,
            HostName = Properties.Settings.Default.IPAddress,
            PortNumber = Properties.Settings.Default.FTPPort,
            UserName = " ",
            Password = "",
        };

        private void downloadTitlesCSVFTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftpPullCSV();
        }
    }
}
