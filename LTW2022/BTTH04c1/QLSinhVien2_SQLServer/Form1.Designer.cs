namespace QLSinhVien2_SQLServer
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
            this.tc1 = new System.Windows.Forms.TabControl();
            this.tcTinh = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btTinh_Luu = new System.Windows.Forms.Button();
            this.tbMaT = new System.Windows.Forms.TextBox();
            this.tbTenT = new System.Windows.Forms.TextBox();
            this.btTinh_Sua = new System.Windows.Forms.Button();
            this.btTinh_Them = new System.Windows.Forms.Button();
            this.btTinh_Xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgt_Tinh = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgt_Khoa = new System.Windows.Forms.DataGridView();
            this.bt_Luu_Khoa = new System.Windows.Forms.Button();
            this.bt_Xoa_Khoa = new System.Windows.Forms.Button();
            this.bt_Sua_Khoa = new System.Windows.Forms.Button();
            this.bt_Them_Khoa = new System.Windows.Forms.Button();
            this.tb_TenK = new System.Windows.Forms.TextBox();
            this.tb_MaK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tc1.SuspendLayout();
            this.tcTinh.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Tinh)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Khoa)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc1
            // 
            this.tc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc1.Controls.Add(this.tcTinh);
            this.tc1.Controls.Add(this.tabPage1);
            this.tc1.Controls.Add(this.tabPage2);
            this.tc1.Controls.Add(this.tabPage3);
            this.tc1.Location = new System.Drawing.Point(9, 12);
            this.tc1.Name = "tc1";
            this.tc1.SelectedIndex = 0;
            this.tc1.Size = new System.Drawing.Size(785, 426);
            this.tc1.TabIndex = 1;
            // 
            // tcTinh
            // 
            this.tcTinh.Controls.Add(this.tableLayoutPanel1);
            this.tcTinh.Controls.Add(this.dgt_Tinh);
            this.tcTinh.Location = new System.Drawing.Point(4, 25);
            this.tcTinh.Name = "tcTinh";
            this.tcTinh.Padding = new System.Windows.Forms.Padding(3);
            this.tcTinh.Size = new System.Drawing.Size(777, 397);
            this.tcTinh.TabIndex = 1;
            this.tcTinh.Text = "Tỉnh";
            this.tcTinh.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.28999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.00205F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.67699F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.67699F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.67699F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.67699F));
            this.tableLayoutPanel1.Controls.Add(this.btTinh_Luu, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbMaT, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbTenT, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btTinh_Sua, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btTinh_Them, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btTinh_Xoa, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 72);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btTinh_Luu
            // 
            this.btTinh_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTinh_Luu.Location = new System.Drawing.Point(650, 3);
            this.btTinh_Luu.Name = "btTinh_Luu";
            this.tableLayoutPanel1.SetRowSpan(this.btTinh_Luu, 2);
            this.btTinh_Luu.Size = new System.Drawing.Size(110, 61);
            this.btTinh_Luu.TabIndex = 8;
            this.btTinh_Luu.Text = "Lưu";
            this.btTinh_Luu.UseVisualStyleBackColor = true;
            this.btTinh_Luu.Click += new System.EventHandler(this.btTinh_Luu_Click);
            // 
            // tbMaT
            // 
            this.tbMaT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMaT.Location = new System.Drawing.Point(89, 7);
            this.tbMaT.Name = "tbMaT";
            this.tbMaT.Size = new System.Drawing.Size(222, 22);
            this.tbMaT.TabIndex = 2;
            // 
            // tbTenT
            // 
            this.tbTenT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTenT.Location = new System.Drawing.Point(89, 43);
            this.tbTenT.Name = "tbTenT";
            this.tbTenT.Size = new System.Drawing.Size(222, 22);
            this.tbTenT.TabIndex = 3;
            // 
            // btTinh_Sua
            // 
            this.btTinh_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTinh_Sua.Location = new System.Drawing.Point(428, 3);
            this.btTinh_Sua.Name = "btTinh_Sua";
            this.tableLayoutPanel1.SetRowSpan(this.btTinh_Sua, 2);
            this.btTinh_Sua.Size = new System.Drawing.Size(105, 61);
            this.btTinh_Sua.TabIndex = 5;
            this.btTinh_Sua.Text = "Sửa";
            this.btTinh_Sua.UseVisualStyleBackColor = true;
            this.btTinh_Sua.Click += new System.EventHandler(this.btTinh_Sua_Click);
            // 
            // btTinh_Them
            // 
            this.btTinh_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTinh_Them.Location = new System.Drawing.Point(317, 3);
            this.btTinh_Them.Name = "btTinh_Them";
            this.tableLayoutPanel1.SetRowSpan(this.btTinh_Them, 2);
            this.btTinh_Them.Size = new System.Drawing.Size(105, 61);
            this.btTinh_Them.TabIndex = 4;
            this.btTinh_Them.Text = "Thêm";
            this.btTinh_Them.UseVisualStyleBackColor = true;
            this.btTinh_Them.Click += new System.EventHandler(this.btTinh_Them_Click);
            // 
            // btTinh_Xoa
            // 
            this.btTinh_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTinh_Xoa.Location = new System.Drawing.Point(539, 3);
            this.btTinh_Xoa.Name = "btTinh_Xoa";
            this.tableLayoutPanel1.SetRowSpan(this.btTinh_Xoa, 2);
            this.btTinh_Xoa.Size = new System.Drawing.Size(105, 61);
            this.btTinh_Xoa.TabIndex = 6;
            this.btTinh_Xoa.Text = "Xóa";
            this.btTinh_Xoa.UseVisualStyleBackColor = true;
            this.btTinh_Xoa.Click += new System.EventHandler(this.btTinh_Xoa_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tỉnh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tỉnh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgt_Tinh
            // 
            this.dgt_Tinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgt_Tinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgt_Tinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_Tinh.Location = new System.Drawing.Point(6, 84);
            this.dgt_Tinh.Name = "dgt_Tinh";
            this.dgt_Tinh.RowHeadersWidth = 51;
            this.dgt_Tinh.RowTemplate.Height = 24;
            this.dgt_Tinh.Size = new System.Drawing.Size(765, 308);
            this.dgt_Tinh.TabIndex = 7;
            this.dgt_Tinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgt_Tinh_CellClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.dgt_Khoa);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 397);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Khoa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgt_Khoa
            // 
            this.dgt_Khoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgt_Khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_Khoa.Location = new System.Drawing.Point(3, 77);
            this.dgt_Khoa.Name = "dgt_Khoa";
            this.dgt_Khoa.RowHeadersWidth = 51;
            this.dgt_Khoa.RowTemplate.Height = 24;
            this.dgt_Khoa.Size = new System.Drawing.Size(764, 314);
            this.dgt_Khoa.TabIndex = 17;
            // 
            // bt_Luu_Khoa
            // 
            this.bt_Luu_Khoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Luu_Khoa.Location = new System.Drawing.Point(671, 3);
            this.bt_Luu_Khoa.Name = "bt_Luu_Khoa";
            this.tableLayoutPanel2.SetRowSpan(this.bt_Luu_Khoa, 2);
            this.bt_Luu_Khoa.Size = new System.Drawing.Size(90, 61);
            this.bt_Luu_Khoa.TabIndex = 16;
            this.bt_Luu_Khoa.Text = "Lưu";
            this.bt_Luu_Khoa.UseVisualStyleBackColor = true;
            // 
            // bt_Xoa_Khoa
            // 
            this.bt_Xoa_Khoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Xoa_Khoa.Location = new System.Drawing.Point(561, 3);
            this.bt_Xoa_Khoa.Name = "bt_Xoa_Khoa";
            this.tableLayoutPanel2.SetRowSpan(this.bt_Xoa_Khoa, 2);
            this.bt_Xoa_Khoa.Size = new System.Drawing.Size(90, 61);
            this.bt_Xoa_Khoa.TabIndex = 15;
            this.bt_Xoa_Khoa.Text = "Xóa";
            this.bt_Xoa_Khoa.UseVisualStyleBackColor = true;
            this.bt_Xoa_Khoa.Click += new System.EventHandler(this.bt_Xoa_Khoa_Click);
            // 
            // bt_Sua_Khoa
            // 
            this.bt_Sua_Khoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Sua_Khoa.Location = new System.Drawing.Point(456, 3);
            this.bt_Sua_Khoa.Name = "bt_Sua_Khoa";
            this.tableLayoutPanel2.SetRowSpan(this.bt_Sua_Khoa, 2);
            this.bt_Sua_Khoa.Size = new System.Drawing.Size(90, 61);
            this.bt_Sua_Khoa.TabIndex = 14;
            this.bt_Sua_Khoa.Text = "Sửa";
            this.bt_Sua_Khoa.UseVisualStyleBackColor = true;
            this.bt_Sua_Khoa.Click += new System.EventHandler(this.bt_Sua_Khoa_Click);
            // 
            // bt_Them_Khoa
            // 
            this.bt_Them_Khoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Them_Khoa.Location = new System.Drawing.Point(351, 3);
            this.bt_Them_Khoa.Name = "bt_Them_Khoa";
            this.tableLayoutPanel2.SetRowSpan(this.bt_Them_Khoa, 2);
            this.bt_Them_Khoa.Size = new System.Drawing.Size(90, 61);
            this.bt_Them_Khoa.TabIndex = 13;
            this.bt_Them_Khoa.Text = "Thêm";
            this.bt_Them_Khoa.UseVisualStyleBackColor = true;
            this.bt_Them_Khoa.Click += new System.EventHandler(this.bt_Them_Khoa_Click);
            // 
            // tb_TenK
            // 
            this.tb_TenK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_TenK.Location = new System.Drawing.Point(91, 40);
            this.tb_TenK.Name = "tb_TenK";
            this.tb_TenK.Size = new System.Drawing.Size(241, 22);
            this.tb_TenK.TabIndex = 12;
            // 
            // tb_MaK
            // 
            this.tb_MaK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_MaK.Location = new System.Drawing.Point(91, 6);
            this.tb_MaK.Name = "tb_MaK";
            this.tb_MaK.Size = new System.Drawing.Size(241, 22);
            this.tb_MaK.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên khoa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã khoa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 397);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Lớp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(757, 319);
            this.dataGridView2.TabIndex = 25;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(679, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 61);
            this.button5.TabIndex = 24;
            this.button5.Text = "Lưu";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(583, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 61);
            this.button6.TabIndex = 23;
            this.button6.Text = "Xóa";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(478, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 61);
            this.button7.TabIndex = 22;
            this.button7.Text = "Sửa";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(382, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 61);
            this.button8.TabIndex = 21;
            this.button8.Text = "Thêm";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(126, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 22);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(126, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(241, 22);
            this.textBox4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tên lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mã lớp";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(777, 397);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Sinh viên";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.20807F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.30182F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.87253F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.87253F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.87253F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.87253F));
            this.tableLayoutPanel2.Controls.Add(this.tb_MaK, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_TenK, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.bt_Luu_Khoa, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_Xoa_Khoa, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bt_Sua_Khoa, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_Them_Khoa, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(764, 68);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.tc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tc1.ResumeLayout(false);
            this.tcTinh.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Tinh)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Khoa)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc1;
        private System.Windows.Forms.TabPage tcTinh;
        private System.Windows.Forms.Button btTinh_Luu;
        private System.Windows.Forms.DataGridView dgt_Tinh;
        private System.Windows.Forms.Button btTinh_Xoa;
        private System.Windows.Forms.Button btTinh_Sua;
        private System.Windows.Forms.Button btTinh_Them;
        private System.Windows.Forms.TextBox tbTenT;
        private System.Windows.Forms.TextBox tbMaT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgt_Khoa;
        private System.Windows.Forms.Button bt_Luu_Khoa;
        private System.Windows.Forms.Button bt_Xoa_Khoa;
        private System.Windows.Forms.Button bt_Sua_Khoa;
        private System.Windows.Forms.Button bt_Them_Khoa;
        private System.Windows.Forms.TextBox tb_TenK;
        private System.Windows.Forms.TextBox tb_MaK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

