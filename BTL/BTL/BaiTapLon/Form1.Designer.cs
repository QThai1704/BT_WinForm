namespace BaiTapLon
{
    partial class Form_DangNhap
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
            this.lb_TaiKhoan = new System.Windows.Forms.Label();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.tb_TaiKhoan = new System.Windows.Forms.TextBox();
            this.bt_DangNhap = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_TaiKhoan
            // 
            this.lb_TaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_TaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lb_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TaiKhoan.Location = new System.Drawing.Point(3, 0);
            this.lb_TaiKhoan.Name = "lb_TaiKhoan";
            this.lb_TaiKhoan.Size = new System.Drawing.Size(242, 73);
            this.lb_TaiKhoan.TabIndex = 0;
            this.lb_TaiKhoan.Text = "Tài khoản";
            this.lb_TaiKhoan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_MatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lb_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhau.Location = new System.Drawing.Point(3, 73);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(235, 125);
            this.lb_MatKhau.TabIndex = 1;
            this.lb_MatKhau.Text = "Mật khẩu";
            this.lb_MatKhau.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_TaiKhoan
            // 
            this.tb_TaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_TaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_TaiKhoan, 2);
            this.tb_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TaiKhoan.Location = new System.Drawing.Point(268, 3);
            this.tb_TaiKhoan.Multiline = true;
            this.tb_TaiKhoan.Name = "tb_TaiKhoan";
            this.tb_TaiKhoan.Size = new System.Drawing.Size(507, 29);
            this.tb_TaiKhoan.TabIndex = 1;
            // 
            // bt_DangNhap
            // 
            this.bt_DangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_DangNhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangNhap.Location = new System.Drawing.Point(268, 201);
            this.bt_DangNhap.Name = "bt_DangNhap";
            this.tableLayoutPanel1.SetRowSpan(this.bt_DangNhap, 2);
            this.bt_DangNhap.Size = new System.Drawing.Size(256, 75);
            this.bt_DangNhap.TabIndex = 3;
            this.bt_DangNhap.Text = "Đăng nhập";
            this.bt_DangNhap.UseVisualStyleBackColor = false;
            this.bt_DangNhap.Click += new System.EventHandler(this.bt_DangNhap_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Thoat.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.Location = new System.Drawing.Point(530, 201);
            this.bt_Thoat.Name = "bt_Thoat";
            this.tableLayoutPanel1.SetRowSpan(this.bt_Thoat, 2);
            this.bt_Thoat.Size = new System.Drawing.Size(245, 75);
            this.bt_Thoat.TabIndex = 4;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = false;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.07311F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.68146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.1267F));
            this.tableLayoutPanel1.Controls.Add(this.bt_DangNhap, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_Thoat, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_TaiKhoan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_MatKhau, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_MatKhau, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_TaiKhoan, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.88213F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.11787F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 279);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_MatKhau, 2);
            this.tb_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MatKhau.Location = new System.Drawing.Point(268, 76);
            this.tb_MatKhau.Multiline = true;
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.PasswordChar = '*';
            this.tb_MatKhau.Size = new System.Drawing.Size(507, 29);
            this.tb_MatKhau.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đăng nhập hệ thống";
            // 
            // Form_DangNhap
            // 
            this.AcceptButton = this.bt_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BaiTapLon.Properties.Resources.image2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.bt_Thoat;
            this.ClientSize = new System.Drawing.Size(782, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TaiKhoan;
        private System.Windows.Forms.Label lb_MatKhau;
        private System.Windows.Forms.TextBox tb_TaiKhoan;
        private System.Windows.Forms.Button bt_DangNhap;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MatKhau;
    }
}

