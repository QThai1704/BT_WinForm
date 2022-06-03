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
    public partial class form_QuanLyBanHang : Form
    {
        bool isBool = true;
        
        public form_QuanLyBanHang()
        {
            InitializeComponent();
        }


        private void form_QuanLyBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isBool)
            {
                Application.Exit();
            }
                
        }

        private void mni_Thoat_Click(object sender, EventArgs e)
        {
            if (isBool)
            {
                Application.Exit();
            }
        }

        private void mni_DangXuat_Click(object sender, EventArgs e)
        {
            isBool = false;
            this.Close();
            Form_DangNhap Dn = new Form_DangNhap();
            Dn.Show();
        }

        private void mni_DoiMatKhau_Click(object sender, EventArgs e)
        {
            Form_DoiMatKhau Dmk = new Form_DoiMatKhau();
            Dmk.Show();
            this.Hide();
        }

        
        private void mni_SP_Click(object sender, EventArgs e)
        {
            Form_QLSP fQLSP = new Form_QLSP();
            fQLSP.ShowDialog();
        }

        private void mni_Kho_Click(object sender, EventArgs e)
        {
            Form_KhoHang fKH = new Form_KhoHang();
            fKH.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_QLKhachHang fNV = new Form_QLKhachHang();
            fNV.ShowDialog();
        }
    }
    
}
