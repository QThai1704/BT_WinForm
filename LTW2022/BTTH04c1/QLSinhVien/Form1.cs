using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int row;
        private void btThem_Click(object sender, EventArgs e)
        {
            string gt;
            if (rbt1.Checked)
                gt = "Nam";
            else if (rBt2.Checked)
                gt = "Nữ";
            else
                gt = "";
            dataGridView1.Rows.Add(tbMaSV.Text, tbHT.Text, dTNgaySinh.Value, gt, cbBQueQuan.Text, cbBLop.Text, cbBKhoa.Text);
            tbMaSV.Text = "";
            tbHT.Text = "";
            gt = "";
            cbBQueQuan.Text = "";
            cbBLop.Text = "";
            cbBKhoa.Text = "";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ textbox, combotb gán lên cell
            dataGridView1.Rows[row].Cells[0].Value = tbMaSV.Text;
            dataGridView1.Rows[row].Cells[1].Value = tbHT.Text;
            dataGridView1.Rows[row].Cells[2].Value = dTNgaySinh.Value;
            if (rbt1.Checked)
                dataGridView1.Rows[row].Cells[3].Value = rbt1.Text;
            else
                dataGridView1.Rows[row].Cells[3].Value = rBt2.Text;
            dataGridView1.Rows[row].Cells[4].Value = cbBQueQuan.Text;
            dataGridView1.Rows[row].Cells[5].Value = cbBLop.Text;
            dataGridView1.Rows[row].Cells[6].Value = cbBKhoa.Text;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            //Xóa 1 dòng được click
            dataGridView1.Rows.RemoveAt(row);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Xác định dòng được click tới
            row = dataGridView1.CurrentCell.RowIndex;
            //Lấy dữ liệu từ cell gán lên textbox, combotb 
            tbMaSV.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            tbHT.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            dTNgaySinh.Text = dataGridView1.Rows[row].Cells[2].Value.ToString( );
            if(rbt1.Checked)
                rbt1.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            else
                rBt2.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            cbBQueQuan.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
            cbBLop.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();
            cbBKhoa.Text = dataGridView1.Rows[row].Cells[6].Value.ToString();
        }
    }
}
