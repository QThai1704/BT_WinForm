namespace BaiTapLon
{
    partial class Form_KhoHang
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
            this.dtg_KhoHang = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbb_MaSP = new System.Windows.Forms.ComboBox();
            this.lb_CTMaKho = new System.Windows.Forms.Label();
            this.tb_Ghichu = new System.Windows.Forms.TextBox();
            this.lb_Ghichu = new System.Windows.Forms.Label();
            this.tb_SoLuong = new System.Windows.Forms.TextBox();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.kb_TenSP = new System.Windows.Forms.Label();
            this.lb_MaSP = new System.Windows.Forms.Label();
            this.cbb_MaKho = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tct_Kho = new System.Windows.Forms.TabControl();
            this.tP_CTKho = new System.Windows.Forms.TabPage();
            this.tP_KhoHang = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btK_Xoa = new System.Windows.Forms.Button();
            this.btK_Them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_TenKho = new System.Windows.Forms.Label();
            this.lb_MaKho = new System.Windows.Forms.Label();
            this.tP_SP = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tbS_TenSP = new System.Windows.Forms.TextBox();
            this.tbS_MaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btS_Xoa = new System.Windows.Forms.Button();
            this.btS_Them = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_KhoHang)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tct_Kho.SuspendLayout();
            this.tP_CTKho.SuspendLayout();
            this.tP_KhoHang.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tP_SP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_KhoHang
            // 
            this.dtg_KhoHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_KhoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_KhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_KhoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtg_KhoHang.Location = new System.Drawing.Point(0, 54);
            this.dtg_KhoHang.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_KhoHang.Name = "dtg_KhoHang";
            this.dtg_KhoHang.RowHeadersWidth = 51;
            this.dtg_KhoHang.RowTemplate.Height = 24;
            this.dtg_KhoHang.Size = new System.Drawing.Size(556, 608);
            this.dtg_KhoHang.TabIndex = 0;
            this.dtg_KhoHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_KhoHang_CellClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mã kho";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ghi chú";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightCoral;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbb_MaSP, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_CTMaKho, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Ghichu, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lb_Ghichu, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tb_SoLuong, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lb_SoLuong, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.kb_TenSP, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_MaSP, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbb_MaKho, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(559, 54);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 492);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbb_MaSP
            // 
            this.cbb_MaSP.FormattingEnabled = true;
            this.cbb_MaSP.Location = new System.Drawing.Point(3, 150);
            this.cbb_MaSP.Name = "cbb_MaSP";
            this.cbb_MaSP.Size = new System.Drawing.Size(335, 26);
            this.cbb_MaSP.TabIndex = 9;
            // 
            // lb_CTMaKho
            // 
            this.lb_CTMaKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_CTMaKho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CTMaKho.Location = new System.Drawing.Point(4, 0);
            this.lb_CTMaKho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CTMaKho.Name = "lb_CTMaKho";
            this.lb_CTMaKho.Size = new System.Drawing.Size(333, 44);
            this.lb_CTMaKho.TabIndex = 5;
            this.lb_CTMaKho.Text = "Mã kho";
            // 
            // tb_Ghichu
            // 
            this.tb_Ghichu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ghichu.Location = new System.Drawing.Point(4, 445);
            this.tb_Ghichu.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Ghichu.Multiline = true;
            this.tb_Ghichu.Name = "tb_Ghichu";
            this.tb_Ghichu.Size = new System.Drawing.Size(333, 43);
            this.tb_Ghichu.TabIndex = 7;
            // 
            // lb_Ghichu
            // 
            this.lb_Ghichu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Ghichu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ghichu.Location = new System.Drawing.Point(4, 392);
            this.lb_Ghichu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Ghichu.Name = "lb_Ghichu";
            this.lb_Ghichu.Size = new System.Drawing.Size(333, 39);
            this.lb_Ghichu.TabIndex = 3;
            this.lb_Ghichu.Text = "Ghi chú";
            // 
            // tb_SoLuong
            // 
            this.tb_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoLuong.Location = new System.Drawing.Point(4, 347);
            this.tb_SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.tb_SoLuong.Name = "tb_SoLuong";
            this.tb_SoLuong.Size = new System.Drawing.Size(333, 24);
            this.tb_SoLuong.TabIndex = 6;
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SoLuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLuong.Location = new System.Drawing.Point(4, 294);
            this.lb_SoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(333, 38);
            this.lb_SoLuong.TabIndex = 2;
            this.lb_SoLuong.Text = "Số lượng";
            // 
            // kb_TenSP
            // 
            this.kb_TenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kb_TenSP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kb_TenSP.Location = new System.Drawing.Point(4, 196);
            this.kb_TenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kb_TenSP.Name = "kb_TenSP";
            this.kb_TenSP.Size = new System.Drawing.Size(333, 40);
            this.kb_TenSP.TabIndex = 1;
            this.kb_TenSP.Text = "Tên sản phẩm";
            // 
            // lb_MaSP
            // 
            this.lb_MaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_MaSP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaSP.Location = new System.Drawing.Point(4, 98);
            this.lb_MaSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_MaSP.Name = "lb_MaSP";
            this.lb_MaSP.Size = new System.Drawing.Size(333, 44);
            this.lb_MaSP.TabIndex = 0;
            this.lb_MaSP.Text = "Mã sản phẩm";
            // 
            // cbb_MaKho
            // 
            this.cbb_MaKho.FormattingEnabled = true;
            this.cbb_MaKho.Location = new System.Drawing.Point(3, 52);
            this.cbb_MaKho.Name = "cbb_MaKho";
            this.cbb_MaKho.Size = new System.Drawing.Size(335, 26);
            this.cbb_MaKho.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Moccasin;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.bt_Luu, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.bt_Xoa, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bt_Sua, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_Them, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(559, 550);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(341, 112);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // bt_Luu
            // 
            this.bt_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Luu.BackColor = System.Drawing.Color.Cyan;
            this.bt_Luu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.Location = new System.Drawing.Point(174, 60);
            this.bt_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(163, 48);
            this.bt_Luu.TabIndex = 3;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = false;
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Xoa.BackColor = System.Drawing.Color.Red;
            this.bt_Xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.Location = new System.Drawing.Point(4, 60);
            this.bt_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(162, 48);
            this.bt_Xoa.TabIndex = 2;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = false;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Sua.BackColor = System.Drawing.Color.Yellow;
            this.bt_Sua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sua.Location = new System.Drawing.Point(174, 4);
            this.bt_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(163, 48);
            this.bt_Sua.TabIndex = 1;
            this.bt_Sua.Text = "Chỉnh sửa";
            this.bt_Sua.UseVisualStyleBackColor = false;
            // 
            // bt_Them
            // 
            this.bt_Them.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Them.BackColor = System.Drawing.Color.Lime;
            this.bt_Them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Location = new System.Drawing.Point(4, 4);
            this.bt_Them.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(162, 48);
            this.bt_Them.TabIndex = 0;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = false;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // lb_title
            // 
            this.lb_title.BackColor = System.Drawing.Color.Yellow;
            this.lb_title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(1, 0);
            this.lb_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(555, 50);
            this.lb_title.TabIndex = 3;
            this.lb_title.Text = "Kho hàng";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.25806F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.74194F));
            this.tableLayoutPanel3.Controls.Add(this.bt_TimKiem, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(559, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(341, 50);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TimKiem.Location = new System.Drawing.Point(250, 4);
            this.bt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(87, 42);
            this.bt_TimKiem.TabIndex = 3;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 42);
            this.textBox1.TabIndex = 2;
            // 
            // tct_Kho
            // 
            this.tct_Kho.Controls.Add(this.tP_CTKho);
            this.tct_Kho.Controls.Add(this.tP_KhoHang);
            this.tct_Kho.Controls.Add(this.tP_SP);
            this.tct_Kho.Location = new System.Drawing.Point(0, 0);
            this.tct_Kho.Name = "tct_Kho";
            this.tct_Kho.SelectedIndex = 0;
            this.tct_Kho.Size = new System.Drawing.Size(908, 693);
            this.tct_Kho.TabIndex = 5;
            // 
            // tP_CTKho
            // 
            this.tP_CTKho.Controls.Add(this.lb_title);
            this.tP_CTKho.Controls.Add(this.tableLayoutPanel2);
            this.tP_CTKho.Controls.Add(this.tableLayoutPanel3);
            this.tP_CTKho.Controls.Add(this.tableLayoutPanel1);
            this.tP_CTKho.Controls.Add(this.dtg_KhoHang);
            this.tP_CTKho.Location = new System.Drawing.Point(4, 27);
            this.tP_CTKho.Name = "tP_CTKho";
            this.tP_CTKho.Padding = new System.Windows.Forms.Padding(3);
            this.tP_CTKho.Size = new System.Drawing.Size(900, 662);
            this.tP_CTKho.TabIndex = 0;
            this.tP_CTKho.Text = "Chi tiết kho";
            this.tP_CTKho.UseVisualStyleBackColor = true;
            this.tP_CTKho.Click += new System.EventHandler(this.tP_CTKho_Click);
            // 
            // tP_KhoHang
            // 
            this.tP_KhoHang.Controls.Add(this.tableLayoutPanel4);
            this.tP_KhoHang.Controls.Add(this.dataGridView1);
            this.tP_KhoHang.Controls.Add(this.textBox3);
            this.tP_KhoHang.Controls.Add(this.textBox2);
            this.tP_KhoHang.Controls.Add(this.lb_TenKho);
            this.tP_KhoHang.Controls.Add(this.lb_MaKho);
            this.tP_KhoHang.Location = new System.Drawing.Point(4, 27);
            this.tP_KhoHang.Name = "tP_KhoHang";
            this.tP_KhoHang.Padding = new System.Windows.Forms.Padding(3);
            this.tP_KhoHang.Size = new System.Drawing.Size(900, 662);
            this.tP_KhoHang.TabIndex = 1;
            this.tP_KhoHang.Text = "Kho hàng";
            this.tP_KhoHang.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btK_Xoa, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btK_Them, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(614, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(279, 65);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btK_Xoa
            // 
            this.btK_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btK_Xoa.Location = new System.Drawing.Point(142, 3);
            this.btK_Xoa.Name = "btK_Xoa";
            this.tableLayoutPanel4.SetRowSpan(this.btK_Xoa, 2);
            this.btK_Xoa.Size = new System.Drawing.Size(134, 59);
            this.btK_Xoa.TabIndex = 7;
            this.btK_Xoa.Text = "Xóa";
            this.btK_Xoa.UseVisualStyleBackColor = true;
            // 
            // btK_Them
            // 
            this.btK_Them.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btK_Them.Location = new System.Drawing.Point(3, 3);
            this.btK_Them.Name = "btK_Them";
            this.tableLayoutPanel4.SetRowSpan(this.btK_Them, 2);
            this.btK_Them.Size = new System.Drawing.Size(133, 59);
            this.btK_Them.TabIndex = 6;
            this.btK_Them.Text = "Thêm";
            this.btK_Them.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(891, 568);
            this.dataGridView1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(149, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(425, 24);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(149, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(425, 24);
            this.textBox2.TabIndex = 1;
            // 
            // lb_TenKho
            // 
            this.lb_TenKho.AutoSize = true;
            this.lb_TenKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenKho.Location = new System.Drawing.Point(6, 62);
            this.lb_TenKho.Name = "lb_TenKho";
            this.lb_TenKho.Size = new System.Drawing.Size(75, 20);
            this.lb_TenKho.TabIndex = 1;
            this.lb_TenKho.Text = "Tên kho";
            // 
            // lb_MaKho
            // 
            this.lb_MaKho.AutoSize = true;
            this.lb_MaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaKho.Location = new System.Drawing.Point(6, 21);
            this.lb_MaKho.Name = "lb_MaKho";
            this.lb_MaKho.Size = new System.Drawing.Size(69, 20);
            this.lb_MaKho.TabIndex = 0;
            this.lb_MaKho.Text = "Mã kho";
            // 
            // tP_SP
            // 
            this.tP_SP.Controls.Add(this.tableLayoutPanel5);
            this.tP_SP.Controls.Add(this.tbS_TenSP);
            this.tP_SP.Controls.Add(this.tbS_MaSP);
            this.tP_SP.Controls.Add(this.label1);
            this.tP_SP.Controls.Add(this.label2);
            this.tP_SP.Controls.Add(this.dataGridView2);
            this.tP_SP.Location = new System.Drawing.Point(4, 27);
            this.tP_SP.Name = "tP_SP";
            this.tP_SP.Padding = new System.Windows.Forms.Padding(3);
            this.tP_SP.Size = new System.Drawing.Size(900, 662);
            this.tP_SP.TabIndex = 2;
            this.tP_SP.Text = "Sản phẩm";
            this.tP_SP.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 91);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(895, 568);
            this.dataGridView2.TabIndex = 5;
            // 
            // tbS_TenSP
            // 
            this.tbS_TenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbS_TenSP.Location = new System.Drawing.Point(151, 52);
            this.tbS_TenSP.Name = "tbS_TenSP";
            this.tbS_TenSP.Size = new System.Drawing.Size(425, 24);
            this.tbS_TenSP.TabIndex = 9;
            // 
            // tbS_MaSP
            // 
            this.tbS_MaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbS_MaSP.Location = new System.Drawing.Point(151, 11);
            this.tbS_MaSP.Name = "tbS_MaSP";
            this.tbS_MaSP.Size = new System.Drawing.Size(425, 24);
            this.tbS_MaSP.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã sản phẩm";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btS_Xoa, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btS_Them, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(614, 11);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(279, 65);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // btS_Xoa
            // 
            this.btS_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btS_Xoa.Location = new System.Drawing.Point(142, 3);
            this.btS_Xoa.Name = "btS_Xoa";
            this.tableLayoutPanel5.SetRowSpan(this.btS_Xoa, 2);
            this.btS_Xoa.Size = new System.Drawing.Size(134, 59);
            this.btS_Xoa.TabIndex = 7;
            this.btS_Xoa.Text = "Xóa";
            this.btS_Xoa.UseVisualStyleBackColor = true;
            // 
            // btS_Them
            // 
            this.btS_Them.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btS_Them.Location = new System.Drawing.Point(3, 3);
            this.btS_Them.Name = "btS_Them";
            this.tableLayoutPanel5.SetRowSpan(this.btS_Them, 2);
            this.btS_Them.Size = new System.Drawing.Size(133, 59);
            this.btS_Them.TabIndex = 6;
            this.btS_Them.Text = "Thêm";
            this.btS_Them.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 248);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 26);
            this.comboBox1.TabIndex = 10;
            // 
            // Form_KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 692);
            this.Controls.Add(this.tct_Kho);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_KhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho hàng";
            this.Load += new System.EventHandler(this.Form_KhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_KhoHang)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tct_Kho.ResumeLayout(false);
            this.tP_CTKho.ResumeLayout(false);
            this.tP_KhoHang.ResumeLayout(false);
            this.tP_KhoHang.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tP_SP.ResumeLayout(false);
            this.tP_SP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_KhoHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.TextBox tb_Ghichu;
        private System.Windows.Forms.TextBox tb_SoLuong;
        private System.Windows.Forms.Label lb_MaSP;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.Label lb_Ghichu;
        private System.Windows.Forms.Label kb_TenSP;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.ComboBox cbb_MaSP;
        private System.Windows.Forms.Label lb_CTMaKho;
        private System.Windows.Forms.ComboBox cbb_MaKho;
        private System.Windows.Forms.TabControl tct_Kho;
        private System.Windows.Forms.TabPage tP_CTKho;
        private System.Windows.Forms.TabPage tP_KhoHang;
        private System.Windows.Forms.TabPage tP_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lb_TenKho;
        private System.Windows.Forms.Label lb_MaKho;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btK_Xoa;
        private System.Windows.Forms.Button btK_Them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btS_Xoa;
        private System.Windows.Forms.Button btS_Them;
        private System.Windows.Forms.TextBox tbS_TenSP;
        private System.Windows.Forms.TextBox tbS_MaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}