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
    public partial class TitleIDSelect : Form
    {
        public string selectedID = "";
        public TitleIDSelect(DataTable dtTids)
        {
            InitializeComponent();
            dataGridView1.DataSource = dtTids;
            dataGridView1.Columns[0].Width = 125;
            dataGridView1.Columns[1].Width = 350;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //grab [e.RowIndex][1]
            MakeSelection(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void MakeSelection(string id)
        {
            selectedID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OK button
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MakeSelection(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
        }

        private void TitleIDSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
