using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  
using System.Windows.Forms;

namespace BTTH2
{
    public partial class Form_1 : Form
    {
        public Form_1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlDataAdapter daSach, daTTin;
        DataTable dtSach = new DataTable();
        DataTable dtTtin = new DataTable();
        int i;
        private void Form_Load(object sender, EventArgs e)
        {
            string chuoiketnoi = "Data Source=NQTHAI\\SQLEXPRESS01;Initial Catalog=QLS;Integrated Security=True";
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string sql_Select_Sach = "Select *from Sach";
            string sql_Select_TTin = "Select *from Thongtin";
            daSach = new SqlDataAdapter(sql_Select_Sach, conn);
            daTTin = new SqlDataAdapter(sql_Select_TTin, conn);
            //Đổ Dl từ SqlDataAdapter vào DataTable
            daSach.Fill(dtSach);
            daTTin.Fill(dtTtin);
            cb_TenS.DataSource = dtSach;
            cb_TenS.DisplayMember = "TenSach";
            cb_TenS.ValueMember = "TenSach";
            dtg_QLS.DataSource = dtSach;
            dtg_MT.DataSource = dtTtin;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql_Insert_Sach = "insert into Sach values ('" + tb_MaS.Text + "', N'" + tb_TenS.Text + "')";
            //Sử dụng SqlCommand để cập nhật DL với các chức năng
            SqlCommand cmdSach = new SqlCommand(sql_Insert_Sach, conn);
            //Cập nhật dữ liệu vào datagridview
            cmdSach.ExecuteNonQuery();
            //Xóa toàn bộ dữ liệu
            dtSach.Rows.Clear();
            //Đổ lại DL vào SqlDataAdapter vào DataTable
            daSach.Fill(dtSach);
            tb_MaS.Text = "";
            tb_TenS.Text = "";
        }

        private void bt_MuonS_Click(object sender, EventArgs e)
        {
            //i += 1;
            //string sql_Insert_TTin = "insert into Sach values ('" + i + "'N'" + tb_TenSV.Text + "', N'" + cb_TenS.Text + "','" + dt_NgayM.Value + "','" + dt_NgayT.Value + "'," + "'0')";
            //SqlCommand cmdTTin = new SqlCommand(sql_Insert_TTin, conn);
            //cmdTTin.ExecuteNonQuery();
            //dtTtin.Rows.Clear();
            //daSach.Fill(dtTtin);
            
        }

        //Sự kiện thay đổi giá trị ngayM
        private void dt_NgayM_ValueChanged(object sender, EventArgs e)
        {
            dt_NgayT.Value = dt_NgayM.Value.AddDays(40);
        }
    }
}
