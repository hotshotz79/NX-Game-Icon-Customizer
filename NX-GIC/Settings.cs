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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.GitHubs = textBox1.Text.Replace("\r\n", ";");
            Properties.Settings.Default.TitleDB = textBox2.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
