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
        void check()
        {

        }
        string chuoiketnoi = @"Data Source = NQTHAI\SQLEXPRESS01; Initial Catalog = QuanLyBanHang; Integrated Security = True";
        SqlConnection conn = null;
        SqlDataAdapter daCTKho, daKho, daSP ;
        DataTable dtCTKho, dtKho, dtSP;
        int rowKho, rowSP, rowCTKho;
        //Thêm kho hàng
        private void btK_Them_Click(object sender, EventArgs e)
        {
            //Thêm bộ record vào bảng KhoHang
            
            string sql_insert_Kho = "insert into KhoHang values ('"+tbK_MaK.Text+"',N'"+tbK_TenK.Text+"')";
            SqlCommand cmd_insert = new SqlCommand(sql_insert_Kho, conn);
            cmd_insert.ExecuteNonQuery();
            dtKho.Rows.Clear();
            daKho.Fill(dtKho);
            tbK_MaK.Text = "";
            tbK_TenK.Text = "";
        }
        //Lấy 1 record trong bảng KhoHang
        private void dtg_Kho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowKho = dtg_Kho.CurrentCell.RowIndex;
            tbK_MaK.Text = dtg_Kho.Rows[rowKho].Cells[0].Value.ToString();
            tbK_TenK.Text = dtg_Kho.Rows[rowKho].Cells[1].Value.ToString();
        }
        //Xóa kho hàng
        private void btK_Xoa_Click(object sender, EventArgs e)
        {
            if(dtg_Kho.Rows.Count > 0)
            {
                if (tbK_MaK.Text == "")
                {
                    MessageBox.Show("Hãy chọn mã kho cần xóa");
                }
                else
                {
                    //Xóa bộ record trong bảng KhoHang
                    string sql_delete_Kho = "delete from KhoHang where [Mã kho] = '" + tbK_MaK.Text + "'";
                    SqlCommand cmd_delete = new SqlCommand(sql_delete_Kho, conn);
                    cmd_delete.ExecuteNonQuery();
                    dtKho.Rows.Clear();
                    daKho.Fill(dtKho);
                    tbK_MaK.Text = "";
                    tbK_TenK.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu trống!");
            }
            
        }
        //Thêm sản phẩm
        private void btS_Them_Click(object sender, EventArgs e)
        {
            //Thêm bộ record vào bảng SanPham
            string sql_insert_SP = "insert into SanPham values ('" + tbS_MaSP.Text + "',N'" + tbS_TenSP.Text + "','"+ tbS_DonG.Text +"')";
            SqlCommand cmd_insert = new SqlCommand(sql_insert_SP, conn);
            cmd_insert.ExecuteNonQuery();
            dtSP.Rows.Clear();
            daSP.Fill(dtSP);
            tbS_MaSP.Text = "";
            tbS_TenSP.Text = "";
            tbS_DonG.Text = "";
        }
        //Xóa sản phẩm
        private void btS_Xoa_Click(object sender, EventArgs e)
        {
            if (dtSP.Rows.Count > 0)
            {
                if (tbS_MaSP.Text == "")
                {
                    MessageBox.Show("Hãy chọn mã kho cần xóa");
                }
                else
                {
                    //Xóa bộ record trong bảng SanPham
                    string sql_delete_SP = "delete from SanPham where [Mã sản phẩm] = '" + tbS_MaSP.Text + "'";
                    SqlCommand cmd_delete = new SqlCommand(sql_delete_SP, conn);
                    cmd_delete.ExecuteNonQuery();
                    dtSP.Rows.Clear();
                    daSP.Fill(dtSP);
                    tbS_MaSP.Text = "";
                    tbS_TenSP.Text = "";
                    tbS_DonG.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu trống!");
            }
        }
        // Sửa sản phẩm
        private void btS_Sua_Click(object sender, EventArgs e)
        {
            string sql_update_SP = "update SanPham set [Mã sản phẩm] ='" + tbS_MaSP.Text + "', [Tên sản phẩm] = N'" + tbS_TenSP.Text + "', [Đơn giá] = '" + tbS_DonG.Text + "' where [Mã sản phẩm] = '" + tbS_MaSP.Text + "'";
            SqlCommand cmd_update = new SqlCommand(sql_update_SP, conn);
            cmd_update.ExecuteNonQuery();
            dtSP.Rows.Clear();
            daSP.Fill(dtSP);
            tbS_MaSP.Text = "";
            tbS_TenSP.Text = "";
            tbS_DonG.Text = "";
        }
        //trả về giá trị dòng trong bảng SanPhamTrongKho
        private void dtg_CTKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowCTKho = dtg_CTKho.CurrentCell.RowIndex;
            cbb_MaKho.Text = dtg_CTKho.Rows[rowCTKho].Cells[0].Value.ToString();
            cbb_MaSP.Text = dtg_CTKho.Rows[rowCTKho].Cells[1].Value.ToString();
            cbb_TenSP.Text = dtg_CTKho.Rows[rowCTKho].Cells[2].Value.ToString();
            tb_SoLuong.Text = dtg_CTKho.Rows[rowCTKho].Cells[3].Value.ToString();
            tb_Ghichu.Text = dtg_CTKho.Rows[rowCTKho].Cells[4].Value.ToString();
        }
        //Chỉnh sửa CTKho
        private void bt_Sua_Click(object sender, EventArgs e)
        {
            cbb_MaKho.Text = dtg_CTKho.Rows[rowCTKho].Cells[0].Value.ToString();
            cbb_MaSP.Text = dtg_CTKho.Rows[rowCTKho].Cells[1].Value.ToString();
            cbb_TenSP.Text = dtg_CTKho.Rows[rowCTKho].Cells[2].Value.ToString();
            tb_SoLuong.Text = dtg_CTKho.Rows[rowCTKho].Cells[3].Value.ToString();
            tb_Ghichu.Text = dtg_CTKho.Rows[rowCTKho].Cells[4].Value.ToString();
        }
        //Lưu record mới cho CTKho
        private void bt_Luu_Click(object sender, EventArgs e)
        {
            string sql_update_CTKho = "update SanPhamTrongKho set [Mã kho] ='" + cbb_MaKho.Text + "', [Mã sản phẩm] = '" + cbb_MaSP.Text + "', [Tên sản phẩm] = N'"+ cbb_TenSP.Text+ "',[Số lượng] = '" + tb_SoLuong.Text+ "', [Ghi chú] = N'" +tb_Ghichu.Text+  "' where [Mã kho] = '" + cbb_MaKho.Text + "'";
            SqlCommand cmd_update = new SqlCommand(sql_update_CTKho, conn);
            cmd_update.ExecuteNonQuery();
            dtCTKho.Rows.Clear();
            daCTKho.Fill(dtCTKho);
            cbb_MaKho.Text = "";
            cbb_MaSP.Text = "";
            cbb_TenSP.Text = "";
            tb_SoLuong.Text = "";
            tb_Ghichu.Text = "";
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            string sql_select_CTKho = "select *from SanPhamTrongKho where [Tên sản phẩm] = N'Giày Puma'";
            SqlCommand cmd_select_CTKho = new SqlCommand(sql_select_CTKho, conn);
            cmd_select_CTKho.ExecuteNonQuery();
            dtCTKho.Rows.Clear();
            daCTKho.Fill(dtCTKho);
            dtg_CTKho.DataSource = dtCTKho;
            tb_TimKiem.Text = "";
        }

        //Chỉnh sửa kho
        private void btK_Sua_Click(object sender, EventArgs e)
        {
            string sql_update_Kho = "update KhoHang set [Mã kho] ='" + tbK_MaK.Text + "', [Tên kho] = N'" + tbK_TenK.Text + "' where [Mã kho] = '" + tbK_MaK.Text + "'";
            SqlCommand cmd_update = new SqlCommand(sql_update_Kho, conn);
            cmd_update.ExecuteNonQuery();
            dtKho.Rows.Clear();
            daKho.Fill(dtKho);
            tbK_MaK.Text = "";
            tbK_TenK.Text = "";
        }

        //Lấy 1 record trong bảng SanPham
        private void dtg_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSP = dtg_SP.CurrentCell.RowIndex;
            tbS_MaSP.Text = dtg_SP.Rows[rowSP].Cells[0].Value.ToString();
            tbS_TenSP.Text = dtg_SP.Rows[rowSP].Cells[1].Value.ToString();
            tbS_DonG.Text = dtg_SP.Rows[rowSP].Cells[2].Value.ToString();
        }

        private void Form_KhoHang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            //Kết nối bảng kho hàng
            string sql_select_Kho = "select *from KhoHang";
            daKho = new SqlDataAdapter(sql_select_Kho, conn);
            dtKho = new DataTable();
            daKho.Fill(dtKho);
            dtg_Kho.DataSource = dtKho;
            cbb_MaKho.DataSource = dtKho;
            cbb_MaKho.DisplayMember = "Mã kho";
            cbb_MaKho.ValueMember = "Mã kho";

            //Kết nối bảng SanPham
            string sql_select_SP = "select *from SanPham";
            daSP  = new SqlDataAdapter(sql_select_SP, conn);
            dtSP = new DataTable();
            daSP.Fill(dtSP);
            dtg_SP.DataSource = dtSP;
            cbb_MaSP.DataSource = dtSP;
            cbb_MaSP.DisplayMember = "Mã sản phẩm";
            cbb_MaSP.ValueMember = "Mã sản phẩm";
            cbb_TenSP.DataSource = dtSP;
            cbb_TenSP.DisplayMember = "Tên sản phẩm";
            cbb_TenSP.ValueMember = "Mã sản phẩm";

            //Kết nối bảng CTKho
            string sql_select_CTKho = "select *from SanPhamTrongKho";
            daCTKho = new SqlDataAdapter(sql_select_CTKho, conn);
            dtCTKho = new DataTable();
            daCTKho.Fill(dtCTKho);
            dtg_CTKho.DataSource = dtCTKho;
        }
        //thêm chi tiết kho hàng
        private void bt_Them_Click(object sender, EventArgs e)
        {
            //Thêm bộ record vào bảng SanPhamTrongKho
            string sql_insert_CTKho = "insert into SanPhamTrongKho values ('" + cbb_MaKho.Text + "','" + cbb_MaSP.Text + "',N'" + cbb_TenSP.Text + "','"+tb_SoLuong.Text+"',N'"+ tb_Ghichu.Text+"')";
            SqlCommand cmd_insert = new SqlCommand(sql_insert_CTKho, conn);
            cmd_insert.ExecuteNonQuery();
            dtCTKho.Rows.Clear();
            daCTKho.Fill(dtCTKho);
            cbb_MaKho.Text = "";
            cbb_MaSP.Text = "";
            cbb_TenSP.Text = "";
            tb_SoLuong.Text = "";
            tb_Ghichu.Text = "";

        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            //Xóa bộ record trong bảng SanPham
            string sql_delete_CTKho = "delete from SanPhamTrongKho where [Mã sản phẩm] = '" + cbb_MaSP.Text + "' and [Mã kho] = '"+cbb_MaKho.Text+"'";
            SqlCommand cmd_delete = new SqlCommand(sql_delete_CTKho, conn);
            cmd_delete.ExecuteNonQuery();
            dtCTKho.Rows.Clear();
            daCTKho.Fill(dtCTKho);
            cbb_MaKho.Text = "";
            cbb_MaSP.Text = "";
            cbb_TenSP.Text = "";
            tb_SoLuong.Text = "";
            tb_Ghichu.Text = "";
        }

        private void tP_CTKho_Click(object sender, EventArgs e)
        {

        }
    }
}
