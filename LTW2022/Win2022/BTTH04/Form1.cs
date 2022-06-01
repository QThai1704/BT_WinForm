using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataTable dataTable = new DataTable();
        private void btThem_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add(tbHT.Text, tbMaSV.Text, dTNgaySinh.Text, rbt1.Text, rBt2.Text, cbBQueQuan.Text, cbBKhoa.Text, cbBLop.Text);
            dataGridView2.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
