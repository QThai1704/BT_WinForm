namespace QLSinhVien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dTNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btThem = new System.Windows.Forms.Button();
            this.cbBKhoa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBLop = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBQueQuan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rBt2 = new System.Windows.Forms.RadioButton();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.tbHT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTNgaySinh
            // 
            this.dTNgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dTNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTNgaySinh.Location = new System.Drawing.Point(100, 89);
            this.dTNgaySinh.Name = "dTNgaySinh";
            this.dTNgaySinh.Size = new System.Drawing.Size(338, 22);
            this.dTNgaySinh.TabIndex = 33;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(547, 3);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 31);
            this.btThem.TabIndex = 32;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // cbBKhoa
            // 
            this.cbBKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBKhoa.FormattingEnabled = true;
            this.cbBKhoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Kĩ thuật ô tô",
            "Kế toán",
            "Kĩ thuật cơ khí",
            "Ngôn ngữ Anh",
            "Quản trị "});
            this.cbBKhoa.Location = new System.Drawing.Point(548, 89);
            this.cbBKhoa.Name = "cbBKhoa";
            this.cbBKhoa.Size = new System.Drawing.Size(327, 24);
            this.cbBKhoa.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Khoa";
            // 
            // cbBLop
            // 
            this.cbBLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBLop.FormattingEnabled = true;
            this.cbBLop.Items.AddRange(new object[] {
            "62TH1",
            "62TH1",
            "62TH1",
            "62TH1",
            "62TH1",
            "62HT",
            "62PM1",
            "62PM2",
            "62CNTT-VA",
            "62CNTT-VN"});
            this.cbBLop.Location = new System.Drawing.Point(548, 44);
            this.cbBLop.Name = "cbBLop";
            this.cbBLop.Size = new System.Drawing.Size(327, 24);
            this.cbBLop.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Lớp";
            // 
            // cbBQueQuan
            // 
            this.cbBQueQuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBQueQuan.FormattingEnabled = true;
            this.cbBQueQuan.Items.AddRange(new object[] {
            "An Giang\tKon Tum",
            "Bà Rịa – Vũng Tàu\t",
            "Lai Châu",
            "Bắc Giang\t",
            "Lâm Đồng",
            "Bắc Kạn\t\t",
            "Lạng Sơn",
            "Bạc Liêu\t\t",
            "Lào Cai\t",
            "Bắc Ninh",
            "Long An",
            "Bến Tre\t\t",
            "Nam Định",
            "Bình Định",
            "Nghệ An",
            "Bình Dương\t\t",
            "Ninh Bình",
            "Bình Phước\t\t",
            "Ninh Thuận",
            "Bình Thuận\t\t",
            "Phú Thọ",
            "Cà Mau\t\t",
            "Phú Yên",
            "Cần Thơ\t\t",
            "Quảng Bình",
            "Cao Bằng\t",
            "Quảng Nam",
            "Đà Nẵng\t",
            "Quảng Ngãi",
            "Đắk Lắk\t\t",
            "Quảng Ninh",
            "Đắk Nông",
            "Quảng Trị",
            "Điện Biên\t\t",
            "Sóc Trăng",
            "Đồng Nai\t\t",
            "Sơn La",
            "Đồng Tháp",
            "Tây Ninh",
            "Gia Lai\t\t",
            "Thái Bình",
            "Hà Giang\t\t",
            "Thái Nguyên",
            "Hà Nam\t\t",
            "Thanh Hóa",
            "Hà Nội",
            "Thừa Thiên Huế",
            "Hà Tĩnh\t\t",
            "Tiền Giang",
            "Hải Dương\t\t",
            "TP Hồ Chí Minh",
            "Hải Phòng\t\t",
            "Trà Vinh",
            "Hậu Giang\t\t",
            "Tuyên Quang",
            "Hòa Bình\t61\t",
            "Vĩnh Long",
            "Hưng Yên\t\t",
            "Vĩnh Phúc",
            "Khánh Hòa\t\t",
            "Yên Bái",
            "Kiên Giang"});
            this.cbBQueQuan.Location = new System.Drawing.Point(548, 3);
            this.cbBQueQuan.Name = "cbBQueQuan";
            this.cbBQueQuan.Size = new System.Drawing.Size(327, 24);
            this.cbBQueQuan.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Quê quán";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rBt2
            // 
            this.rBt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rBt2.AutoSize = true;
            this.rBt2.Location = new System.Drawing.Point(278, 9);
            this.rBt2.Name = "rBt2";
            this.rBt2.Size = new System.Drawing.Size(263, 20);
            this.rBt2.TabIndex = 25;
            this.rBt2.TabStop = true;
            this.rBt2.Text = "Nữ";
            this.rBt2.UseVisualStyleBackColor = true;
            // 
            // rbt1
            // 
            this.rbt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbt1.AutoSize = true;
            this.rbt1.Location = new System.Drawing.Point(106, 9);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(166, 20);
            this.rbt1.TabIndex = 24;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "Nam";
            this.rbt1.UseVisualStyleBackColor = true;
            // 
            // tbHT
            // 
            this.tbHT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHT.Location = new System.Drawing.Point(100, 44);
            this.tbHT.Name = "tbHT";
            this.tbHT.Size = new System.Drawing.Size(338, 22);
            this.tbHT.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã SV";
            // 
            // tbMaSV
            // 
            this.tbMaSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaSV.Location = new System.Drawing.Point(100, 3);
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(338, 22);
            this.tbMaSV.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.23396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.66253F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dTNgaySinh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbBKhoa, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbMaSV, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbBLop, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbHT, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbBQueQuan, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.8932F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.09709F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 125);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(-6, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(872, 269);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column2
            // 
            this.Column2.FillWeight = 29.32263F;
            this.Column2.HeaderText = "Mã sinh viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 140F;
            this.Column1.HeaderText = "Họ và tên";
            this.Column1.MinimumWidth = 3;
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 29.32263F;
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 29.32263F;
            this.Column4.HeaderText = "Giới tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 29.32263F;
            this.Column5.HeaderText = "Quê quán";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 29.32263F;
            this.Column6.HeaderText = "Lớp";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.FillWeight = 29.32263F;
            this.Column7.HeaderText = "Khoa";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(771, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 35;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.40157F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.59843F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbt1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rBt2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btThem, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 124);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(878, 38);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 31);
            this.button2.TabIndex = 37;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btSua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 466);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dTNgaySinh;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox cbBKhoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBQueQuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rBt2;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.TextBox tbHT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaSV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

