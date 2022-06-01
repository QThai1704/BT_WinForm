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
    public partial class Form_DoiMatKhau : Form
    {
        public Form_DoiMatKhau()
        {
            InitializeComponent();
        }
        //Hàm tạo với các tham số truyền vào
        public Form_DoiMatKhau(string TenTKMoi, string MKMoi) :this()
        {
            TenTKMoi = tb_TenTaiKhoan.Text;
            MKMoi = tb_MKMoi1.Text;
        }
        private void bt_Luu_Click(object sender, EventArgs e)
        {
            Form_DangNhap fDn = new Form_DangNhap(tb_TenTKMoi.Text,tb_MKMoi1.Text);
        }
    }
}
