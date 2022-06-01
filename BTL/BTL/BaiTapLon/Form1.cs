using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class Form_DangNhap : Form
    {
        //Khai báo biến 
        string taikhoan = "admin";
        string matkhau = "admin";
        //Định nghĩa hàm
        bool isLogin(string tentaikhoan, string tenmatkhau)
        {
            if(tentaikhoan == taikhoan || tenmatkhau == matkhau)
            {
                return true;
            }    
            return false;
        }

        public Form_DangNhap()
        {
            InitializeComponent();
        }
        //Hàm tạo với tham số truyền vào
        public Form_DangNhap(string taikhoanmoi, string matkhaumoi) :this()
        {
            taikhoanmoi = taikhoan;
            matkhaumoi = matkhau;
        }
        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            //Thoát chương trình ứng dụng
            Application.Exit();
        }

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            if(isLogin(tb_TaiKhoan.Text, tb_MatKhau.Text))
            {
                //Khai báo 1 form mới
                form_QuanLyBanHang Ql = new form_QuanLyBanHang();
                //Hiện form QuanLyBanHang khi click vào bt_DangNhap
                Ql.Show();
                //Ẩn form Đăng nhập 
                this.Hide();
            }
            else if(tb_TaiKhoan.Text == "" || tb_MatKhau.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tài khoản và mật khẩu", "Lỗi");
                tb_TaiKhoan.Focus();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Yêu cầu nhập lại");
                tb_TaiKhoan.Text = "";
                tb_MatKhau.Text = "";
                tb_TaiKhoan.Focus();
            }
            
        }
    }
}
