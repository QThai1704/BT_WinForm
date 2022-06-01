namespace BTTH05
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_SoA = new System.Windows.Forms.TextBox();
            this.tb_SoB = new System.Windows.Forms.TextBox();
            this.tb_SoC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_KQ1 = new System.Windows.Forms.TextBox();
            this.tb_KQ2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_Tinh = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thayĐổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập c";
            // 
            // tb_SoA
            // 
            this.tb_SoA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SoA.Location = new System.Drawing.Point(111, 47);
            this.tb_SoA.Name = "tb_SoA";
            this.tb_SoA.Size = new System.Drawing.Size(346, 22);
            this.tb_SoA.TabIndex = 1;
            this.tb_SoA.Leave += new System.EventHandler(this.tb_SoA_Leave);
            // 
            // tb_SoB
            // 
            this.tb_SoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SoB.Location = new System.Drawing.Point(111, 88);
            this.tb_SoB.Name = "tb_SoB";
            this.tb_SoB.Size = new System.Drawing.Size(346, 22);
            this.tb_SoB.TabIndex = 2;
            this.tb_SoB.Leave += new System.EventHandler(this.tb_SoB_Leave);
            // 
            // tb_SoC
            // 
            this.tb_SoC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SoC.Location = new System.Drawing.Point(111, 131);
            this.tb_SoC.Name = "tb_SoC";
            this.tb_SoC.Size = new System.Drawing.Size(346, 22);
            this.tb_SoC.TabIndex = 3;
            this.tb_SoC.Leave += new System.EventHandler(this.tb_SoC_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết quả";
            // 
            // tb_KQ1
            // 
            this.tb_KQ1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_KQ1.Location = new System.Drawing.Point(139, 212);
            this.tb_KQ1.Name = "tb_KQ1";
            this.tb_KQ1.Size = new System.Drawing.Size(135, 22);
            this.tb_KQ1.TabIndex = 7;
            // 
            // tb_KQ2
            // 
            this.tb_KQ2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_KQ2.Location = new System.Drawing.Point(322, 212);
            this.tb_KQ2.Name = "tb_KQ2";
            this.tb_KQ2.Size = new System.Drawing.Size(135, 22);
            this.tb_KQ2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "x1";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "x2";
            // 
            // bt_Tinh
            // 
            this.bt_Tinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Tinh.Location = new System.Drawing.Point(598, 40);
            this.bt_Tinh.Name = "bt_Tinh";
            this.bt_Tinh.Size = new System.Drawing.Size(140, 70);
            this.bt_Tinh.TabIndex = 4;
            this.bt_Tinh.Text = "Tính";
            this.bt_Tinh.UseVisualStyleBackColor = true;
            this.bt_Tinh.Click += new System.EventHandler(this.bt_Tinh_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Thoat.Location = new System.Drawing.Point(598, 261);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(140, 70);
            this.bt_Thoat.TabIndex = 5;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thayĐổiToolStripMenuItem,
            this.đổiFontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 52);
            this.contextMenuStrip1.Text = "Thay đổi";
            // 
            // thayĐổiToolStripMenuItem
            // 
            this.thayĐổiToolStripMenuItem.Name = "thayĐổiToolStripMenuItem";
            this.thayĐổiToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.thayĐổiToolStripMenuItem.Text = "Đổi màu ";
            // 
            // đổiFontToolStripMenuItem
            // 
            this.đổiFontToolStripMenuItem.Name = "đổiFontToolStripMenuItem";
            this.đổiFontToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.đổiFontToolStripMenuItem.Text = "Đổi font";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_Tinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_KQ2);
            this.Controls.Add(this.tb_KQ1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_SoC);
            this.Controls.Add(this.tb_SoB);
            this.Controls.Add(this.tb_SoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giải phương trình bậc 2";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_SoA;
        private System.Windows.Forms.TextBox tb_SoB;
        private System.Windows.Forms.TextBox tb_SoC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_KQ1;
        private System.Windows.Forms.TextBox tb_KQ2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_Tinh;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiFontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

