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
    public partial class Form_QLKhachHang : Form
    {
        public Form_QLKhachHang()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source = NQTHAI\SQLEXPRESS01; Initial Catalog = QuanLyBanHang; Integrated Security = True";
        SqlConnection conn = null;
        SqlDataAdapter daKH;
        DataTable dtKH;
        int rowKH;
        private void Form_QLKhachHang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();

            //Kết nối bảng KhachHang với DTGView
            string sql_select_KH = "select *from KhachHang";
            daKH = new SqlDataAdapter(sql_select_KH, conn);
            dtKH = new DataTable();
            daKH.Fill(dtKH);
            dtg_KH.DataSource = dtKH;
        }
        //Thêm
        private void bt_Them_Click(object sender, EventArgs e)
        {
            if((tb_MaKH.Text.Length == 0) || (tb_TenKH.Text.Length == 0) || (tb_SĐT.Text.Length == 0) || (tb_DiaChi.Text.Length == 0))
            {
                MessageBox.Show("Yêu cầu nhập thông tin");
            }
            else
            {
                string sql_insert_KH = "insert into KhachHang values ('" +tb_MaKH.Text + "',N'"+tb_TenKH.Text + "','" + tb_SĐT.Text + "',N'"+tb_DiaChi.Text+ "')";
                SqlCommand cmd_insert = new SqlCommand(sql_insert_KH, conn);
                cmd_insert.ExecuteNonQuery();
                dtKH.Rows.Clear();
                daKH.Fill(dtKH);
                tb_MaKH.Text = "";
                tb_TenKH.Text = "";
                tb_SĐT.Text = "";
                tb_DiaChi.Text = "";
            }
            

        }
        //Xóa
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            /*if (tb_MaKH.Text == "" || tb_TenKH.Text == "" || tb_SĐT.Text == "" || tb_)
            {
                MessageBox.Show("Hãy chọn mã kho cần xóa");
            }
            else
            {*/
            //Xóa bộ record trong bảng KhoHang
            string sql_delete_Kho = "delete from KhachHang where [Mã khách hàng] = '" + tb_MaKH.Text + "'";
            SqlCommand cmd_delete = new SqlCommand(sql_delete_Kho, conn);
            cmd_delete.ExecuteNonQuery();
            dtKH.Rows.Clear();
            daKH.Fill(dtKH);
            tb_MaKH.Text = "";
            tb_TenKH.Text = "";
            tb_SĐT.Text = "";
            tb_DiaChi.Text = "";
            /*}*/
        }

        private void dtg_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowKH = dtg_KH.CurrentCell.RowIndex;
            tb_MaKH.Text = dtg_KH.Rows[rowKH].Cells[0].Value.ToString();
            tb_TenKH.Text = dtg_KH.Rows[rowKH].Cells[1].Value.ToString();
            tb_SĐT.Text = dtg_KH.Rows[rowKH].Cells[2].Value.ToString();
            tb_DiaChi.Text = dtg_KH.Rows[rowKH].Cells[3].Value.ToString();

        }
        //Sửa
        private void bt_Sua_Click(object sender, EventArgs e)
        {
            string sql_update_KH = "update KhachHang set [Tên khách hàng] = N'" +tb_TenKH.Text+"', [Số điện thoại] = '" + tb_SĐT.Text + "', [Địa chỉ] = N'" + tb_DiaChi.Text + "' where [Mã khách hàng] = '"+tb_MaKH.Text+"'";
            SqlCommand cmd_update = new SqlCommand(sql_update_KH, conn);
            cmd_update.ExecuteNonQuery();
            dtKH.Rows.Clear();
            daKH.Fill(dtKH);
            tb_MaKH.Text = "";
            tb_TenKH.Text = "";
            tb_SĐT.Text = "";
            tb_DiaChi.Text = "";
        }
    }
}
