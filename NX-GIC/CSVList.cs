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
    public partial class CSVList : Form
    {
        public CSVList(DataTable dt)
        {
            InitializeComponent();

            dgvList.DataSource = dt;
            dgvList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
