namespace LTWinF1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTong = new System.Windows.Forms.Label();
            this.lbHieu = new System.Windows.Forms.Label();
            this.lbTich = new System.Windows.Forms.Label();
            this.lbThuong = new System.Windows.Forms.Label();
            this.tb_SoA = new System.Windows.Forms.TextBox();
            this.tb_SoB = new System.Windows.Forms.TextBox();
            this.bt_Tinh = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số b:";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(12, 179);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(143, 29);
            this.lbTong.TabIndex = 2;
            this.lbTong.Text = "Tổng a+b = ";
            // 
            // lbHieu
            // 
            this.lbHieu.AutoSize = true;
            this.lbHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHieu.Location = new System.Drawing.Point(12, 229);
            this.lbHieu.Name = "lbHieu";
            this.lbHieu.Size = new System.Drawing.Size(130, 29);
            this.lbHieu.TabIndex = 3;
            this.lbHieu.Text = "Hiệu a-b = ";
            // 
            // lbTich
            // 
            this.lbTich.AutoSize = true;
            this.lbTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTich.Location = new System.Drawing.Point(12, 275);
            this.lbTich.Name = "lbTich";
            this.lbTich.Size = new System.Drawing.Size(123, 29);
            this.lbTich.TabIndex = 4;
            this.lbTich.Text = "Tích a*b =";
            // 
            // lbThuong
            // 
            this.lbThuong.AutoSize = true;
            this.lbThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuong.Location = new System.Drawing.Point(12, 320);
            this.lbThuong.Name = "lbThuong";
            this.lbThuong.Size = new System.Drawing.Size(156, 29);
            this.lbThuong.TabIndex = 5;
            this.lbThuong.Text = "Thương a/b =";
            // 
            // tb_SoA
            // 
            this.tb_SoA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SoA.Location = new System.Drawing.Point(117, 38);
            this.tb_SoA.Name = "tb_SoA";
            this.tb_SoA.Size = new System.Drawing.Size(431, 22);
            this.tb_SoA.TabIndex = 1;
            this.tb_SoA.Leave += new System.EventHandler(this.tb_SoA_Leave);
            // 
            // tb_SoB
            // 
            this.tb_SoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SoB.Location = new System.Drawing.Point(117, 95);
            this.tb_SoB.Name = "tb_SoB";
            this.tb_SoB.Size = new System.Drawing.Size(431, 22);
            this.tb_SoB.TabIndex = 2;
            this.tb_SoB.Leave += new System.EventHandler(this.tb_SoB_Leave);
            // 
            // bt_Tinh
            // 
            this.bt_Tinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Tinh.BackColor = System.Drawing.Color.Aqua;
            this.bt_Tinh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Tinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Tinh.Location = new System.Drawing.Point(645, 38);
            this.bt_Tinh.Name = "bt_Tinh";
            this.bt_Tinh.Size = new System.Drawing.Size(117, 79);
            this.bt_Tinh.TabIndex = 3;
            this.bt_Tinh.Text = "Tính";
            this.bt_Tinh.UseVisualStyleBackColor = false;
            this.bt_Tinh.Click += new System.EventHandler(this.bt_Tinh_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Thoat.BackColor = System.Drawing.Color.Aqua;
            this.bt_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Thoat.Location = new System.Drawing.Point(645, 275);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(117, 79);
            this.bt_Thoat.TabIndex = 4;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.bt_Tinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Thoat;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_Tinh);
            this.Controls.Add(this.tb_SoB);
            this.Controls.Add(this.tb_SoA);
            this.Controls.Add(this.lbThuong);
            this.Controls.Add(this.lbTich);
            this.Controls.Add(this.lbHieu);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label lbHieu;
        private System.Windows.Forms.Label lbTich;
        private System.Windows.Forms.Label lbThuong;
        private System.Windows.Forms.TextBox tb_SoA;
        private System.Windows.Forms.TextBox tb_SoB;
        private System.Windows.Forms.Button bt_Tinh;
        private System.Windows.Forms.Button bt_Thoat;
    }
}

