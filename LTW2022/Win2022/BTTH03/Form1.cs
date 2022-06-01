using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnBackColor(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) //Nếu chọn màu xong thì ấn OK
                BackColor = colorDialog1.Color; // Lấy màu vừa chọn gán cho nền của form
                //menuStrip1.BackColor = colorDialog1.Color; // Lấy màu vừa chọn gán cho thuộc tính của menutrip
        }

        private void mnBackImage(object sender, EventArgs e)
        {
            if (dlChonAnh.ShowDialog() == DialogResult.OK)
            {
                string duongdan = dlChonAnh.FileName;// Gán file ảnh tới 1 biến đường dẫn
                this.BackgroundImage = Image.FromFile(duongdan); //
            }                     
        }

        private void mnFont(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font = fontDialog1.Font; // Thay đổi font theo form
                menuStrip1.Font = fontDialog1.Font; // Thay đổi form menuTrip (do không kế thừa thuộc tính của form)
            }

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbHienThiBieuThuc.Text += ((Button)sender).Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbHienThiBieuThuc.Text += ((Button)sender).Text;
        }
    }
}
