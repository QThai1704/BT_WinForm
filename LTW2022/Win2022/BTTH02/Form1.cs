using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH02
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tong = 0 ; // Khai báo biến tổng
            if(cbCaoVoi.Checked == true)
            {
                tong += 100000;
            }    // Kiểm tra thuộc tính Checked xem cbCaoVoi có được tích hay không
            if(cbTayTrang.Checked == true)
            {
                tong += 1200000;
            } //Kiểm tra thuộc tính Checked xem cbTayTrang có được tích hay không
            if (cbChupHinh.Checked == true)
            {
                tong += 150000;
            }//Kiểm tra thuộc tính Checked xem cbChupHinh có được tích hay không
            if (cbLayCao.Checked == true)
            {
                tong += 100000;
            }//Kiểm tra thuộc tính Checked xem cbLayCao có được tích hay không
            if (nUD.Value > 0) 
            {
                tong += Convert.ToInt32(90000 * nUD.Value); // Ép kiểu dữ liệu 
            }
            tbTong.Text = Convert.ToString(tong); // chuyển đổi dữ liệu
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }// Thoát khỏi chương trình

        
    }
}
