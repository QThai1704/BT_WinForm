namespace BaiTapLon
{
    partial class Form_DoiMatKhau
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
            this.lb_MatKhauCu = new System.Windows.Forms.Label();
            this.lb_MatKhauMoi = new System.Windows.Forms.Label();
            this.lb_MKMoi1 = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.tb_MKMoi1 = new System.Windows.Forms.TextBox();
            this.tb_MKMoi = new System.Windows.Forms.TextBox();
            this.tb_MKCu = new System.Windows.Forms.TextBox();
            this.lb_TenTaiKhoan = new System.Windows.Forms.Label();
            this.lb_TenTKMoi = new System.Windows.Forms.Label();
            this.tb_TenTKMoi = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_MatKhauCu
            // 
            this.lb_MatKhauCu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_MatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhauCu.Location = new System.Drawing.Point(3, 114);
            this.lb_MatKhauCu.Name = "lb_MatKhauCu";
            this.lb_MatKhauCu.Size = new System.Drawing.Size(207, 57);
            this.lb_MatKhauCu.TabIndex = 0;
            this.lb_MatKhauCu.Text = "Mật khẩu cũ";
            // 
            // lb_MatKhauMoi
            // 
            this.lb_MatKhauMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_MatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhauMoi.Location = new System.Drawing.Point(3, 171);
            this.lb_MatKhauMoi.Name = "lb_MatKhauMoi";
            this.lb_MatKhauMoi.Size = new System.Drawing.Size(207, 57);
            this.lb_MatKhauMoi.TabIndex = 1;
            this.lb_MatKhauMoi.Text = "Mật khẩu mới";
            // 
            // lb_MKMoi1
            // 
            this.lb_MKMoi1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_MKMoi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MKMoi1.Location = new System.Drawing.Point(3, 228);
            this.lb_MKMoi1.Name = "lb_MKMoi1";
            this.lb_MKMoi1.Size = new System.Drawing.Size(207, 65);
            this.lb_MKMoi1.TabIndex = 2;
            this.lb_MKMoi1.Text = "Nhập lại mật khẩu mới";
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Title.Location = new System.Drawing.Point(236, 9);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(321, 47);
            this.lb_Title.TabIndex = 3;
            this.lb_Title.Text = "Yêu cầu đổi mật khẩu";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0836F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.9164F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.Controls.Add(this.tb_TenTaiKhoan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_TenTaiKhoan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_Luu, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_MKMoi1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_MKMoi1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_MKMoi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_MKCu, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_TenTKMoi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_TenTKMoi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_MatKhauMoi, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_MatKhauCu, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.09845F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.17617F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.9171F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 386);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tb_TenTaiKhoan
            // 
            this.tb_TenTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tb_TenTaiKhoan, 2);
            this.tb_TenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenTaiKhoan.Location = new System.Drawing.Point(216, 3);
            this.tb_TenTaiKhoan.Multiline = true;
            this.tb_TenTaiKhoan.Name = "tb_TenTaiKhoan";
            this.tb_TenTaiKhoan.Size = new System.Drawing.Size(563, 35);
            this.tb_TenTaiKhoan.TabIndex = 8;
            // 
            // bt_Luu
            // 
            this.bt_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.Location = new System.Drawing.Point(629, 296);
            this.bt_Luu.Name = "bt_Luu";
            this.tableLayoutPanel1.SetRowSpan(this.bt_Luu, 2);
            this.bt_Luu.Size = new System.Drawing.Size(150, 87);
            this.bt_Luu.TabIndex = 6;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = false;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // tb_MKMoi1
            // 
            this.tb_MKMoi1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tb_MKMoi1, 2);
            this.tb_MKMoi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MKMoi1.Location = new System.Drawing.Point(216, 231);
            this.tb_MKMoi1.Multiline = true;
            this.tb_MKMoi1.Name = "tb_MKMoi1";
            this.tb_MKMoi1.Size = new System.Drawing.Size(563, 35);
            this.tb_MKMoi1.TabIndex = 5;
            // 
            // tb_MKMoi
            // 
            this.tb_MKMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tb_MKMoi, 2);
            this.tb_MKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MKMoi.Location = new System.Drawing.Point(216, 174);
            this.tb_MKMoi.Multiline = true;
            this.tb_MKMoi.Name = "tb_MKMoi";
            this.tb_MKMoi.Size = new System.Drawing.Size(563, 35);
            this.tb_MKMoi.TabIndex = 4;
            // 
            // tb_MKCu
            // 
            this.tb_MKCu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tb_MKCu, 2);
            this.tb_MKCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MKCu.Location = new System.Drawing.Point(216, 117);
            this.tb_MKCu.Multiline = true;
            this.tb_MKCu.Name = "tb_MKCu";
            this.tb_MKCu.Size = new System.Drawing.Size(563, 35);
            this.tb_MKCu.TabIndex = 3;
            // 
            // lb_TenTaiKhoan
            // 
            this.lb_TenTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenTaiKhoan.Location = new System.Drawing.Point(3, 0);
            this.lb_TenTaiKhoan.Name = "lb_TenTaiKhoan";
            this.lb_TenTaiKhoan.Size = new System.Drawing.Size(207, 57);
            this.lb_TenTaiKhoan.TabIndex = 7;
            this.lb_TenTaiKhoan.Text = "Tên tài khoản";
            // 
            // lb_TenTKMoi
            // 
            this.lb_TenTKMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TenTKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenTKMoi.Location = new System.Drawing.Point(3, 57);
            this.lb_TenTKMoi.Name = "lb_TenTKMoi";
            this.lb_TenTKMoi.Size = new System.Drawing.Size(207, 57);
            this.lb_TenTKMoi.TabIndex = 9;
            this.lb_TenTKMoi.Text = "Tên tài khoản mới";
            // 
            // tb_TenTKMoi
            // 
            this.tb_TenTKMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tb_TenTKMoi, 2);
            this.tb_TenTKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenTKMoi.Location = new System.Drawing.Point(216, 60);
            this.tb_TenTKMoi.Multiline = true;
            this.tb_TenTKMoi.Name = "tb_TenTKMoi";
            this.tb_TenTKMoi.Size = new System.Drawing.Size(563, 35);
            this.tb_TenTKMoi.TabIndex = 10;
            // 
            // Form_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lb_Title);
            this.Name = "Form_DoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_MatKhauCu;
        private System.Windows.Forms.Label lb_MatKhauMoi;
        private System.Windows.Forms.Label lb_MKMoi1;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_MKMoi1;
        private System.Windows.Forms.TextBox tb_MKMoi;
        private System.Windows.Forms.TextBox tb_MKCu;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.TextBox tb_TenTaiKhoan;
        private System.Windows.Forms.Label lb_TenTaiKhoan;
        private System.Windows.Forms.Label lb_TenTKMoi;
        private System.Windows.Forms.TextBox tb_TenTKMoi;
    }
}