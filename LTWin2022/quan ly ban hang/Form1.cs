using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quan_ly_ban_hang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionstr = @"Data Source=DESKTOP-3CV4MA5\SQLEXPRESS;
                                 Initial Catalog=QLBH;
                                 Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daHang;
        DataTable dtHang;
        int stt, dong = -1;
        private void bt_Taodonhang_Click(object sender, EventArgs e)
        {
            stt = 1;
            dataGridView1.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionstr);
            conn.Open();
            string sql = "Select * from HANG";
            daHang = new SqlDataAdapter(sql, conn);
            dtHang = new DataTable();
            daHang.Fill(dtHang);
            cb_Tenhang.DataSource = dtHang;
            cb_Tenhang.DisplayMember = "Tên hàng";
            cb_Tenhang.ValueMember = "Mã hàng";
        }

        private void cb_Tenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "Select [Đơn giá] from HANG where [Tên hàng] = N'"+cb_Tenhang.Text+"'";
            SqlDataAdapter daGia = new SqlDataAdapter(sql, conn);
            DataTable dtGia = new DataTable();
            daGia.Fill(dtGia);
            tb_Dongia.Text = dtGia.Rows[0][0].ToString();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                dong = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(dong);
                stt = 1;
                for(int i=0; i<dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = stt;
                    ++stt;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Chưa có hàng để xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Thanhtoan_Click(object sender, EventArgs e)
        {
            int s = 0;
            for(int i=0; i<dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[4].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                s += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            tb_Tongtien.Text = s.ToString();
        }

        private void ctm_Doimau_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                contextMenuStrip1.SourceControl.BackColor = colorDialog1.Color;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            if (tb_Tenkhach.Text == "" || cb_Tenhang.Text == "" || nud_Soluong.Value == 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.Rows.Add(++stt, cb_Tenhang.Text, nud_Soluong.Value, tb_Dongia.Text);
                nud_Soluong.Value = 0;
            }
        }


    }
}
