using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVien2_SQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Khai 1 biến kiểu chuỗi và gán nguồn SQL
        string chuoiketnoi = "Data Source=NQTHAI\\SQLEXPRESS01;Initial Catalog=QLSinhVien;Integrated Security=True";
        //Khai báo biến kiểu sqlConnection gán = null
        SqlConnection conn = null;
        //Khai báo một biến kiểu sqldataadapter 
        SqlDataAdapter daTinh, daKhoa;
        // Khai báo 1 datatable
        DataTable dtTinh = new DataTable();
        DataTable dtKhoa = new DataTable();

        int dongTinh;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Gán biến conn với sqlConnection với src chuoiketnoi
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            //Câu lệnh truy vấn dữ liệu SQL
            string sql_Tinh = "Select *from Tinh";
            string sql_Khoa = "Select *from Khoa";
            //Khởi tạo một biến kiểu sqldataadapter với câu lệnh truy vấn và connection đã tạo ở trên
            daTinh = new SqlDataAdapter(sql_Tinh, conn);
            daKhoa = new SqlDataAdapter(sql_Khoa, conn);
            //Đổ dữ liệu truy vấn từ daTinh vào bảng dtTinh
            daTinh.Fill(dtTinh);
            daKhoa.Fill(dtKhoa);
            //Hiển thị dữ liệu từ bảng lên giao diện form_load
            dgt_Tinh.DataSource = dtTinh;   
            dgt_Khoa.DataSource = dtKhoa;
        }

        private void btTinh_Them_Click(object sender, EventArgs e)
        {
            string sql_Insert_Tinh = "Insert into Tinh values ('" + tbMaT.Text + "', N'" + tbTenT.Text + "')";
            //Dùng SqlCommand để cập nhật DL với các chức năng
            SqlCommand cmdTinh = new SqlCommand(sql_Insert_Tinh, conn);
            //Thực hiện câu lệnh trong chuỗi sql_Insert_Tinh
            //Cập nhật DL mới thêm vào dgt_Tinh
            cmdTinh.ExecuteNonQuery();
            //Xóa dữ DL trong datagridview
            dtTinh.Rows.Clear();
            //Hiển thị lại DL vào datagridview
            daTinh.Fill(dtTinh);
            tbMaT.Text = "";
            tbTenT.Text = "";
        }

        private void bt_Them_Khoa_Click(object sender, EventArgs e)
        {
            string sql_Insert_Khoa = "Insert into Khoa values ('" + tb_MaK.Text + "', N'" + tb_TenK.Text + "')";
            SqlCommand cmdKhoa = new SqlCommand(sql_Insert_Khoa, conn);
            cmdKhoa.ExecuteNonQuery();
            dtKhoa.Rows.Clear();
            daKhoa.Fill(dtKhoa);
        }

        private void dgt_Tinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Xác định dòng được click tới
            dongTinh = dgt_Tinh.CurrentCell.RowIndex;
        }
        
        private void btTinh_Xoa_Click(object sender, EventArgs e)
        {
            tbMaT.Text = dgt_Tinh.Rows[dongTinh].Cells[0].Value.ToString();
            string sql_Delete_Tinh = "Delete Tinh where MaTinh = " + tbMaT.Text;
            SqlCommand cmd = new SqlCommand(sql_Delete_Tinh, conn);
            cmd.ExecuteNonQuery();
            //Hiển thị lại DL vào datagridview
            //Xóa dữ DL trong datagridview
            dtTinh.Rows.Clear();
            daTinh.Fill(dtTinh);
            tbMaT.Text = "";   
        }
        private void btTinh_Sua_Click(object sender, EventArgs e)
        {
            tbMaT.Text = dgt_Tinh.Rows[dongTinh].Cells[0].Value.ToString();           
            tbTenT.Text = dgt_Tinh.Rows[dongTinh].Cells[1].Value.ToString();
        }

        private void bt_Sua_Khoa_Click(object sender, EventArgs e)
        {

        }

        private void bt_Xoa_Khoa_Click(object sender, EventArgs e)
        {
            string sql_Delete_Khoa = "Delete Khoa where MaKhoa = " + tb_MaK.Text;
        }

        private void btTinh_Luu_Click(object sender, EventArgs e)
        {
            string sql_Update_Tinh = "Update Tinh set TenTinh = N'" + tbTenT.Text + "' where MaTinh = " + tbMaT.Text;
            SqlCommand cmd = new SqlCommand(sql_Update_Tinh, conn);
            cmd.ExecuteNonQuery();
            dtTinh.Rows.Clear();
            daTinh.Fill(dtTinh);
        }
    }
}
