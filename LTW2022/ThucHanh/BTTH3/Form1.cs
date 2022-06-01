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
        DataTable dtHang, dtDonG;
        SqlDataAdapter daHang;
        int i=0, tongTien, row;
        SqlConnection conn = null;
        private void bt_ThanhToan_Click(object sender, EventArgs e)
        {
            for(int i=0; i < dtg_ThongKe.Rows.Count; i++)
            {
                tongTien += Convert.ToInt32(dtg_ThongKe.Rows[i].Cells[4].Value);
            }
            tb_TongT.Text = tongTien.ToString() ;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if(dtg_ThongKe.Rows.Count > 0)
            {
                dtg_ThongKe.Rows.RemoveAt(row);
                i--;
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào!");
            }
        }

        private void dtg_ThongKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dtg_ThongKe.CurrentCell.RowIndex;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            int dGia, soL, thanhTien;
            dGia = Convert.ToInt32(tb_DonG.Text);
            soL = Convert.ToInt32(nUD_SoL.Value);
            thanhTien = soL * dGia;
            i++;
            dtg_ThongKe.Rows.Add(i,cb_TenH.Text, nUD_SoL.Value, tb_DonG.Text, thanhTien); 
        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()== DialogResult.OK)
            {
                contextMenuStrip1.SourceControl.BackColor = colorDialog1.Color;
            }    
        }

        private void cb_TenH_SelectedIndexChanged(object sender, EventArgs e)
        {
                string sql_DonG = "Select [Đơn giá] from Hang where [Tên hàng] = N'" + cb_TenH.Text + "'";
                SqlDataAdapter daDonG = new SqlDataAdapter(sql_DonG, conn);
                dtDonG = new DataTable();
                daDonG.Fill(dtDonG);
                tb_DonG.Text = dtDonG.Rows[0][0].ToString(); 
        }

        private void bt_TaoHoaDon_Click(object sender, EventArgs e)
        {
            dtg_ThongKe.Rows.Clear();
            i = 0;
            tb_TenK.Text = "";
            nUD_SoL.Value = 0;
            tb_DonG.Text = "";
            tb_TenK.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string TenH = "Select *from Hang";
            daHang = new SqlDataAdapter(TenH, conn);
            dtHang = new DataTable();
            daHang.Fill(dtHang);
            cb_TenH.DataSource = dtHang;
            cb_TenH.DisplayMember = "Tên hàng";
            cb_TenH.ValueMember = "Mã hàng";
 
        }        
    }
}
