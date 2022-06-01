using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH03ud
{
    public partial class Form1 : Form
    {
        double st1, st2, kq=0;
        string dau, ht;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbHienThiBieuThuc.Text += ((Button)sender).Text;
            ht = ((Button)sender).Text;
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) //Nếu chọn màu xong thì ấn OK
                BackColor = colorDialog1.Color; // Lấy màu vừa chọn gán cho nền của form
                //menuStrip1.BackColor = colorDialog1.Color; // Lấy màu vừa chọn gán cho thuộc tính của menutrip
        }

        private void backImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlChonAnh.ShowDialog() == DialogResult.OK)
            {
                string duongdan = dlChonAnh.FileName;// Gán file ảnh tới 1 biến đường dẫn
                this.BackgroundImage = Image.FromFile(duongdan); //
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font = fontDialog1.Font; // Thay đổi font theo form
                menuStrip1.Font = fontDialog1.Font; // Thay đổi form menuTrip (do không kế thừa thuộc tính của form)
            }
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            tbHienThiBieuThuc.Text += ((Button)sender).Text;
            dau = ((Button)sender).Text;
            st1 = Convert.ToDouble(ht);
            ht = "";
        }

        private void btBang_Click(object sender, EventArgs e)

        {
            st2 = Convert.ToDouble(ht);
            if ( dau == "+")
                kq = st1 + st2;
            else if( dau =="-")
                kq = st1 - st2;
            else if(dau == "*")
                kq = st1 * st2;
            else
            {
                if(st2 == 0)
                {
                    MessageBox.Show("Lỗi chia cho 0!");
                } 
                else
                {
                    kq = st1 / st2;
                }    
            }    
            tbHienThiKetQua.Text = kq.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            tbHienThiBieuThuc.Text = "";
        }
    }
}
