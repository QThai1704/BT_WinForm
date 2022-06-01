using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH05
{
    public partial class Form1 : Form
    {
        int a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_SoB_Leave(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToInt32(tb_SoB.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Sai dữ liệu!");
                tb_SoB.Focus();
            }
        }

        private void tb_SoC_Leave(object sender, EventArgs e)
        {
            try
            {
                c = Convert.ToInt32(tb_SoC.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Sai dữ liệu!");
                tb_SoC.Focus();
            }
        }

        private void bt_Tinh_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(tb_SoA.Text);
            b = Convert.ToInt32(tb_SoB.Text);
            c = Convert.ToInt32(tb_SoC.Text);
            double delta;
            delta = (b * b) - (4 * a * c);
            if(delta > 0)
            {
                tb_KQ1.Text = "Vô nghiệm";
                tb_KQ2.Text = "Vô nghiệm";
            }
            else if (delta == 0)
            {
                double kq;
                kq = (-b / (2 * a));
                tb_KQ1.Text = Convert.ToString(kq);
                tb_KQ2.Text = Convert.ToString(kq);
            }
            else
            {
                double kq1, kq2;
                kq1 = Convert.ToDouble((-b + Math.Sqrt(delta)) / (2 * a));
                kq2 = Convert.ToDouble((-b - Math.Sqrt(delta)) / (2 * a));
                tb_KQ1.Text = kq1.ToString();
                tb_KQ2.Text = kq2.ToString();
            }
        }

        private void tb_SoA_Leave(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(tb_SoA.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Sai dữ liệu!");
                tb_SoA.Focus();
            }
        }
    }
}
