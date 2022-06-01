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
            string sql_KhoHang = "select *from KhoHang";
            daKhoHang = new SqlDataAdapter(sql_KhoHang, conn);
            dtKhoHang = new DataTable();
            daKhoHang.Fill(dtKhoHang);
            dtg_KhoHang.DataSource = dtKhoHang;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            //Khai báo 1 biến và ép kiểu chuỗi về int
            int soLuong = Convert.ToInt32(tb_SoLuong.Text);
            // Khai báo biến và gán câu lệnh SQL
            string sql_insert_KhoHang = "insert into SanPhamTrongKho values('" +cbb_MaKho.Text + "','" + cbb_MaSP.Text+ "'N" +tbS_TenSP.Text+ "'," +tb_SoLuong.Text + ",'N" +tb_Ghichu.Text+"')";
            //Khai báo và thực hiện lệnh sql với dataSource vừa kết nối
            SqlCommand cmd_insert_KhoHang = new SqlCommand(sql_insert_KhoHang, conn);
            //Thực hiện câu lệnh sql
            cmd_insert_KhoHang.ExecuteNonQuery();
            //Xóa dữ liệu cũ của bảng
            dtKhoHang.Rows.Clear();
            //Đưa lại dữ liệu vào bảng
            daKhoHang.Fill(dtKhoHang);
            cbb_MaKho.Text = "";
            cbb_MaSP.Text = "";
            tb_TenSP.Text = "";
            tb_SoLuong.Text = "";
            tb_Ghichu.Text = "";
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            tb_MaSP.Text = dtg_KhoHang.Rows[row].Cells[0].Value.ToString();
            string sql_delete_KhoHang = "delete KhoHang where MaSP = '" + tb_MaSP.Text + "'";
            SqlCommand cmd_delete_KhoHang = new SqlCommand(sql_delete_KhoHang, conn);
            cmd_delete_KhoHang.ExecuteNonQuery();
            dtKhoHang.Rows.Clear();
            daKhoHang.Fill(dtKhoHang);
            tb_MaSP.Text = "";
        }

        private void dtg_KhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //trả về vị trí dòng đang được trỏ tới ô giá trị của 1 thuộc tính bắt đầu từ vị trí 0
            row = dtg_KhoHang.CurrentCell.RowIndex;
        }

        private void tP_CTKho_Click(object sender, EventArgs e)
        {

        }
    }
}
