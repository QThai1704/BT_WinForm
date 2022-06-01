namespace BTTH4
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
            this.lb_SoL = new System.Windows.Forms.Label();
            this.tb_SoMH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_DonG = new System.Windows.Forms.TextBox();
            this.tb_TenH = new System.Windows.Forms.TextBox();
            this.tb_SoLuong = new System.Windows.Forms.TextBox();
            this.lb_TenH = new System.Windows.Forms.Label();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.lb_MaH = new System.Windows.Forms.Label();
            this.lb_Ngay = new System.Windows.Forms.Label();
            this.lb_DonG = new System.Windows.Forms.Label();
            this.lb_XuatX = new System.Windows.Forms.Label();
            this.tb_MaH = new System.Windows.Forms.TextBox();
            this.bt_Them = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_XuatX = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_SoL
            // 
            this.lb_SoL.AutoSize = true;
            this.lb_SoL.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoL.Location = new System.Drawing.Point(12, 26);
            this.lb_SoL.Name = "lb_SoL";
            this.lb_SoL.Size = new System.Drawing.Size(98, 19);
            this.lb_SoL.TabIndex = 0;
            this.lb_SoL.Text = "Số mặt hàng";
            // 
            // tb_SoMH
            // 
            this.tb_SoMH.AcceptsTab = true;
            this.tb_SoMH.Location = new System.Drawing.Point(128, 23);
            this.tb_SoMH.Name = "tb_SoMH";
            this.tb_SoMH.Size = new System.Drawing.Size(133, 22);
            this.tb_SoMH.TabIndex = 1;
            this.tb_SoMH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_SoMH.Leave += new System.EventHandler(this.tb_SoMH_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin cho mặt hàng thứ 0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tb_DonG, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_TenH, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_SoLuong, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_TenH, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_SoLuong, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_MaH, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Ngay, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_DonG, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_XuatX, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_MaH, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_Them, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_XuatX, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 158);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_DonG
            // 
            this.tb_DonG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_DonG.Location = new System.Drawing.Point(432, 55);
            this.tb_DonG.Multiline = true;
            this.tb_DonG.Name = "tb_DonG";
            this.tb_DonG.Size = new System.Drawing.Size(189, 27);
            this.tb_DonG.TabIndex = 6;
            this.tb_DonG.Visible = false;
            // 
            // tb_TenH
            // 
            this.tb_TenH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_TenH.Location = new System.Drawing.Point(120, 55);
            this.tb_TenH.Multiline = true;
            this.tb_TenH.Name = "tb_TenH";
            this.tb_TenH.Size = new System.Drawing.Size(189, 27);
            this.tb_TenH.TabIndex = 3;
            this.tb_TenH.Visible = false;
            // 
            // tb_SoLuong
            // 
            this.tb_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SoLuong.Location = new System.Drawing.Point(432, 3);
            this.tb_SoLuong.Multiline = true;
            this.tb_SoLuong.Name = "tb_SoLuong";
            this.tb_SoLuong.Size = new System.Drawing.Size(189, 27);
            this.tb_SoLuong.TabIndex = 5;
            this.tb_SoLuong.Visible = false;
            // 
            // lb_TenH
            // 
            this.lb_TenH.AutoSize = true;
            this.lb_TenH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenH.Location = new System.Drawing.Point(3, 52);
            this.lb_TenH.Name = "lb_TenH";
            this.lb_TenH.Size = new System.Drawing.Size(75, 19);
            this.lb_TenH.TabIndex = 9;
            this.lb_TenH.Text = "Tên hàng";
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLuong.Location = new System.Drawing.Point(315, 0);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(74, 19);
            this.lb_SoLuong.TabIndex = 6;
            this.lb_SoLuong.Text = "Số lượng";
            // 
            // lb_MaH
            // 
            this.lb_MaH.AutoSize = true;
            this.lb_MaH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaH.Location = new System.Drawing.Point(3, 0);
            this.lb_MaH.Name = "lb_MaH";
            this.lb_MaH.Size = new System.Drawing.Size(72, 19);
            this.lb_MaH.TabIndex = 4;
            this.lb_MaH.Text = "Mã hàng";
            // 
            // lb_Ngay
            // 
            this.lb_Ngay.AutoSize = true;
            this.lb_Ngay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ngay.Location = new System.Drawing.Point(3, 104);
            this.lb_Ngay.Name = "lb_Ngay";
            this.lb_Ngay.Size = new System.Drawing.Size(85, 19);
            this.lb_Ngay.TabIndex = 5;
            this.lb_Ngay.Text = "Ngày nhập";
            // 
            // lb_DonG
            // 
            this.lb_DonG.AutoSize = true;
            this.lb_DonG.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DonG.Location = new System.Drawing.Point(315, 52);
            this.lb_DonG.Name = "lb_DonG";
            this.lb_DonG.Size = new System.Drawing.Size(66, 19);
            this.lb_DonG.TabIndex = 7;
            this.lb_DonG.Text = "Đơn giá";
            // 
            // lb_XuatX
            // 
            this.lb_XuatX.AutoSize = true;
            this.lb_XuatX.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_XuatX.Location = new System.Drawing.Point(315, 104);
            this.lb_XuatX.Name = "lb_XuatX";
            this.lb_XuatX.Size = new System.Drawing.Size(66, 19);
            this.lb_XuatX.TabIndex = 8;
            this.lb_XuatX.Text = "Xuất xứ";
            // 
            // tb_MaH
            // 
            this.tb_MaH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MaH.Location = new System.Drawing.Point(120, 3);
            this.tb_MaH.Multiline = true;
            this.tb_MaH.Name = "tb_MaH";
            this.tb_MaH.Size = new System.Drawing.Size(189, 27);
            this.tb_MaH.TabIndex = 2;
            this.tb_MaH.Visible = false;
            // 
            // bt_Them
            // 
            this.bt_Them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Location = new System.Drawing.Point(627, 107);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(153, 36);
            this.bt_Them.TabIndex = 8;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 27);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 218);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các mặt hàng đã nhập";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(783, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // cb_XuatX
            // 
            this.cb_XuatX.FormattingEnabled = true;
            this.cb_XuatX.Items.AddRange(new object[] {
            "Việt Nam",
            "Trung Quốc",
            "Hàn Quốc",
            "Nhật Bản",
            "Mỹ",
            "Đức",
            "Nga",
            "Bỉ",
            "Thái Lan"});
            this.cb_XuatX.Location = new System.Drawing.Point(432, 107);
            this.cb_XuatX.Name = "cb_XuatX";
            this.cb_XuatX.Size = new System.Drawing.Size(189, 27);
            this.cb_XuatX.TabIndex = 7;
            this.cb_XuatX.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hàng";
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
            this.Column3.HeaderText = "Ngày nhập";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Đơn giá";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Xuất xứ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_SoMH);
            this.Controls.Add(this.lb_SoL);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập kho";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_SoL;
        private System.Windows.Forms.TextBox tb_SoMH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_DonG;
        private System.Windows.Forms.TextBox tb_TenH;
        private System.Windows.Forms.TextBox tb_SoLuong;
        private System.Windows.Forms.Label lb_TenH;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.Label lb_MaH;
        private System.Windows.Forms.Label lb_Ngay;
        private System.Windows.Forms.Label lb_DonG;
        private System.Windows.Forms.Label lb_XuatX;
        private System.Windows.Forms.TextBox tb_MaH;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_XuatX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

