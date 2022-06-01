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

namespace BTTH3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=NQTHAI\SQLEXPRESS01;Initial Catalog=THQLBanHang;Integrated Security=True";
        SqlConnection conn = null;
        DataTable dtDonhang = new DataTable();
        DataTable dtThanhToan = null;
        SqlDataAdapter daDonhang = null;
        SqlDataAdapter daThanhToan = null;

        int row,i=1;
        private void bt_Them_Click(object sender, EventArgs e)
        {
            //string sql_insert_ThanhToan = "insert into ThanhToan values ('" + i + "','" + cb_TenH.Text + "','" + nUD_SoLuong + "','" + tb_DonGia + "','" + tb_ThanhToan + ")";
           // SqlCommand cmd_insert = new SqlCommand(sql_insert_ThanhToan, conn);
            //cmd_insert.ExecuteNonQuery();
            //dtThanhToan.Rows.Clear();
            //daThanhToan.Fill(dtThanhToan);
            //i++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            //SQL Don hang
            string sql_select_Donhang = "select *from Donhang";
            SqlDataAdapter daDonhang = new SqlDataAdapter(sql_select_Donhang, conn);
            DataTable dtDonhang = new DataTable();
            daDonhang.Fill(dtDonhang);
            cb_TenH.DataSource = dtDonhang;
            cb_TenH.DisplayMember = "TenHang";     
            cb_TenH.ValueMember = "MaHang";
            
            //SQL Thanh toan
            string sql_select_ThanhToan = "select *from ThanhToan";
            SqlDataAdapter daThanhToan = new SqlDataAdapter(sql_select_ThanhToan, conn);
            DataTable dtThanhToan = new DataTable();
            daThanhToan.Fill(dtThanhToan);
            dtg_DonHang.DataSource = dtThanhToan;
        }

        private void bt_TaoDonHang_Click(object sender, EventArgs e)
        {

        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cb_TenH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql_select_Dongia = "Select DonGia from Donhang where TenHang = N'" + cb_TenH.Text + "'";
            SqlDataAdapter daDonGia = new SqlDataAdapter(sql_select_Dongia, conn);
            DataTable dtDonGia = new DataTable();
            daDonGia.Fill(dtDonGia);
            if(dtDonGia.Rows.Count > 0)
            {
                tb_DonGia.Text = dtDonGia.Rows[0][0].ToString();
            }    
           
            //dtDonhang.Rows.Find()
            
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            dtg_DonHang.Rows.Clear();
        }

        private void dtg_DonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dtg_DonHang.CurrentCell.RowIndex;
        }
    }
}
