using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWinF1
{
    public partial class Form1 : Form
    {
        int a;
        int b;
        public Form1()
        {
            InitializeComponent();
        }
        private void tb_SoA_Leave(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(tb_SoA.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi!");
            }
        }
        private void tb_SoB_Leave(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToInt32(tb_SoA.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi!");
            }
        }
        private void bt_Tinh_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(tb_SoA.Text);
            b = Convert.ToInt32(tb_SoA.Text);
            lbTong.Text = "Tổng a+b = " + Convert.ToString(a + b);
            lbHieu.Text = "Hiệu a+b = " + Convert.ToString(a - b);
            lbTich.Text = "Tổng a*b = " + Convert.ToString(a * b);
            try
            {
                lbThuong.Text = "Thương a/b = " + Convert.ToString(a / b);
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Lỗi chia 0!");
            }
        }
    }
}
