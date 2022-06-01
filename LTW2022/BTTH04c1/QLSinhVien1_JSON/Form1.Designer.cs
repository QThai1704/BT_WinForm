namespace QLSinhVien1_JSON
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
            this.btLuu = new System.Windows.Forms.Button();
            this.dgt1 = new System.Windows.Forms.DataGridView();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.tbTenT = new System.Windows.Forms.TextBox();
            this.tbMaT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tc1.SuspendLayout();
            this.tcTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt1)).BeginInit();
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
            this.tc1.Location = new System.Drawing.Point(12, 12);
            this.tc1.Name = "tc1";
            this.tc1.SelectedIndex = 0;
            this.tc1.Size = new System.Drawing.Size(783, 426);
            this.tc1.TabIndex = 0;
            // 
            // tcTinh
            // 
            this.tcTinh.Controls.Add(this.btLuu);
            this.tcTinh.Controls.Add(this.dgt1);
            this.tcTinh.Controls.Add(this.btXoa);
            this.tcTinh.Controls.Add(this.btSua);
            this.tcTinh.Controls.Add(this.btThem);
            this.tcTinh.Controls.Add(this.tbTenT);
            this.tcTinh.Controls.Add(this.tbMaT);
            this.tcTinh.Controls.Add(this.label2);
            this.tcTinh.Controls.Add(this.label1);
            this.tcTinh.Location = new System.Drawing.Point(4, 25);
            this.tcTinh.Name = "tcTinh";
            this.tcTinh.Padding = new System.Windows.Forms.Padding(3);
            this.tcTinh.Size = new System.Drawing.Size(775, 397);
            this.tcTinh.TabIndex = 1;
            this.tcTinh.Text = "Tỉnh";
            this.tcTinh.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLuu.Location = new System.Drawing.Point(676, 16);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(90, 61);
            this.btLuu.TabIndex = 8;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // dgt1
            // 
            this.dgt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgt1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt1.Location = new System.Drawing.Point(6, 82);
            this.dgt1.Name = "dgt1";
            this.dgt1.RowHeadersWidth = 51;
            this.dgt1.RowTemplate.Height = 24;
            this.dgt1.Size = new System.Drawing.Size(760, 309);
            this.dgt1.TabIndex = 7;
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoa.Location = new System.Drawing.Point(580, 16);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 61);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSua.Location = new System.Drawing.Point(475, 15);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(90, 61);
            this.btSua.TabIndex = 5;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThem.Location = new System.Drawing.Point(379, 15);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(90, 61);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // tbTenT
            // 
            this.tbTenT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTenT.Location = new System.Drawing.Point(123, 54);
            this.tbTenT.Name = "tbTenT";
            this.tbTenT.Size = new System.Drawing.Size(241, 22);
            this.tbTenT.TabIndex = 3;
            // 
            // tbMaT
            // 
            this.tbMaT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMaT.Location = new System.Drawing.Point(123, 16);
            this.tbMaT.Name = "tbMaT";
            this.tbMaT.Size = new System.Drawing.Size(241, 22);
            this.tbMaT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tỉnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tỉnh";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 397);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Khoa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 397);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Lớp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(775, 397);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Sinh viên";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.tc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tc1.ResumeLayout(false);
            this.tcTinh.ResumeLayout(false);
            this.tcTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc1;
        private System.Windows.Forms.TabPage tcTinh;
        private System.Windows.Forms.TextBox tbTenT;
        private System.Windows.Forms.TextBox tbMaT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgt1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

