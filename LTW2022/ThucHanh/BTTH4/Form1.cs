using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soMH;
        int dem = 1;
        private void tb_SoMH_Leave(object sender, EventArgs e)
        {
                try
                {
                    soMH = Convert.ToInt32(tb_SoMH.Text);
                    groupBox1.Text = "Nhập thông tin cho mặt hàng thứ " + dem;
                    tb_MaH.Visible = true;
                    tb_TenH.Visible = true;
                    dateTimePicker1.Visible = true;
                    tb_SoLuong.Visible = true;
                    tb_DonG.Visible = true;
                    cb_XuatX.Visible = true;
                    bt_Them.Visible = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Bạn đã nhập sai!", "Lỗi nhập liệu");
                    tb_SoMH.Text = "";
                    tb_SoMH.Focus();
                }   
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            if (tb_MaH.Text == " " || tb_TenH.Text == "" || tb_SoLuong.Text == "" || tb_DonG.Text == "" || cb_XuatX.Text == "")
            {
                MessageBox.Show("Rỗng!", "Lỗi");
            }
            else
            {
                if (dem == soMH)
                {
                    dataGridView1.Rows.Add(tb_MaH.Text, tb_TenH.Text, dateTimePicker1.Value, tb_SoLuong.Text, tb_DonG.Text, cb_XuatX.Text);
                    tb_MaH.Visible = false;
                    tb_TenH.Visible = false;
                    dateTimePicker1.Visible = false;
                    tb_SoLuong.Visible = false;
                    tb_DonG.Visible = false;
                    cb_XuatX.Visible = false;
                    bt_Them.Visible = false;
                }
                else
                {
                    dataGridView1.Rows.Add(tb_MaH.Text, tb_TenH.Text, dateTimePicker1.Value, tb_SoLuong.Text, tb_DonG.Text, cb_XuatX.Text);
                    dem++;
                    groupBox1.Text = "Nhập thông tin cho mặt hàng thứ " + dem;
                    tb_MaH.Text = "";
                    tb_TenH.Text = "";
                    tb_SoLuong.Text = "";
                    tb_DonG.Text = "";
                    cb_XuatX.Text = "";
                }
            }
            
            
        }
    }
}
