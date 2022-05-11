using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Net.Http.Headers;

namespace NX_GIC
{
    public partial class AddResize : Form
    {
        public Image saveImage = new Bitmap(256, 256);
        public string iconText = "";
        public string iconID = "";
        public int SteamGridGameID = 0;
        public string SteamGridAPI = Properties.Settings.Default.SGDBapi;
        public string[,] gameNameID;
        string csvPath = Properties.Settings.Default.csvInstalled;
        public int selectedGameID = 0;
        public AddResize()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult imageFile = ofdImage.ShowDialog();

            if (imageFile == DialogResult.OK)
            {
                string file = ofdImage.FileName;
                txtName.Text = Path.GetFileName(ofdImage.FileName).Replace(".jpg","").Replace("-", " ");
                Image imgSelected = Image.FromFile(file);
                picPreview.Image = ResizeImage(imgSelected);
            }
        }

        private void btnUrl_Click(object sender, EventArgs e)
        {
            GetURL frmUrl = new GetURL();
            if (frmUrl.ShowDialog(this) == DialogResult.OK)
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                | SecurityProtocolType.Tls11
                | SecurityProtocolType.Tls12
                | SecurityProtocolType.Ssl3;
                Uri uri = new Uri(frmUrl.urlEntered); 
                txtName.Text = Path.GetFileName(uri.LocalPath).Replace(".jpg","").Replace("-", " ");
                var request = WebRequest.Create(uri);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    Image imgSelected = Bitmap.FromStream(stream);
                    picPreview.Image = ResizeImage(imgSelected);
                }
            }
            else
            {
                //Do Nothing
            }
            frmUrl.Dispose();
        }

        public Bitmap ResizeImage(Image image)
        {
            var destRect = new Rectangle(0, 0, 256, 256);
            var destImage = new Bitmap(256, 256);
            
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }

            }
            return destImage;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clear Image / Name / Title ID
            picPreview.Image = null;
            txtName.Text = "";
            txtTitle.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.TextLength != 16)
            {
                MessageBox.Show("Title ID needs to be exactly 16 characters", "Incorrect Title ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!radHori.Checked && !radVert.Checked && !radDefault.Checked)
            {
                MessageBox.Show("Select one of the dimension categories to determine which folder " +
                    "this icon will be stored under");
                return;
            }

            string iconType = "";
                if (radHori.Checked) { iconType = "Horizontal"; }
                else if (radVert.Checked) { iconType = "Vertical"; }
                else if (radDefault.Checked) { iconType = "Default"; }
            string saveAs = "";
            string pathOut = Directory.GetCurrentDirectory() + @"\Output\" + txtTitle.Text + @"\";
            string pathMain = Directory.GetCurrentDirectory() + @"\Main\" + iconType +
            @"\" + txtName.Text.Substring(0, 1) + @"\";
            
            // A very weird way to determine the icon #... but it works
            // loop upto 20 times to see if file name exist (icon1,icon2,etc)
            for (int x = 1; x <= 20; x++) {
                saveAs = txtName.Text.Replace(" ", "-") + "-" + x + "-[" + txtTitle.Text + "].jpg";
                if (!File.Exists(pathMain + saveAs))
                    break;  //Stop loop here and use filename
            }
            
            //Image Settings
            ImageCodecInfo codec = ImageCodecInfo.GetImageEncoders().First(c => c.MimeType == "image/jpeg");

            EncoderParameters parameters = new EncoderParameters(3);
            parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
            parameters.Param[1] = new EncoderParameter(System.Drawing.Imaging.Encoder.ScanMethod, (int)EncoderValue.ScanMethodNonInterlaced);
            parameters.Param[2] = new EncoderParameter(System.Drawing.Imaging.Encoder.RenderMethod, (int)EncoderValue.RenderNonProgressive);

            //Create folder
            Directory.CreateDirectory(pathOut);
            Directory.CreateDirectory(pathMain);

            //Save the preview under Output/Queue as well as copy under Main
            picPreview.Image.Save(pathOut + "icon.jpg", codec, parameters);
            picPreview.Image.Save(pathMain + saveAs, codec, parameters);
            iconText = txtName.Text;
            iconID = txtTitle.Text;
            //ToDo: Check if icon was under 120KB
            //If so, retry with Encoder.Quality @ 95L
        }

        private void radVert_CheckedChanged(object sender, EventArgs e)
        {
            if (radVert.Checked)
            {
                picPreview.Location = new Point(108, 175);
                picPreview.Size = new Size(103, 156);
                picTheme.Image = Properties.Resources.vertical_bg;
            }
        }

        private void radHori_CheckedChanged(object sender, EventArgs e)
        {
            if (radHori.Checked)
            {
                picPreview.Location = new Point(25, 146);
                picPreview.Size = new Size(202, 128);
                picTheme.Image = Properties.Resources.Horizontal;
            }
        }

        private void radDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (radDefault.Checked)
            {
                picPreview.Location = new Point(73, 186);
                picPreview.Size = new Size(130, 130);
                picTheme.Image = Properties.Resources.Default;
            }
        }

        private void AddResize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        //Search Button - Find lists of all games with their IDs
        private void button1_Click(object sender, EventArgs e)
        {
            if (SteamGridAPI == "")
            {
                MessageBox.Show("Please enter your SteamGridDB API key into NX-GIC Settings first", "Key Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tableLayoutPanel1.Controls.Clear();
            if (txt_gameLookup.Text == "")
                MessageBox.Show("Please enter a game name", "Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                GetGameIDs(txt_gameLookup.Text);
        }

        private async void GetGameIDs(string GameLookUp)
        {
            var httpClient2 = new HttpClient();
            var tokenKey = SteamGridAPI;
            string URL = "https://www.steamgriddb.com/api/v2";
            string urlParameters = "/search/autocomplete/" + txt_gameLookup.Text.Replace(' ', '+');

            httpClient2.BaseAddress = new Uri(URL);
            httpClient2.DefaultRequestHeaders.Accept.Clear();
            httpClient2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenKey);

            HttpResponseMessage response = await httpClient2.GetAsync(URL+urlParameters);

            string responseBody = await response.Content.ReadAsStringAsync();

            JObject getResult = JObject.Parse(responseBody);

            // get JSON result objects into a list
            IList<JToken> results = getResult["data"].Children().ToList();
            
            cmbGameList.Items.Clear();
            
            if (results.Count > 0)
            {
                cmbGameList.Enabled = true;
                cmbGameList.Text = "<Select a Game>";
                // serialize JSON results into .NET objects
                IList<SearchResult> searchResults = new List<SearchResult>();
                gameNameID = new string[searchResults.Count, 2];
                
                gameNameID = new string[results.Count, 2];
                for (int x = 0; x < results.Count; x++)
                {
                    gameNameID[x, 0] = results[x].ToObject<SearchResult>().Name;
                    gameNameID[x, 1] = results[x].ToObject<SearchResult>().Id;
                    cmbGameList.Items.Add(results[x].ToObject<SearchResult>().Name);
                }
                cmbGameList.Sorted = true;
            }
            else
            {
                cmbGameList.Text = "No Match Found";
                cmbGameList.Enabled = false;
                cmbSize.Enabled = false;
                button2.Enabled = false;
            }
            
            //Console.WriteLine(searchResults.Count);
            Console.WriteLine("Break");
        }

        private async void GetImages(int GameID)
        {
            int resultFound = 0;
            var httpClient2 = new HttpClient();
            var tokenKey = SteamGridAPI;
            string URL = "https://www.steamgriddb.com/api/v2";

            //Parameter dependant on image/style selected (default by grid)
            /* 
                0 ---GRID (All Style)---
                1 Any Size
                2 1:1 Square -512x512
                3 1:1 Square -1024x1024
                4 2:3 Vertical -600x900
                5 92:43 Horizontal -460x215
                6 92:43 Horizontal -920x430
                7 
                8 ---ICON (Square)---
                9 ---HERO (Widescreen)---
                10 ---LOGO (Horizontal)---
             */
            string urlParameters = "/grids/game/";
            if (cmbSize.SelectedIndex == 8)
                urlParameters = "/icons/game/";
            else if (cmbSize.SelectedIndex == 9)
                urlParameters = "/heroes/game/";
            else if (cmbSize.SelectedIndex == 10)
                urlParameters = "/logos/game/";
            else if (cmbSize.SelectedIndex == 0 || cmbSize.SelectedIndex == 7)
            {
                MessageBox.Show("Invalid Image Size selection, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            urlParameters = urlParameters + GameID;

            tableLayoutPanel1.Controls.Clear();

            httpClient2.BaseAddress = new Uri(URL);
            httpClient2.DefaultRequestHeaders.Accept.Clear();
            httpClient2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenKey);

            HttpResponseMessage response = await httpClient2.GetAsync(URL+urlParameters);

            string responseBody = await response.Content.ReadAsStringAsync();
            
            JObject getResult = JObject.Parse(responseBody);

            // get JSON result objects into a list
            IList<JToken> results = getResult["data"].Children().ToList();

            // serialize JSON results into .NET objects
            IList<SearchResult> searchResults = new List<SearchResult>();
            string selectedSize = cmbSize.Text.Substring(cmbSize.Text.IndexOf('-')+1);
            foreach (JToken result in results)
            {
                // JToken.ToObject is a helper method that uses JsonSerializer internally
                SearchResult searchResult = result.ToObject<SearchResult>();
                searchResults.Add(searchResult);

                //Populate Table grid with Thumbnails
                //var imageStream = HttpWebRequest.Create(searchResult.Thumb).GetResponse().GetResponseStream();
                var resultSize = searchResult.Width + "x" + searchResult.Height;
                //Add PictureBox
                if (selectedSize == resultSize || selectedSize == "Any Size")
                {
                    PictureBox pbIcon = new PictureBox();
                    //pbIcon.Image = Image.FromStream(imageStream);
                    pbIcon.Name = searchResult.Id;
                    pbIcon.Tag = "Tag" + searchResult.Id;
                    pbIcon.ImageLocation = searchResult.Url;
                    pbIcon.Size = new Size(600, 900);
                    pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
                    pbIcon.DoubleClick += new EventHandler(this.iconClicked);
                    pbIcon.Padding = new Padding(0);
                    pbIcon.Margin = new Padding(0);
                    tableLayoutPanel1.Controls.Add(pbIcon, 0, 0);
                    resultFound++;
                }
            }
            if (resultFound == 0)
                MessageBox.Show("No records found, please try another size or game", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public class SearchResult
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Thumb { get; set; }
            public string Url { get; set; }
            public string Width { get; set; }
            public string Height { get; set; }
        }
        private void iconClicked(object sender, EventArgs e)
        {

            PictureBox pb = (PictureBox)sender;

            //Swap to theme/icon preview
            radManual.Checked = true;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                | SecurityProtocolType.Tls11
                | SecurityProtocolType.Tls12
                | SecurityProtocolType.Ssl3;
            Uri uri = new Uri(pb.ImageLocation.ToString());
            txtName.Text = "GameName"; //textBox1.Text;
            var request = WebRequest.Create(uri);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                Image imgSelected = Bitmap.FromStream(stream);
                picPreview.Image = ResizeImage(imgSelected);
            }
            txtName.Text = Regex.Replace(cmbGameList.SelectedItem.ToString(), @"[^0-9a-zA-Z ]+", "") ;
        }

        private void radManual_CheckedChanged(object sender, EventArgs e)
        {
            searchPanel.Visible = false;
            searchPanel.BringToFront();
        }

        private void radOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SGDBapi == "")
                MessageBox.Show("SteamGridDB API key is required in order to search the database.\n\nFollow these steps to setup SGDB API key:\n" +
                    "1. Go to https://www.steamgriddb.com/login\n2. Click Login via Steam button, and sign in using your Steam Account\n3. Click API tab to generate a key and copy it\n" +
                    "4. Under NX-GIC Settings, paste your API Key and hit save then Restart", 
                    "API Key required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            searchPanel.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==  (char)13)
            button1_Click(sender, e);
        }

        private void cmbGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGameID = 0;
            for (int i = 0; i < gameNameID.GetLength(0); i++)
            {
                if (cmbGameList.SelectedItem.Equals(gameNameID[i,0]))
                {
                    selectedGameID = Convert.ToInt32(gameNameID[i, 1].ToString());
                }
            }
            cmbSize.Enabled = true;
            button2.Enabled = true;
            cmbSize.Text = "<Select image size>";
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Do Nothin   
        }

        private void txt_gameLookup_Click(object sender, EventArgs e)
        {
            txt_gameLookup.Text = "";
            txt_gameLookup.ForeColor = Color.Black;
            cmbGameList.Items.Clear();
            cmbGameList.Enabled = false;
            cmbSize.Enabled = false;
            button2.Enabled = false;
        }

        //Pull Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbSize.SelectedItem.ToString() == "<Select image size>")
                MessageBox.Show("Please select an image size", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                GetImages(selectedGameID);
        }

        //Find button - Displays a drop down to pick between CSV or JSON
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length < 3)
            {
                MessageBox.Show("Too few characters, Minimum 3 required", "Character Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            contextMenuStrip1.Show(button3, new Point(0, button3.Height));
        }

        //Find via CSV
        private void stripBtn_Titles_Click(object sender, EventArgs e)
        {
            //Check and Load CSV
            if (Properties.Settings.Default.csvInstalled == "")
                if (!csvCheck())
                    return;
            csvLoad();
        }

        //Find via JSON
        private void stripBtn_Json_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //Grab the JSON, Offline = local file, Online = http link
            string jsonResult = "";
            if (Properties.Settings.Default.OfflineStatus)
            {
                //Pop up browse dialog
                openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog1.Title = "Browse Title ID file";
                openFileDialog1.DefaultExt = "json";
                openFileDialog1.Filter = "json file (*.json)|*.json";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    jsonResult = new StreamReader(openFileDialog1.FileName).ReadToEnd();
                }
            }
            else
            {
                WebClient webClient = new WebClient();
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                //Json Source: github.com/blawar/titledb
                jsonResult = webClient.DownloadString(Properties.Settings.Default.TitleDB);
            }

            //Attempt to Look for Title ID
            int resultCount = 0;
            List<string> titleIDs = new List<string>();
            var obj = JObject.Parse(jsonResult);

            DataTable dtTids = new DataTable();
            dtTids.Columns.Add("Title ID", typeof(string));
            dtTids.Columns.Add("Name", typeof(string));

            foreach (JProperty x in (JToken)obj)
            {
                IList<JToken> tokenResults = x.Children().ToList();
                foreach (JToken k in tokenResults)
                {
                    SearchResult searchResult = k.ToObject<SearchResult>();
                    //searchResults.Add(searchResult);
                    if (searchResult.Name != null && searchResult.Id != null)
                    {
                        searchResult.Name = Regex.Replace(searchResult.Name.ToString(), @"[^0-9a-zA-Z ]+", "");
                        if (searchResult.Name.ToUpper().Contains(txtName.Text.ToUpper()))
                        {
                            titleIDs.Add(searchResult.Id);
                            dtTids.Rows.Add(searchResult.Id, searchResult.Name);
                            resultCount++;
                        }
                    }
                }
            }
            if (resultCount == 0)
            {
                MessageBox.Show("No Title ID found for '" + txtName.Text + "'");
            }
            //else if (resultCount == 1)
            //{
            //    txtTitle.Text = titleIDs[0].ToString();
            //}
            else //if 2 or more results found
            {
                TitleIDSelect frmTid = new TitleIDSelect(dtTids);
                if (frmTid.ShowDialog(this) == DialogResult.OK)
                {
                    txtTitle.Text = frmTid.selectedID;
                    txtName.Text = frmTid.selectedName;
                }
            }

            Cursor.Current = Cursors.Default;
        }

        public bool csvCheck()
        {
            string path = Directory.GetCurrentDirectory();
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
            DataTable dtCSV = new DataTable();
            dtCSV.Columns.Add("Title ID", typeof(string));
            dtCSV.Columns.Add("Name", typeof(string));

            using (StreamReader sr = new StreamReader(Properties.Settings.Default.csvInstalled))
            {
                while (!sr.EndOfStream)
                {
                    //Read CSV and split into 2 columns (id/name)
                    string[] rows = sr.ReadLine().Split('|');

                    //if not a blank name (usually last line)
                    if (rows[0].ToString() != "")
                    {
                        rows[1] = Regex.Replace(rows[1].ToString(), @"[^0-9a-zA-Z ]+", "");
                        //if game name contains entered text
                        if (rows[1].ToString().ToUpper().Contains(txtName.Text.ToUpper()))
                        {
                            dtCSV.Rows.Add(rows[0].ToString(), rows[1].ToString());
                        }
                    }
                }
            }
            
            if (dtCSV.Rows.Count == 0)
            {
                MessageBox.Show("No Title ID found for '" + txtName.Text + "'");
            }
            //else if (dtCSV.Rows.Count == 1)
            //{
            //    txtTitle.Text = dtCSV.Rows[0][0].ToString();
            //}
            else //if 2 or more results found
            {
                TitleIDSelect frmTid = new TitleIDSelect(dtCSV);
                if (frmTid.ShowDialog(this) == DialogResult.OK)
                {
                    txtTitle.Text = frmTid.selectedID;
                    txtName.Text = frmTid.selectedName;
                }
            }

        }
    }
}
