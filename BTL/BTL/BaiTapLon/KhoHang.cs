using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiTapLon
{
    public partial class Form_KhoHang : Form
    {
        public Form_KhoHang()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source = NQTHAI\SQLEXPRESS01; Initial Catalog = QLCH; Integrated Security = True";
        SqlConnection conn = null;
        SqlDataAdapter daKhoHang;
        DataTable dtKhoHang;
        int row;

        private void Form_KhoHang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
           
        }

        private void dtg_KhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void tP_CTKho_Click(object sender, EventArgs e)
        {

        }
    }
}
