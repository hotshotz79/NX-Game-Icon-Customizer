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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
