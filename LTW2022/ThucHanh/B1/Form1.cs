using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double price;
        Color myColor;
        Button myButton;
        int count = 0;
        //DataTable ThongKe = new DataTable("ThongKe");
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btLaiXe(object sender, EventArgs e)
        {

        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            if (tbHT.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập thông tin!");
                tbHT.Focus();
            }
            else
                tbGiaVe.Text = price.ToString();
            dataGridView1.Rows.Add(myButton.Text,tbHT.Text, nUDTuoi.Value, tbGiaVe.Text);
            if (myButton != null)
            {
                myButton.BackColor = Color.Red;
            }
            myButton.BackColor = Color.Red;
            tbHT.Text = "";
            nUDTuoi.Value = 0;
            tbGiaVe.Text = "50000";
        }

        private void nUDTuoi_ValueChanged(object sender, EventArgs e)
        {
            if(nUDTuoi.Value >= 50)
            {
                price = 50000 * 0.5;
            }
            else if(nUDTuoi.Value > 0 && nUDTuoi.Value <18)
            {
                price = 50000 * 0.8;
            }    
            else
            {
                price = 50000;
            }
        }

        private void btChonVT(object sender, EventArgs e)
        {
            if (count != 0)
            {
                if (myButton.BackColor != Color.Red)
                {
                    myButton.BackColor = myColor;
                }
            }
            if(((Button)sender).BackColor == Color.Red)
            {
                MessageBox.Show("Không được chọn");
                count = 0;
            }
            else
            {
                myButton = ((Button)sender);
                myColor = myButton.BackColor;
                ((Button)sender).BackColor = Color.Orange;
                count++;
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = ThongKe;

        }
    }
}
