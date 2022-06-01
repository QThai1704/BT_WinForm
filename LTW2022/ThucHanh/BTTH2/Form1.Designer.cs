namespace BTTH2
{
    partial class Form_1
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
            this.tp_MT = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtg_QLS = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_MaS = new System.Windows.Forms.TextBox();
            this.tb_TenS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtg_MT = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_TraS = new System.Windows.Forms.Button();
            this.lb_TenSV = new System.Windows.Forms.Label();
            this.lb_TenS = new System.Windows.Forms.Label();
            this.lb_NgayM = new System.Windows.Forms.Label();
            this.lb_NgayT = new System.Windows.Forms.Label();
            this.tb_TenSV = new System.Windows.Forms.TextBox();
            this.dt_NgayM = new System.Windows.Forms.DateTimePicker();
            this.dt_NgayT = new System.Windows.Forms.DateTimePicker();
            this.bt_MuonS = new System.Windows.Forms.Button();
            this.lb_SoNgayM = new System.Windows.Forms.Label();
            this.cb_TenS = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tp_MT.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_QLS)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_MT)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp_MT
            // 
            this.tp_MT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tp_MT.Controls.Add(this.tabPage1);
            this.tp_MT.Controls.Add(this.tabPage2);
            this.tp_MT.Controls.Add(this.tabPage3);
            this.tp_MT.Location = new System.Drawing.Point(1, 2);
            this.tp_MT.Name = "tp_MT";
            this.tp_MT.SelectedIndex = 0;
            this.tp_MT.Size = new System.Drawing.Size(798, 448);
            this.tp_MT.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtg_QLS);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lí sách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtg_QLS
            // 
            this.dtg_QLS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_QLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_QLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_QLS.Location = new System.Drawing.Point(6, 80);
            this.dtg_QLS.Name = "dtg_QLS";
            this.dtg_QLS.ReadOnly = true;
            this.dtg_QLS.RowHeadersWidth = 51;
            this.dtg_QLS.RowTemplate.Height = 24;
            this.dtg_QLS.Size = new System.Drawing.Size(781, 336);
            this.dtg_QLS.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_MaS, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_TenS, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(642, 68);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_MaS
            // 
            this.tb_MaS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MaS.Location = new System.Drawing.Point(90, 3);
            this.tb_MaS.Name = "tb_MaS";
            this.tb_MaS.Size = new System.Drawing.Size(285, 22);
            this.tb_MaS.TabIndex = 2;
            // 
            // tb_TenS
            // 
            this.tb_TenS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_TenS.Location = new System.Drawing.Point(90, 37);
            this.tb_TenS.Name = "tb_TenS";
            this.tb_TenS.Size = new System.Drawing.Size(285, 22);
            this.tb_TenS.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(439, 3);
            this.button1.Name = "button1";
            this.tableLayoutPanel2.SetRowSpan(this.button1, 2);
            this.button1.Size = new System.Drawing.Size(200, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtg_MT);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mượn/Trả sách";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtg_MT
            // 
            this.dtg_MT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_MT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_MT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_MT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_MT.Location = new System.Drawing.Point(3, 109);
            this.dtg_MT.Name = "dtg_MT";
            this.dtg_MT.RowHeadersWidth = 51;
            this.dtg_MT.RowTemplate.Height = 24;
            this.dtg_MT.Size = new System.Drawing.Size(784, 307);
            this.dtg_MT.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.bt_TraS, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_TenSV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_TenS, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_NgayM, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_NgayT, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_TenSV, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dt_NgayM, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dt_NgayT, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_MuonS, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_SoNgayM, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_TenS, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bt_TraS
            // 
            this.bt_TraS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_TraS.Location = new System.Drawing.Point(632, 36);
            this.bt_TraS.Name = "bt_TraS";
            this.bt_TraS.Size = new System.Drawing.Size(152, 27);
            this.bt_TraS.TabIndex = 9;
            this.bt_TraS.Text = "Trả sách";
            this.bt_TraS.UseVisualStyleBackColor = true;
            // 
            // lb_TenSV
            // 
            this.lb_TenSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TenSV.Location = new System.Drawing.Point(3, 0);
            this.lb_TenSV.Name = "lb_TenSV";
            this.lb_TenSV.Size = new System.Drawing.Size(112, 33);
            this.lb_TenSV.TabIndex = 0;
            this.lb_TenSV.Text = "Tên sinh viên";
            this.lb_TenSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_TenS
            // 
            this.lb_TenS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TenS.Location = new System.Drawing.Point(3, 33);
            this.lb_TenS.Name = "lb_TenS";
            this.lb_TenS.Size = new System.Drawing.Size(112, 33);
            this.lb_TenS.TabIndex = 1;
            this.lb_TenS.Text = "Tên sách";
            this.lb_TenS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_NgayM
            // 
            this.lb_NgayM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_NgayM.Location = new System.Drawing.Point(357, 0);
            this.lb_NgayM.Name = "lb_NgayM";
            this.lb_NgayM.Size = new System.Drawing.Size(112, 33);
            this.lb_NgayM.TabIndex = 2;
            this.lb_NgayM.Text = "Ngày mượn";
            this.lb_NgayM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_NgayT
            // 
            this.lb_NgayT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_NgayT.Location = new System.Drawing.Point(357, 33);
            this.lb_NgayT.Name = "lb_NgayT";
            this.lb_NgayT.Size = new System.Drawing.Size(112, 33);
            this.lb_NgayT.TabIndex = 3;
            this.lb_NgayT.Text = "Ngày trả";
            this.lb_NgayT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_TenSV
            // 
            this.tb_TenSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_TenSV.Location = new System.Drawing.Point(121, 3);
            this.tb_TenSV.Name = "tb_TenSV";
            this.tb_TenSV.Size = new System.Drawing.Size(230, 22);
            this.tb_TenSV.TabIndex = 4;
            // 
            // dt_NgayM
            // 
            this.dt_NgayM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_NgayM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NgayM.Location = new System.Drawing.Point(475, 3);
            this.dt_NgayM.Name = "dt_NgayM";
            this.dt_NgayM.Size = new System.Drawing.Size(151, 22);
            this.dt_NgayM.TabIndex = 6;
            this.dt_NgayM.ValueChanged += new System.EventHandler(this.dt_NgayM_ValueChanged);
            // 
            // dt_NgayT
            // 
            this.dt_NgayT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_NgayT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NgayT.Location = new System.Drawing.Point(475, 36);
            this.dt_NgayT.Name = "dt_NgayT";
            this.dt_NgayT.Size = new System.Drawing.Size(151, 22);
            this.dt_NgayT.TabIndex = 7;
            // 
            // bt_MuonS
            // 
            this.bt_MuonS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_MuonS.Location = new System.Drawing.Point(632, 3);
            this.bt_MuonS.Name = "bt_MuonS";
            this.bt_MuonS.Size = new System.Drawing.Size(152, 27);
            this.bt_MuonS.TabIndex = 8;
            this.bt_MuonS.Text = "Mượn sách";
            this.bt_MuonS.UseVisualStyleBackColor = true;
            this.bt_MuonS.Click += new System.EventHandler(this.bt_MuonS_Click);
            // 
            // lb_SoNgayM
            // 
            this.lb_SoNgayM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.lb_SoNgayM, 2);
            this.lb_SoNgayM.Location = new System.Drawing.Point(357, 66);
            this.lb_SoNgayM.Name = "lb_SoNgayM";
            this.lb_SoNgayM.Size = new System.Drawing.Size(269, 34);
            this.lb_SoNgayM.TabIndex = 10;
            this.lb_SoNgayM.Text = "Số ngày mượn:";
            this.lb_SoNgayM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_TenS
            // 
            this.cb_TenS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_TenS.FormattingEnabled = true;
            this.cb_TenS.Location = new System.Drawing.Point(121, 36);
            this.cb_TenS.Name = "cb_TenS";
            this.cb_TenS.Size = new System.Drawing.Size(230, 24);
            this.cb_TenS.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(790, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống kê";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tp_MT);
            this.Name = "Form_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mượn sách     Nguyễn Quang Thái _2051063464";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tp_MT.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_QLS)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_MT)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tp_MT;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dtg_QLS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_MaS;
        private System.Windows.Forms.TextBox tb_TenS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_TenSV;
        private System.Windows.Forms.Label lb_TenS;
        private System.Windows.Forms.Label lb_NgayM;
        private System.Windows.Forms.Label lb_NgayT;
        private System.Windows.Forms.TextBox tb_TenSV;
        private System.Windows.Forms.DateTimePicker dt_NgayM;
        private System.Windows.Forms.DateTimePicker dt_NgayT;
        private System.Windows.Forms.Button bt_TraS;
        private System.Windows.Forms.Button bt_MuonS;
        private System.Windows.Forms.Label lb_SoNgayM;
        private System.Windows.Forms.DataGridView dtg_MT;
        private System.Windows.Forms.ComboBox cb_TenS;
    }
}

