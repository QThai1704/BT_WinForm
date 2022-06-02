namespace BaiTapLon
{
    partial class form_QuanLyBanHang
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLíCửaHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_QLKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_SP = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Kho = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_TaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.dtg_ThongKe = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_DoanhSo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_ChonNgay = new System.Windows.Forms.Label();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.tb_TongTien = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_Thang = new System.Windows.Forms.CheckBox();
            this.cB_Nam = new System.Windows.Forms.CheckBox();
            this.cB_Ngay = new System.Windows.Forms.CheckBox();
            this.bt_ThongKe = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ThongKe)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíCửaHàngToolStripMenuItem,
            this.mns_QLKho,
            this.mns_TaiKhoan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLíCửaHàngToolStripMenuItem
            // 
            this.quảnLíCửaHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem});
            this.quảnLíCửaHàngToolStripMenuItem.Name = "quảnLíCửaHàngToolStripMenuItem";
            this.quảnLíCửaHàngToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.quảnLíCửaHàngToolStripMenuItem.Text = "Quản lý cửa hàng";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // mns_QLKho
            // 
            this.mns_QLKho.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_SP,
            this.mni_Kho});
            this.mns_QLKho.Name = "mns_QLKho";
            this.mns_QLKho.Size = new System.Drawing.Size(101, 24);
            this.mns_QLKho.Text = "Quản lý kho";
            // 
            // mni_SP
            // 
            this.mni_SP.Name = "mni_SP";
            this.mni_SP.Size = new System.Drawing.Size(187, 26);
            this.mni_SP.Text = "Sản phẩm bán";
            this.mni_SP.Click += new System.EventHandler(this.mni_SP_Click);
            // 
            // mni_Kho
            // 
            this.mni_Kho.Name = "mni_Kho";
            this.mni_Kho.Size = new System.Drawing.Size(187, 26);
            this.mni_Kho.Text = "Kho hàng";
            this.mni_Kho.Click += new System.EventHandler(this.mni_Kho_Click);
            // 
            // mns_TaiKhoan
            // 
            this.mns_TaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_DoiMatKhau,
            this.mni_DangXuat,
            this.mni_Thoat});
            this.mns_TaiKhoan.Name = "mns_TaiKhoan";
            this.mns_TaiKhoan.Size = new System.Drawing.Size(85, 24);
            this.mns_TaiKhoan.Text = "Tài khoản";
            // 
            // mni_DoiMatKhau
            // 
            this.mni_DoiMatKhau.Name = "mni_DoiMatKhau";
            this.mni_DoiMatKhau.Size = new System.Drawing.Size(181, 26);
            this.mni_DoiMatKhau.Text = "Đổi mật khẩu";
            this.mni_DoiMatKhau.Click += new System.EventHandler(this.mni_DoiMatKhau_Click);
            // 
            // mni_DangXuat
            // 
            this.mni_DangXuat.Name = "mni_DangXuat";
            this.mni_DangXuat.Size = new System.Drawing.Size(181, 26);
            this.mni_DangXuat.Text = "Đăng xuất";
            this.mni_DangXuat.Click += new System.EventHandler(this.mni_DangXuat_Click);
            // 
            // mni_Thoat
            // 
            this.mni_Thoat.Name = "mni_Thoat";
            this.mni_Thoat.Size = new System.Drawing.Size(181, 26);
            this.mni_Thoat.Text = "Thoát ";
            this.mni_Thoat.Click += new System.EventHandler(this.mni_Thoat_Click);
            // 
            // dtg_ThongKe
            // 
            this.dtg_ThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_ThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column1,
            this.Column4,
            this.Column6});
            this.dtg_ThongKe.Location = new System.Drawing.Point(0, 152);
            this.dtg_ThongKe.Name = "dtg_ThongKe";
            this.dtg_ThongKe.ReadOnly = true;
            this.dtg_ThongKe.RowHeadersWidth = 51;
            this.dtg_ThongKe.RowTemplate.Height = 24;
            this.dtg_ThongKe.Size = new System.Drawing.Size(800, 256);
            this.dtg_ThongKe.TabIndex = 3;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Giá bán";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Giảm giá";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày bán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thành tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // lb_DoanhSo
            // 
            this.lb_DoanhSo.AutoSize = true;
            this.lb_DoanhSo.BackColor = System.Drawing.Color.Yellow;
            this.lb_DoanhSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DoanhSo.ForeColor = System.Drawing.Color.Red;
            this.lb_DoanhSo.Location = new System.Drawing.Point(12, 49);
            this.lb_DoanhSo.Name = "lb_DoanhSo";
            this.lb_DoanhSo.Size = new System.Drawing.Size(289, 36);
            this.lb_DoanhSo.TabIndex = 4;
            this.lb_DoanhSo.Text = "Thống kê doanh số";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 24);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lb_ChonNgay
            // 
            this.lb_ChonNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ChonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChonNgay.Location = new System.Drawing.Point(3, 0);
            this.lb_ChonNgay.Name = "lb_ChonNgay";
            this.lb_ChonNgay.Size = new System.Drawing.Size(64, 36);
            this.lb_ChonNgay.TabIndex = 6;
            this.lb_ChonNgay.Text = "Chọn ngày";
            this.lb_ChonNgay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.Location = new System.Drawing.Point(311, 0);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(145, 33);
            this.lb_TongTien.TabIndex = 7;
            this.lb_TongTien.Text = "Tổng tiền:";
            this.lb_TongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_TongTien
            // 
            this.tb_TongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_TongTien.BackColor = System.Drawing.Color.White;
            this.tb_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TongTien.Location = new System.Drawing.Point(462, 3);
            this.tb_TongTien.Multiline = true;
            this.tb_TongTien.Name = "tb_TongTien";
            this.tb_TongTien.ReadOnly = true;
            this.tb_TongTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_TongTien.Size = new System.Drawing.Size(335, 27);
            this.tb_TongTien.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.02355F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.97644F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tableLayoutPanel1.Controls.Add(this.lb_TongTien, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_TongTien, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 414);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 33);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.38095F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.61905F));
            this.tableLayoutPanel2.Controls.Add(this.lb_ChonNgay, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(538, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(259, 36);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // cb_Thang
            // 
            this.cb_Thang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Thang.Location = new System.Drawing.Point(214, 3);
            this.cb_Thang.Name = "cb_Thang";
            this.cb_Thang.Size = new System.Drawing.Size(193, 49);
            this.cb_Thang.TabIndex = 2;
            this.cb_Thang.Text = "Thống kê theo tháng";
            this.cb_Thang.UseVisualStyleBackColor = true;
            // 
            // cB_Nam
            // 
            this.cB_Nam.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Nam.Location = new System.Drawing.Point(425, 3);
            this.cB_Nam.Name = "cB_Nam";
            this.cB_Nam.Size = new System.Drawing.Size(193, 49);
            this.cB_Nam.TabIndex = 1;
            this.cB_Nam.Text = "Thống kê theo năm";
            this.cB_Nam.UseVisualStyleBackColor = true;
            // 
            // cB_Ngay
            // 
            this.cB_Ngay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Ngay.Location = new System.Drawing.Point(3, 3);
            this.cB_Ngay.Name = "cB_Ngay";
            this.cB_Ngay.Size = new System.Drawing.Size(193, 49);
            this.cB_Ngay.TabIndex = 0;
            this.cB_Ngay.Text = "Thống kê theo ngày";
            this.cB_Ngay.UseVisualStyleBackColor = true;
            // 
            // bt_ThongKe
            // 
            this.bt_ThongKe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThongKe.Location = new System.Drawing.Point(636, 3);
            this.bt_ThongKe.Name = "bt_ThongKe";
            this.bt_ThongKe.Size = new System.Drawing.Size(109, 53);
            this.bt_ThongKe.TabIndex = 12;
            this.bt_ThongKe.Text = "Thống kê";
            this.bt_ThongKe.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.58161F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.58161F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.58161F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.25518F));
            this.tableLayoutPanel3.Controls.Add(this.cB_Nam, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cB_Ngay, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cb_Thang, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.bt_ThongKe, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 88);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(797, 59);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // form_QuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lb_DoanhSo);
            this.Controls.Add(this.dtg_ThongKe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_QuanLyBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí bán hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_QuanLyBanHang_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ThongKe)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mns_QLKho;
        private System.Windows.Forms.ToolStripMenuItem mns_TaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mni_DoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mni_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem mni_Thoat;
        private System.Windows.Forms.ToolStripMenuItem mni_Kho;
        private System.Windows.Forms.DataGridView dtg_ThongKe;
        private System.Windows.Forms.Label lb_DoanhSo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_ChonNgay;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.TextBox tb_TongTien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem mni_SP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem quảnLíCửaHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.CheckBox cb_Thang;
        private System.Windows.Forms.CheckBox cB_Nam;
        private System.Windows.Forms.CheckBox cB_Ngay;
        private System.Windows.Forms.Button bt_ThongKe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}