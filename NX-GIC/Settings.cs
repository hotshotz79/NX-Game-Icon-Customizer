using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NX_GIC
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.GitHubs.Replace(";", "\r\n");
            textBox2.Text = Properties.Settings.Default.TitleDB;
            txtSwitchIP.Text = Properties.Settings.Default.IPAddress;
            txtCsv.Text = Properties.Settings.Default.csvInstalled;
            if (txtCsv.Text.Length > 0)
                btnDelCsvPath.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.GitHubs = textBox1.Text.Replace("\r\n", ";");
            Properties.Settings.Default.TitleDB = textBox2.Text;
            Properties.Settings.Default.IPAddress = txtSwitchIP.Text;
            Properties.Settings.Default.csvInstalled = txtCsv.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelCsvPath_Click(object sender, EventArgs e)
        {
            DialogResult diaglogDel = MessageBox.Show("This will delete the current titles.csv saved under NX-GIC folder.\n\n" +
                "\nTo add a new .csv, Click the [Installed IDs] button from main screen", "Delete CSV",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (diaglogDel == DialogResult.OK)
            {
                System.IO.File.Delete(Properties.Settings.Default.csvInstalled);
                txtCsv.Text = "";
                Properties.Settings.Default.csvInstalled = "";
                Properties.Settings.Default.Save();
            }
        }
    }
}
