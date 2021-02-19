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
    public partial class GetURL : Form
    {
        public string urlEntered;
        public GetURL()
        {
            InitializeComponent();

            txtUrl.Text = Clipboard.GetText();
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            urlEntered = txtUrl.Text;
        }
    }
}
