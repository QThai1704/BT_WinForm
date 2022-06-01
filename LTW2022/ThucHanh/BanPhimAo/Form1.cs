using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanPhimAo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color oldColor;
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            oldColor = ((Button)sender).BackColor;
            ((Button)sender).BackColor = Color.Pink;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            tbHienThi.Text += ((Button)sender).Text;
            ((Button)sender).BackColor = Color.Orange;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(tbHienThi.Text.Length > 0)
            {
                //Xóa các kí tự trong tbHienThi.Text từ vị trí cuối đến vị trí đầu
                tbHienThi.Text = tbHienThi.Text.Remove(tbHienThi.Text.Length - 1,1);
            }
            else
            {
                MessageBox.Show("Văn bản rỗng!");
            }
            
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = oldColor;
        }
    }
}
