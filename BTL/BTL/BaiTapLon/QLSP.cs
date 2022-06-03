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
    public partial class Form_QLSP : Form
    {
        public Form_QLSP()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source = NQTHAI\SQLEXPRESS01; Initial Catalog = QuanLyBanHang; Integrated Security = True";
        SqlConnection conn = null;
        SqlDataAdapter daKH, daHD, daTenK, daCTHD, daSP, daDonG, daTongTien;
        DataTable dtKH, dtHD, dtTenK, dtCTHD, dtSP, dtDonG, dtTongTien;
        int rowHD, rowCTHD;
        int thanhTien;

        private void nUD_SoLuong_ValueChanged(object sender, EventArgs e)
        {
            int soL = Convert.ToInt32(nUD_SoLuong.Value);
            int giaB = Convert.ToInt32(tb_Giaban.Text);
            thanhTien = soL * giaB;
            tb_ThanhTien.Text = thanhTien.ToString();
        }
        //Xóa Chi tiết hóa đơn
        private void btCTHD_Xoa_Click(object sender, EventArgs e)
        {
            string sql_delete_CTHD = "delete from CTHoaDon where [Mã hóa đơn] = '" + cbb_MaHD.Text + "' and [Tên sản phẩm] = N'"+cbb_TenSP.Text + "'";
            SqlCommand cmd_delete = new SqlCommand(sql_delete_CTHD, conn);
            cmd_delete.ExecuteNonQuery();
            dtCTHD.Rows.Clear();
            daCTHD.Fill(dtCTHD);
            cbb_MaHD.Text = "";
            cbb_TenSP.Text = "";
            nUD_SoLuong.Value = 0;
            tb_Giaban.Text = "";
            tb_ThanhTien.Text = "";
        }

        private void dtg_CTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowCTHD = dtg_CTHD.CurrentCell.RowIndex;
            cbb_MaHD.Text = dtg_CTHD.Rows[rowCTHD].Cells[0].Value.ToString();
            cbb_TenSP.Text = dtg_CTHD.Rows[rowCTHD].Cells[1].Value.ToString();
            nUD_SoLuong.Text = dtg_CTHD.Rows[rowCTHD].Cells[2].Value.ToString();
            dateTimePicker2.Text = dtg_CTHD.Rows[rowCTHD].Cells[3].Value.ToString();
            tb_Giaban.Text = dtg_CTHD.Rows[rowCTHD].Cells[4].Value.ToString();
            tb_ThanhTien.Text = dtg_CTHD.Rows[rowCTHD].Cells[5].Value.ToString();
        }
        //Chỉnh sửa chi tiết hóa đơn
        private void btCTHD_Sua_Click(object sender, EventArgs e)
        {
            string sql_update_CTHD = "update CTHoaDon set [Mã hóa đơn] = '" + cbb_MaHD.Text + "', [Tên sản phẩm] = N'" + cbb_TenSP.Text +"', [Số lượng] = '"+nUD_SoLuong.Value+ "', [Ngày mua] = '" + dateTimePicker2.Text + "', [Giá bán] = '"+tb_Giaban.Text+"', [Thành tiền] = '"+tb_ThanhTien.Text+ "' where [Mã hóa đơn] = '" + cbb_MaHD.Text + "'and [Tên sản phẩm] = N'"+cbb_TenSP.Text+"'";
            SqlCommand cmd_update = new SqlCommand(sql_update_CTHD, conn);
            cmd_update.ExecuteNonQuery();
            dtCTHD.Rows.Clear();
            daCTHD.Fill(dtCTHD);
            cbb_MaHD.Text = "";
            cbb_TenSP.Text = "";
            nUD_SoLuong.Value = 0;
            tb_Giaban.Text = "";
            tb_ThanhTien.Text = "";
        }
        // Thanh toán hóa đơn
        private void btHD_ThanhToan_Click(object sender, EventArgs e)
        {
            string sql_select_TongTien = "select sum([Thành tiền]) from CTHoaDon where [Mã hóa đơn] = '"+cbb_MaHD.Text+"'";
            SqlCommand cmd_select = new SqlCommand(sql_select_TongTien, conn);
            cmd_select.ExecuteNonQuery();
            dtTongTien = new DataTable();
            daTongTien = new SqlDataAdapter(sql_select_TongTien, conn);
            daTongTien.Fill(dtTongTien);
            tb_TongTien.Text = dtTongTien.Rows[0][0].ToString();
        }

        //Thêm CTHD
        private void btCTHD_Them_Click(object sender, EventArgs e)
        {
            if ((cbb_MaHD.Text.Length == 0) || (cbb_TenSP.Text.Length == 0) || (dateTimePicker2.Text.Length == 0) || (tb_Giaban.Text.Length == 0) || (tb_ThanhTien.Text.Length == 0))
            {
                MessageBox.Show("Yêu cầu nhập thông tin");
            }
            else
            {   
                string sql_insert_CTHD = "insert into CTHoaDon values ('" + cbb_MaHD.Text + "',N'" + cbb_TenSP.Text +"','"+nUD_SoLuong.Value+ "','"+dateTimePicker2.Text+"','" + tb_Giaban.Text + "','" + tb_ThanhTien.Text + "')";
                SqlCommand cmd_insert = new SqlCommand(sql_insert_CTHD, conn);
                cmd_insert.ExecuteNonQuery();
                dtCTHD.Rows.Clear();
                daCTHD.Fill(dtCTHD);
                cbb_MaHD.Text = "";
                cbb_TenSP.Text = "";
                nUD_SoLuong.Value = 0;
                tb_Giaban.Text = "";
                tb_ThanhTien.Text = "";
            }
        }

        //Lấy giá theo tên sản phẩm
        private void cbb_TenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql_select_DonG = "select [Đơn giá] from SanPham where [Tên sản phẩm] = '" + cbb_TenSP.Text + "'";
            SqlCommand cmd_select = new SqlCommand(sql_select_DonG, conn);
            cmd_select.ExecuteNonQuery();
            dtDonG = new DataTable();
            daDonG = new SqlDataAdapter(sql_select_DonG, conn);
            daDonG.Fill(dtDonG);
            tb_Giaban.Text = dtDonG.Rows[0][0].ToString();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {

        }
        //Chỉnh sửa Hóa đơn
        private void btHD_Sua_Click(object sender, EventArgs e)
        {
            string sql_update_HD = "update HoaDon set [Mã khách hàng] ='" +cbb_MaKH.Text+"', [Tên khách hàng] = N'" +tb_TenKH.Text+ "', [Ngày tạo hóa đơn] = '" + dateTimePicker1.Value + "' where [Mã hóa đơn] = '" + tb_MaHD.Text + "'";
            SqlCommand cmd_update = new SqlCommand(sql_update_HD, conn);
            cmd_update.ExecuteNonQuery();
            dtHD.Rows.Clear();
            daHD.Fill(dtHD);
            tb_MaHD.Text = "";
            cbb_MaKH.Text = "";
            tb_TenKH.Text = "";
        }
        //Lấy bản record trong bảng HoaDon
        private void dtg_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowHD = dtg_HD.CurrentCell.RowIndex;
            tb_MaHD.Text = dtg_HD.Rows[rowHD].Cells[0].Value.ToString();
            cbb_MaKH.Text = dtg_HD.Rows[rowHD].Cells[1].Value.ToString();
            tb_TenKH.Text = dtg_HD.Rows[rowHD].Cells[2].Value.ToString();
            dateTimePicker1.Text = dtg_HD.Rows[rowHD].Cells[3].Value.ToString();
        }
        //Tạo hóa đơn mới
        private void btHD_TaoHD_Click(object sender, EventArgs e)
        {
            dtHD.Rows.Clear();
           /* daHD.Fill(dtHD);*/
        }

        //Xóa HD
        private void btHD_Xoa_Click(object sender, EventArgs e)
        {
            string sql_delete_HD = "delete from HoaDon where [Mã hóa đơn] = '" + tb_MaHD.Text + "'";
            SqlCommand cmd_delete = new SqlCommand(sql_delete_HD, conn);
            cmd_delete.ExecuteNonQuery();
            dtHD.Rows.Clear();
            daHD.Fill(dtHD);
            tb_MaHD.Text = "";
        }
        // Thêm HD
        private void btHD_Them_Click(object sender, EventArgs e)
        {
            if ((tb_MaHD.Text.Length == 0)  || (tb_TenKH.Text.Length == 0) || (dateTimePicker1.Text.Length == 0))
            {
                MessageBox.Show("Yêu cầu nhập thông tin");
            }
            else
            {
                string sql_insert_HD = "insert into HoaDon values ('" + tb_MaHD.Text + "','" + cbb_MaKH.Text + "',N'" + tb_TenKH.Text + "','" + dateTimePicker1.Value + "')";
                SqlCommand cmd_insert = new SqlCommand(sql_insert_HD, conn);
                cmd_insert.ExecuteNonQuery();
                dtHD.Rows.Clear();
                daHD.Fill(dtHD);
                tb_MaHD.Text = "";
            }
            
        }
        //Lấy tên KH theo mã KH
        private void cbb_MaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql_select_TenK = "select [Tên khách hàng] from KhachHang where [Mã khách hàng] = '"+cbb_MaKH.Text+"'";
            SqlCommand cmd_select = new SqlCommand(sql_select_TenK, conn);
            cmd_select.ExecuteNonQuery();
            dtTenK = new DataTable();
            daTenK = new SqlDataAdapter(sql_select_TenK, conn);
            daTenK.Fill(dtTenK);
            tb_TenKH.Text = dtTenK.Rows[0][0].ToString();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_QLSP_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            //Kết nối với bảng KhachHang
            string sql_select_KH = "select *from KhachHang";
            daKH = new SqlDataAdapter(sql_select_KH, conn);
            dtKH = new DataTable();
            daKH.Fill(dtKH);
            cbb_MaKH.DataSource = dtKH;
            cbb_MaKH.DisplayMember = "Mã khách hàng";
            cbb_MaKH.ValueMember = "Mã khách hàng";

            //Kết nối với bảng HoaDon
            string sql_select_HD = "select *from HoaDon";
            daHD = new SqlDataAdapter(sql_select_HD, conn);
            dtHD = new DataTable();
            daHD.Fill(dtHD);
            dtg_HD.DataSource = dtHD;
            cbb_MaHD.DataSource = dtHD;
            cbb_MaHD.DisplayMember = "Mã hóa đơn";
            cbb_MaHD.ValueMember = "Mã hóa đơn";

            //Kết nối với bảng HoaDon
            string sql_select_CTHD = "select *from CTHoaDon";
            daCTHD = new SqlDataAdapter(sql_select_CTHD, conn);
            dtCTHD = new DataTable();
            daCTHD.Fill(dtCTHD);
            dtg_CTHD.DataSource = dtCTHD;

            //Kết nối bảng SanPham
            string sql_select_SP = "select *from SanPham";
            daSP = new SqlDataAdapter(sql_select_SP, conn);
            dtSP = new DataTable();
            daSP.Fill(dtSP);
            cbb_TenSP.DataSource = dtSP;
            cbb_TenSP.DisplayMember = "Tên sản phẩm";
            cbb_TenSP.ValueMember = "Mã sản phẩm";
        }
    }
}
