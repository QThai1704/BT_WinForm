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
            this.dtg_CTKho = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbb_TenSP = new System.Windows.Forms.ComboBox();
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
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.tct_Kho = new System.Windows.Forms.TabControl();
            this.tP_CTKho = new System.Windows.Forms.TabPage();
            this.tP_KhoHang = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btK_Them = new System.Windows.Forms.Button();
            this.btK_Xoa = new System.Windows.Forms.Button();
            this.btK_Sua = new System.Windows.Forms.Button();
            this.dtg_Kho = new System.Windows.Forms.DataGridView();
            this.tbK_TenK = new System.Windows.Forms.TextBox();
            this.tbK_MaK = new System.Windows.Forms.TextBox();
            this.lb_TenKho = new System.Windows.Forms.Label();
            this.lb_MaKho = new System.Windows.Forms.Label();
            this.tP_SP = new System.Windows.Forms.TabPage();
            this.tbS_DonG = new System.Windows.Forms.TextBox();
            this.lb_DonG = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btS_Them = new System.Windows.Forms.Button();
            this.btS_Xoa = new System.Windows.Forms.Button();
            this.btS_Sua = new System.Windows.Forms.Button();
            this.tbS_TenSP = new System.Windows.Forms.TextBox();
            this.tbS_MaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_SP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CTKho)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tct_Kho.SuspendLayout();
            this.tP_CTKho.SuspendLayout();
            this.tP_KhoHang.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Kho)).BeginInit();
            this.tP_SP.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_CTKho
            // 
            this.dtg_CTKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_CTKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_CTKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtg_CTKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_CTKho.Location = new System.Drawing.Point(0, 54);
            this.dtg_CTKho.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_CTKho.Name = "dtg_CTKho";
            this.dtg_CTKho.ReadOnly = true;
            this.dtg_CTKho.RowHeadersWidth = 51;
            this.dtg_CTKho.RowTemplate.Height = 24;
            this.dtg_CTKho.Size = new System.Drawing.Size(556, 608);
            this.dtg_CTKho.TabIndex = 100;
            this.dtg_CTKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CTKho_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightCoral;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cbb_TenSP, 0, 5);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.674797F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.65041F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 492);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbb_TenSP
            // 
            this.cbb_TenSP.FormattingEnabled = true;
            this.cbb_TenSP.Location = new System.Drawing.Point(3, 248);
            this.cbb_TenSP.Name = "cbb_TenSP";
            this.cbb_TenSP.Size = new System.Drawing.Size(335, 26);
            this.cbb_TenSP.TabIndex = 3;
            // 
            // cbb_MaSP
            // 
            this.cbb_MaSP.FormattingEnabled = true;
            this.cbb_MaSP.Location = new System.Drawing.Point(3, 150);
            this.cbb_MaSP.Name = "cbb_MaSP";
            this.cbb_MaSP.Size = new System.Drawing.Size(335, 26);
            this.cbb_MaSP.TabIndex = 2;
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
            this.tb_Ghichu.Location = new System.Drawing.Point(4, 418);
            this.tb_Ghichu.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Ghichu.Multiline = true;
            this.tb_Ghichu.Name = "tb_Ghichu";
            this.tb_Ghichu.Size = new System.Drawing.Size(333, 70);
            this.tb_Ghichu.TabIndex = 5;
            // 
            // lb_Ghichu
            // 
            this.lb_Ghichu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Ghichu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ghichu.Location = new System.Drawing.Point(4, 392);
            this.lb_Ghichu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Ghichu.Name = "lb_Ghichu";
            this.lb_Ghichu.Size = new System.Drawing.Size(333, 22);
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
            this.tb_SoLuong.TabIndex = 4;
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
            this.cbb_MaKho.TabIndex = 1;
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
            this.bt_Luu.TabIndex = 9;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = false;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
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
            this.bt_Xoa.TabIndex = 8;
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
            this.bt_Sua.TabIndex = 7;
            this.bt_Sua.Text = "Chỉnh sửa";
            this.bt_Sua.UseVisualStyleBackColor = false;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
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
            this.bt_Them.TabIndex = 6;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = false;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // lb_title
            // 
            this.lb_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title.BackColor = System.Drawing.Color.Yellow;
            this.lb_title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(1, 0);
            this.lb_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(555, 50);
            this.lb_title.TabIndex = 3;
            this.lb_title.Text = "Chi tiết kho hàng";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.25806F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.74194F));
            this.tableLayoutPanel3.Controls.Add(this.bt_TimKiem, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_TimKiem, 0, 0);
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
            this.bt_TimKiem.TabIndex = 11;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.UseVisualStyleBackColor = true;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem.Location = new System.Drawing.Point(4, 4);
            this.tb_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TimKiem.Multiline = true;
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(238, 42);
            this.tb_TimKiem.TabIndex = 10;
            // 
            // tct_Kho
            // 
            this.tct_Kho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tP_CTKho.Controls.Add(this.dtg_CTKho);
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
            this.tP_KhoHang.Controls.Add(this.dtg_Kho);
            this.tP_KhoHang.Controls.Add(this.tbK_TenK);
            this.tP_KhoHang.Controls.Add(this.tbK_MaK);
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
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btK_Them, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btK_Xoa, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btK_Sua, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(614, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(279, 65);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btK_Them
            // 
            this.btK_Them.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btK_Them.BackColor = System.Drawing.Color.Lime;
            this.btK_Them.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btK_Them.Location = new System.Drawing.Point(3, 3);
            this.btK_Them.Name = "btK_Them";
            this.tableLayoutPanel4.SetRowSpan(this.btK_Them, 2);
            this.btK_Them.Size = new System.Drawing.Size(87, 59);
            this.btK_Them.TabIndex = 3;
            this.btK_Them.Text = "Thêm";
            this.btK_Them.UseVisualStyleBackColor = false;
            this.btK_Them.Click += new System.EventHandler(this.btK_Them_Click);
            // 
            // btK_Xoa
            // 
            this.btK_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btK_Xoa.BackColor = System.Drawing.Color.Red;
            this.btK_Xoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btK_Xoa.Location = new System.Drawing.Point(189, 3);
            this.btK_Xoa.Name = "btK_Xoa";
            this.tableLayoutPanel4.SetRowSpan(this.btK_Xoa, 2);
            this.btK_Xoa.Size = new System.Drawing.Size(87, 59);
            this.btK_Xoa.TabIndex = 5;
            this.btK_Xoa.Text = "Xóa";
            this.btK_Xoa.UseVisualStyleBackColor = false;
            this.btK_Xoa.Click += new System.EventHandler(this.btK_Xoa_Click);
            // 
            // btK_Sua
            // 
            this.btK_Sua.BackColor = System.Drawing.Color.Yellow;
            this.btK_Sua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btK_Sua.Location = new System.Drawing.Point(96, 3);
            this.btK_Sua.Name = "btK_Sua";
            this.tableLayoutPanel4.SetRowSpan(this.btK_Sua, 2);
            this.btK_Sua.Size = new System.Drawing.Size(87, 59);
            this.btK_Sua.TabIndex = 4;
            this.btK_Sua.Text = "Sửa";
            this.btK_Sua.UseVisualStyleBackColor = false;
            this.btK_Sua.Click += new System.EventHandler(this.btK_Sua_Click);
            // 
            // dtg_Kho
            // 
            this.dtg_Kho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Kho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Kho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtg_Kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Kho.Location = new System.Drawing.Point(6, 88);
            this.dtg_Kho.Name = "dtg_Kho";
            this.dtg_Kho.ReadOnly = true;
            this.dtg_Kho.RowHeadersWidth = 51;
            this.dtg_Kho.RowTemplate.Height = 24;
            this.dtg_Kho.Size = new System.Drawing.Size(891, 568);
            this.dtg_Kho.TabIndex = 100;
            this.dtg_Kho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Kho_CellClick);
            // 
            // tbK_TenK
            // 
            this.tbK_TenK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbK_TenK.Location = new System.Drawing.Point(149, 58);
            this.tbK_TenK.Name = "tbK_TenK";
            this.tbK_TenK.Size = new System.Drawing.Size(425, 24);
            this.tbK_TenK.TabIndex = 2;
            // 
            // tbK_MaK
            // 
            this.tbK_MaK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbK_MaK.Location = new System.Drawing.Point(149, 17);
            this.tbK_MaK.Name = "tbK_MaK";
            this.tbK_MaK.Size = new System.Drawing.Size(425, 24);
            this.tbK_MaK.TabIndex = 1;
            // 
            // lb_TenKho
            // 
            this.lb_TenKho.AutoSize = true;
            this.lb_TenKho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenKho.Location = new System.Drawing.Point(6, 62);
            this.lb_TenKho.Name = "lb_TenKho";
            this.lb_TenKho.Size = new System.Drawing.Size(67, 19);
            this.lb_TenKho.TabIndex = 1;
            this.lb_TenKho.Text = "Tên kho";
            this.lb_TenKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_MaKho
            // 
            this.lb_MaKho.AutoSize = true;
            this.lb_MaKho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaKho.Location = new System.Drawing.Point(6, 21);
            this.lb_MaKho.Name = "lb_MaKho";
            this.lb_MaKho.Size = new System.Drawing.Size(64, 19);
            this.lb_MaKho.TabIndex = 0;
            this.lb_MaKho.Text = "Mã kho";
            this.lb_MaKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tP_SP
            // 
            this.tP_SP.Controls.Add(this.tbS_DonG);
            this.tP_SP.Controls.Add(this.lb_DonG);
            this.tP_SP.Controls.Add(this.tableLayoutPanel5);
            this.tP_SP.Controls.Add(this.tbS_TenSP);
            this.tP_SP.Controls.Add(this.tbS_MaSP);
            this.tP_SP.Controls.Add(this.label1);
            this.tP_SP.Controls.Add(this.label2);
            this.tP_SP.Controls.Add(this.dtg_SP);
            this.tP_SP.Location = new System.Drawing.Point(4, 27);
            this.tP_SP.Name = "tP_SP";
            this.tP_SP.Padding = new System.Windows.Forms.Padding(3);
            this.tP_SP.Size = new System.Drawing.Size(900, 662);
            this.tP_SP.TabIndex = 2;
            this.tP_SP.Text = "Sản phẩm";
            this.tP_SP.UseVisualStyleBackColor = true;
            // 
            // tbS_DonG
            // 
            this.tbS_DonG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbS_DonG.Location = new System.Drawing.Point(151, 95);
            this.tbS_DonG.Name = "tbS_DonG";
            this.tbS_DonG.Size = new System.Drawing.Size(425, 24);
            this.tbS_DonG.TabIndex = 3;
            // 
            // lb_DonG
            // 
            this.lb_DonG.AutoSize = true;
            this.lb_DonG.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DonG.Location = new System.Drawing.Point(8, 95);
            this.lb_DonG.Name = "lb_DonG";
            this.lb_DonG.Size = new System.Drawing.Size(66, 19);
            this.lb_DonG.TabIndex = 11;
            this.lb_DonG.Text = "Đơn giá";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.btS_Them, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btS_Xoa, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btS_Sua, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(614, 11);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(279, 65);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // btS_Them
            // 
            this.btS_Them.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btS_Them.BackColor = System.Drawing.Color.Lime;
            this.btS_Them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btS_Them.Location = new System.Drawing.Point(3, 3);
            this.btS_Them.Name = "btS_Them";
            this.tableLayoutPanel5.SetRowSpan(this.btS_Them, 2);
            this.btS_Them.Size = new System.Drawing.Size(87, 59);
            this.btS_Them.TabIndex = 4;
            this.btS_Them.Text = "Thêm";
            this.btS_Them.UseVisualStyleBackColor = false;
            this.btS_Them.Click += new System.EventHandler(this.btS_Them_Click);
            // 
            // btS_Xoa
            // 
            this.btS_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btS_Xoa.BackColor = System.Drawing.Color.Red;
            this.btS_Xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btS_Xoa.Location = new System.Drawing.Point(189, 3);
            this.btS_Xoa.Name = "btS_Xoa";
            this.tableLayoutPanel5.SetRowSpan(this.btS_Xoa, 2);
            this.btS_Xoa.Size = new System.Drawing.Size(87, 59);
            this.btS_Xoa.TabIndex = 6;
            this.btS_Xoa.Text = "Xóa";
            this.btS_Xoa.UseVisualStyleBackColor = false;
            this.btS_Xoa.Click += new System.EventHandler(this.btS_Xoa_Click);
            // 
            // btS_Sua
            // 
            this.btS_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btS_Sua.BackColor = System.Drawing.Color.Yellow;
            this.btS_Sua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btS_Sua.Location = new System.Drawing.Point(96, 3);
            this.btS_Sua.Name = "btS_Sua";
            this.tableLayoutPanel5.SetRowSpan(this.btS_Sua, 2);
            this.btS_Sua.Size = new System.Drawing.Size(87, 59);
            this.btS_Sua.TabIndex = 5;
            this.btS_Sua.Text = "Sửa";
            this.btS_Sua.UseVisualStyleBackColor = false;
            this.btS_Sua.Click += new System.EventHandler(this.btS_Sua_Click);
            // 
            // tbS_TenSP
            // 
            this.tbS_TenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbS_TenSP.Location = new System.Drawing.Point(151, 52);
            this.tbS_TenSP.Name = "tbS_TenSP";
            this.tbS_TenSP.Size = new System.Drawing.Size(425, 24);
            this.tbS_TenSP.TabIndex = 2;
            // 
            // tbS_MaSP
            // 
            this.tbS_MaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbS_MaSP.Location = new System.Drawing.Point(151, 11);
            this.tbS_MaSP.Name = "tbS_MaSP";
            this.tbS_MaSP.Size = new System.Drawing.Size(425, 24);
            this.tbS_MaSP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã sản phẩm";
            // 
            // dtg_SP
            // 
            this.dtg_SP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_SP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_SP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtg_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SP.Location = new System.Drawing.Point(2, 135);
            this.dtg_SP.Name = "dtg_SP";
            this.dtg_SP.ReadOnly = true;
            this.dtg_SP.RowHeadersWidth = 51;
            this.dtg_SP.RowTemplate.Height = 24;
            this.dtg_SP.Size = new System.Drawing.Size(895, 524);
            this.dtg_SP.TabIndex = 100;
            this.dtg_SP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_SP_CellClick);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CTKho)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Kho)).EndInit();
            this.tP_SP.ResumeLayout(false);
            this.tP_SP.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_CTKho;
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
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.ComboBox cbb_MaSP;
        private System.Windows.Forms.Label lb_CTMaKho;
        private System.Windows.Forms.ComboBox cbb_MaKho;
        private System.Windows.Forms.TabControl tct_Kho;
        private System.Windows.Forms.TabPage tP_CTKho;
        private System.Windows.Forms.TabPage tP_KhoHang;
        private System.Windows.Forms.TabPage tP_SP;
        private System.Windows.Forms.Label lb_TenKho;
        private System.Windows.Forms.Label lb_MaKho;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btK_Xoa;
        private System.Windows.Forms.Button btK_Them;
        private System.Windows.Forms.DataGridView dtg_Kho;
        private System.Windows.Forms.TextBox tbK_TenK;
        private System.Windows.Forms.TextBox tbK_MaK;
        private System.Windows.Forms.DataGridView dtg_SP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btS_Xoa;
        private System.Windows.Forms.Button btS_Them;
        private System.Windows.Forms.TextBox tbS_TenSP;
        private System.Windows.Forms.TextBox tbS_MaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_TenSP;
        private System.Windows.Forms.TextBox tbS_DonG;
        private System.Windows.Forms.Label lb_DonG;
        private System.Windows.Forms.Button btS_Sua;
        private System.Windows.Forms.Button btK_Sua;
    }
}