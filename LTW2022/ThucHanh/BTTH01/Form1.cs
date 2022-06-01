using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;
        private void tbSoN_Leave(object sender, EventArgs e)
        {
            //Bắt lỗi chuyển đổi định dạng sau khi rời khỏi textbox
            try
            {
                n = Convert.ToInt32(tbSoN.Text);
                if(n<=0 || n>=1000)
                {
                    MessageBox.Show("Số N không thỏa mãn điều kiện. Yêu cầu nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSoN.Focus(); //Trở lại textbox và nhập lại
                }    
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập liệu lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool IsSNT(int x)
        {
            if (x < 2)
                return false;
            else
            {
                for (int i = 2; i < x/2; i++)
                    if (x % i == 0)
                        return false;
            }
            return true;
        } //Hàm kiểm tra số nguyên tố

        bool IsSCP(int x)
        {
            for (int i = 2; i <= x/2; i++)
                if (i * i == x)
                    return true;
            return false;
        }

        bool IsSHH(int x)
        {
            int tong = 0;
            for (int i = 1; i < x; i++)
                if (x % i == 0)
                    tong += i;
            if (tong == x)
                return true;
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string list1 = "";
            string list2 = "";
            string list3 = "";
            for (int i=2; i<n; i++)
            {
                if (IsSNT(i)==true)
                {
                    list1 += i.ToString() + " ";
                }// Kiểm tra số nguyên tố
                if (IsSCP(i) == true)
                {
                    list2 += i.ToString() + " ";
                } //Kiểm tra số chính phương
                if (IsSHH(i) == true)
                    list3 += i.ToString() + " "; //Kiểm tra số hoàn hảo
            }
            lbSNT.Text = "Các số nguyên tố < n:" + list1;
            lbSCP.Text = "Các số chính phương < n: " + list2;
            lbSHH.Text = "Các số hoàn hảo < n: " + list3;
        }

        
    }
}
