using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace QLSinhVien1_JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtTinh; //Khai báo 1 DataTable để lưu trữ DL
        //DataSet ds; // Thêm nhiều bảng

        private void Form1_Load(object sender, EventArgs e)
        {
            //Thêm cột (key) cho Data
            dtTinh = new DataTable("dtTinh");
            dtTinh.Columns.Add("MaTinh");
            dtTinh.Columns.Add("TenTinh");
            dgt1.DataSource = dtTinh;
            //Chạy dữ liệu đã lưu kho gọi mở form1
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(@"dtTinh.json");
                string str = reader.ReadToEnd();
                dtTinh = JsonConvert.DeserializeObject<DataTable>(str);
                reader.Close();
            }
            

            //dgt1.DataSource = dtTinh;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            //Lưu DL
            //Chuyển đổi DL cần lưu thành chuỗi json
            string strjson = JsonConvert.SerializeObject(dtTinh);
            //Lưu vào file 
            System.IO.File.WriteAllText(@"dtTinh.json", strjson);
            MessageBox.Show("Da luu");
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            dtTinh.Rows.Add(tbMaT.Text, tbTenT.Text);
        }
    }
}
