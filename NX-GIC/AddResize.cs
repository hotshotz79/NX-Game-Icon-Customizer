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

namespace NX_GIC
{
    public partial class AddResize : Form
    {
        public Image saveImage = new Bitmap(256, 256);
        public string iconText = "";
        public string iconID = "";

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
                picPreview.Location = new Point(100, 125);
                picPreview.Size = new Size(128, 214);
                picTheme.Image = Properties.Resources.Vertical;
            }
        }

        private void radHori_CheckedChanged(object sender, EventArgs e)
        {
            if (radHori.Checked)
            {
                picPreview.Location = new Point(25, 108);
                picPreview.Size = new Size(202, 128);
                picTheme.Image = Properties.Resources.Horizontal;
            }
        }

        private void radDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (radDefault.Checked)
            {
                picPreview.Location = new Point(70, 148);
                picPreview.Size = new Size(130, 130);
                picTheme.Image = Properties.Resources.Default;
            }
        }

        private void btnTitle_Click(object sender, EventArgs e)
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
            if (txtName.Text.Length < 4)
                MessageBox.Show("Too few characters");
            else
            {
                int resultCount = 0;
                List<string> titleIDs = new List<string>();
                var obj = JObject.Parse(jsonResult);

                foreach (JProperty x in (JToken)obj)
                {
                    string textJson = x.Value.ToString().ToUpper();
                    //Cut the text so search doesn't look up values under Description
                    if (textJson.Length > 100)
                        textJson = textJson.Substring(0, 100);

                    if (textJson.Contains(txtName.Text.ToUpper()))
                    {
                        titleIDs.Add(x.Name);
                        resultCount++;
                    }
                }
                if (resultCount == 0)
                {
                    MessageBox.Show("No Title ID found for '" + txtName.Text + "'");
                }
                else if (resultCount == 1)
                {
                    txtTitle.Text = titleIDs[0].ToString();
                }
                else //if 2 or more results found
                {
                    DataTable dtTids = new DataTable();
                    dtTids.Columns.Add("Title ID", typeof(string));
                    dtTids.Columns.Add("Name", typeof(string));

                    foreach (var id in titleIDs)
                    {
                        string gameName = (string)obj[id.ToString()]["name"];
                        dtTids.Rows.Add(id.ToString(), gameName);
                    }

                    TitleIDSelect frmTid = new TitleIDSelect(dtTids);
                    if (frmTid.ShowDialog(this) == DialogResult.OK)
                    {
                        txtTitle.Text = frmTid.selectedID;
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void AddResize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
