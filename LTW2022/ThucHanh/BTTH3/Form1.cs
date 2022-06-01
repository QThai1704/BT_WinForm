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
    public partial class Form_BanHang : Form
    {
        public Form_BanHang()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=NQTHAI\SQLEXPRESS01;Initial Catalog=THQLBanHang;Integrated Security=True";
        DataTable dtHang, dtDonHang, dtDonG;
        SqlDataAdapter daHang, daDonHang;
        int i=0, tongTien;

        private void bt_ThanhToan_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string sql_Select = "select sum([Thành tiền]) from DonHang";
            DataTable dtTong = new DataTable();
            SqlDataAdapter daTong = new SqlDataAdapter(sql_Select, conn);
            daTong.Fill(dtTong);
            tb_TongT.Text = dtTong.Rows[0][0].ToString();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            int dGia, soL;
            i++;
            dGia = Convert.ToInt32(tb_DonG.Text);
            soL = Convert.ToInt32(nUD_SoL.Value);
            tongTien = soL * dGia;
            string sql_Insert = "Insert into DonHang values ('" +i+"',N'"+cb_TenH.Text+"','" +nUD_SoL.Value+ "','"+tb_DonG.Text+"','"+tongTien+"')";
            SqlCommand cmd_Insert = new SqlCommand(sql_Insert,conn);
            cmd_Insert.ExecuteNonQuery();
            dtDonHang.Rows.Clear();
            daDonHang.Fill(dtDonHang);
        }

        private void cb_TenH_SelectedIndexChanged(object sender, EventArgs e)
        {
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                conn.Open();
                string sql_DonG = "Select [Đơn giá] from Hang where [Tên hàng] = N'" + cb_TenH.Text + "'";
                SqlDataAdapter daDonG = new SqlDataAdapter(sql_DonG, conn);
                dtDonG = new DataTable();
                daDonG.Fill(dtDonG);
                tb_DonG.Text = dtDonG.Rows[0][0].ToString();
                
        }

        private void bt_TaoHoaDon_Click(object sender, EventArgs e)
        {
            dtDonHang.Rows.Clear();
            dtg_ThongKe.DataSource = dtDonHang;
            tb_TenK.Text = "";
            nUD_SoL.Value = 0;
            tb_DonG.Text = "";
            tb_TenK.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string TenH = "Select *from Hang";
            daHang = new SqlDataAdapter(TenH, conn);
            dtHang = new DataTable();
            daHang.Fill(dtHang);
            cb_TenH.DataSource = dtHang;
            cb_TenH.DisplayMember = "Tên hàng";
            cb_TenH.ValueMember = "Mã hàng";

            //Kết nối đơn hàng
            string sql_DonH = "Select *from DonHang";
            daDonHang = new SqlDataAdapter(sql_DonH, conn);
            dtDonHang = new DataTable();
            daDonHang.Fill(dtHang);
            dtg_ThongKe.DataSource = dtDonHang;
        }        
    }
}
