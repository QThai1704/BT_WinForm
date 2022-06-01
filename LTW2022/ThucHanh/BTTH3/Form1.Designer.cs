namespace BTTH3
{
    partial class Form_BanHang
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_ThanhToan = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_TaoHoaDon = new System.Windows.Forms.Button();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.lb_DonGia = new System.Windows.Forms.Label();
            this.lb_SoL = new System.Windows.Forms.Label();
            this.lb_TenH = new System.Windows.Forms.Label();
            this.lb_TenK = new System.Windows.Forms.Label();
            this.tb_DonG = new System.Windows.Forms.TextBox();
            this.tb_TongT = new System.Windows.Forms.TextBox();
            this.tb_TenK = new System.Windows.Forms.TextBox();
            this.cb_TenH = new System.Windows.Forms.ComboBox();
            this.nUD_SoL = new System.Windows.Forms.NumericUpDown();
            this.dtg_ThongKe = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_SoL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ThongKe)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtg_ThongKe);
            this.splitContainer1.Size = new System.Drawing.Size(903, 528);
            this.splitContainer1.SplitterDistance = 452;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Moccasin;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.bt_ThanhToan, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_TaoHoaDon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_TongTien, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_DonGia, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_SoL, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_TenH, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_TenK, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_DonG, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_TongT, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_TenK, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_TenH, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nUD_SoL, 1, 3);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bt_ThanhToan
            // 
            this.bt_ThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThanhToan.Location = new System.Drawing.Point(93, 378);
            this.bt_ThanhToan.Name = "bt_ThanhToan";
            this.bt_ThanhToan.Size = new System.Drawing.Size(265, 69);
            this.bt_ThanhToan.TabIndex = 1;
            this.bt_ThanhToan.Text = "Thanh toán";
            this.bt_ThanhToan.UseVisualStyleBackColor = true;
            this.bt_ThanhToan.Click += new System.EventHandler(this.bt_ThanhToan_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.bt_Them, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.bt_Xoa, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(364, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 7);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.42857F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(86, 522);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // bt_Them
            // 
            this.bt_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Location = new System.Drawing.Point(3, 114);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(80, 68);
            this.bt_Them.TabIndex = 0;
            this.bt_Them.Text = ">>";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.Location = new System.Drawing.Point(3, 262);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(80, 68);
            this.bt_Xoa.TabIndex = 1;
            this.bt_Xoa.Text = "<<";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_TaoHoaDon
            // 
            this.bt_TaoHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_TaoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TaoHoaDon.Location = new System.Drawing.Point(93, 3);
            this.bt_TaoHoaDon.Name = "bt_TaoHoaDon";
            this.bt_TaoHoaDon.Size = new System.Drawing.Size(265, 69);
            this.bt_TaoHoaDon.TabIndex = 0;
            this.bt_TaoHoaDon.Text = "Tạo hóa đơn";
            this.bt_TaoHoaDon.UseVisualStyleBackColor = true;
            this.bt_TaoHoaDon.Click += new System.EventHandler(this.bt_TaoHoaDon_Click);
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_TongTien.Location = new System.Drawing.Point(3, 450);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(84, 75);
            this.lb_TongTien.TabIndex = 7;
            this.lb_TongTien.Text = "Tổng tiền";
            this.lb_TongTien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_DonGia
            // 
            this.lb_DonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DonGia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_DonGia.Location = new System.Drawing.Point(3, 300);
            this.lb_DonGia.Name = "lb_DonGia";
            this.lb_DonGia.Size = new System.Drawing.Size(84, 75);
            this.lb_DonGia.TabIndex = 6;
            this.lb_DonGia.Text = "Đơn giá";
            // 
            // lb_SoL
            // 
            this.lb_SoL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_SoL.Location = new System.Drawing.Point(3, 225);
            this.lb_SoL.Name = "lb_SoL";
            this.lb_SoL.Size = new System.Drawing.Size(84, 75);
            this.lb_SoL.TabIndex = 5;
            this.lb_SoL.Text = "Số lượng";
            // 
            // lb_TenH
            // 
            this.lb_TenH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TenH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_TenH.Location = new System.Drawing.Point(3, 150);
            this.lb_TenH.Name = "lb_TenH";
            this.lb_TenH.Size = new System.Drawing.Size(84, 75);
            this.lb_TenH.TabIndex = 4;
            this.lb_TenH.Text = "Tên hàng";
            // 
            // lb_TenK
            // 
            this.lb_TenK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TenK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_TenK.Location = new System.Drawing.Point(3, 75);
            this.lb_TenK.Name = "lb_TenK";
            this.lb_TenK.Size = new System.Drawing.Size(84, 75);
            this.lb_TenK.TabIndex = 3;
            this.lb_TenK.Text = "Tên khách";
            // 
            // tb_DonG
            // 
            this.tb_DonG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_DonG.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_DonG.Enabled = false;
            this.tb_DonG.Location = new System.Drawing.Point(93, 303);
            this.tb_DonG.Multiline = true;
            this.tb_DonG.Name = "tb_DonG";
            this.tb_DonG.ReadOnly = true;
            this.tb_DonG.Size = new System.Drawing.Size(265, 30);
            this.tb_DonG.TabIndex = 10;
            this.tb_DonG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_TongT
            // 
            this.tb_TongT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_TongT.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_TongT.Enabled = false;
            this.tb_TongT.Location = new System.Drawing.Point(93, 453);
            this.tb_TongT.Multiline = true;
            this.tb_TongT.Name = "tb_TongT";
            this.tb_TongT.ReadOnly = true;
            this.tb_TongT.Size = new System.Drawing.Size(265, 27);
            this.tb_TongT.TabIndex = 8;
            this.tb_TongT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_TenK
            // 
            this.tb_TenK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_TenK.Location = new System.Drawing.Point(93, 78);
            this.tb_TenK.Multiline = true;
            this.tb_TenK.Name = "tb_TenK";
            this.tb_TenK.Size = new System.Drawing.Size(265, 30);
            this.tb_TenK.TabIndex = 9;
            // 
            // cb_TenH
            // 
            this.cb_TenH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_TenH.FormattingEnabled = true;
            this.cb_TenH.Location = new System.Drawing.Point(93, 153);
            this.cb_TenH.Name = "cb_TenH";
            this.cb_TenH.Size = new System.Drawing.Size(265, 24);
            this.cb_TenH.TabIndex = 11;
            this.cb_TenH.SelectedIndexChanged += new System.EventHandler(this.cb_TenH_SelectedIndexChanged);
            // 
            // nUD_SoL
            // 
            this.nUD_SoL.Location = new System.Drawing.Point(93, 228);
            this.nUD_SoL.Name = "nUD_SoL";
            this.nUD_SoL.Size = new System.Drawing.Size(144, 22);
            this.nUD_SoL.TabIndex = 12;
            // 
            // dtg_ThongKe
            // 
            this.dtg_ThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_ThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ThongKe.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dtg_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtg_ThongKe.Location = new System.Drawing.Point(0, 0);
            this.dtg_ThongKe.Name = "dtg_ThongKe";
            this.dtg_ThongKe.ReadOnly = true;
            this.dtg_ThongKe.RowHeadersWidth = 51;
            this.dtg_ThongKe.RowTemplate.Height = 24;
            this.dtg_ThongKe.Size = new System.Drawing.Size(444, 525);
            this.dtg_ThongKe.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMàuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 28);
            // 
            // đổiMàuToolStripMenuItem
            // 
            this.đổiMàuToolStripMenuItem.Name = "đổiMàuToolStripMenuItem";
            this.đổiMàuToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.đổiMàuToolStripMenuItem.Text = "Đổi màu";
            this.đổiMàuToolStripMenuItem.Click += new System.EventHandler(this.đổiMàuToolStripMenuItem_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // Column4
            // 
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 528);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form_BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng           (Nguyễn Quang Thái - 2051063464)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_SoL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ThongKe)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_ThanhToan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_TaoHoaDon;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Label lb_DonGia;
        private System.Windows.Forms.Label lb_SoL;
        private System.Windows.Forms.Label lb_TenH;
        private System.Windows.Forms.Label lb_TenK;
        private System.Windows.Forms.TextBox tb_DonG;
        private System.Windows.Forms.TextBox tb_TongT;
        private System.Windows.Forms.TextBox tb_TenK;
        private System.Windows.Forms.ComboBox cb_TenH;
        private System.Windows.Forms.NumericUpDown nUD_SoL;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiMàuToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtg_ThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

