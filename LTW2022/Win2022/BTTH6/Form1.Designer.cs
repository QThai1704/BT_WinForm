namespace BTTH6
{
    partial class Form_Chuoi
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
            this.ctMS_Change = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_ChuoiA = new System.Windows.Forms.Label();
            this.lb_ChuoiB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_ChuoiA = new System.Windows.Forms.TextBox();
            this.tb_ChuoiB = new System.Windows.Forms.TextBox();
            this.lb_NhapDL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ChuoiANguoc = new System.Windows.Forms.TextBox();
            this.tb_ChuoiBNguoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.ctMS_Change.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctMS_Change
            // 
            this.ctMS_Change.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctMS_Change.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMàuToolStripMenuItem,
            this.đổiFontToolStripMenuItem});
            this.ctMS_Change.Name = "ctMS_Change";
            this.ctMS_Change.Size = new System.Drawing.Size(140, 52);
            this.ctMS_Change.Text = "Thay đổi";
            // 
            // đổiMàuToolStripMenuItem
            // 
            this.đổiMàuToolStripMenuItem.Name = "đổiMàuToolStripMenuItem";
            this.đổiMàuToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.đổiMàuToolStripMenuItem.Text = "Đổi màu ";
            // 
            // đổiFontToolStripMenuItem
            // 
            this.đổiFontToolStripMenuItem.Name = "đổiFontToolStripMenuItem";
            this.đổiFontToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.đổiFontToolStripMenuItem.Text = "Đổi font";
            // 
            // lb_ChuoiA
            // 
            this.lb_ChuoiA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ChuoiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChuoiA.Location = new System.Drawing.Point(3, 0);
            this.lb_ChuoiA.Name = "lb_ChuoiA";
            this.lb_ChuoiA.Size = new System.Drawing.Size(145, 50);
            this.lb_ChuoiA.TabIndex = 2;
            this.lb_ChuoiA.Text = "Chuỗi a";
            this.lb_ChuoiA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ChuoiB
            // 
            this.lb_ChuoiB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ChuoiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChuoiB.Location = new System.Drawing.Point(3, 50);
            this.lb_ChuoiB.Name = "lb_ChuoiB";
            this.lb_ChuoiB.Size = new System.Drawing.Size(145, 50);
            this.lb_ChuoiB.TabIndex = 3;
            this.lb_ChuoiB.Text = "Chuỗi b";
            this.lb_ChuoiB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.45876F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.54124F));
            this.tableLayoutPanel1.Controls.Add(this.lb_ChuoiB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_ChuoiA, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_ChuoiB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_ChuoiA, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 100);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tb_ChuoiA
            // 
            this.tb_ChuoiA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ChuoiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ChuoiA.Location = new System.Drawing.Point(154, 3);
            this.tb_ChuoiA.Multiline = true;
            this.tb_ChuoiA.Name = "tb_ChuoiA";
            this.tb_ChuoiA.Size = new System.Drawing.Size(619, 44);
            this.tb_ChuoiA.TabIndex = 4;
            // 
            // tb_ChuoiB
            // 
            this.tb_ChuoiB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ChuoiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ChuoiB.Location = new System.Drawing.Point(154, 53);
            this.tb_ChuoiB.Multiline = true;
            this.tb_ChuoiB.Name = "tb_ChuoiB";
            this.tb_ChuoiB.Size = new System.Drawing.Size(619, 44);
            this.tb_ChuoiB.TabIndex = 5;
            // 
            // lb_NhapDL
            // 
            this.lb_NhapDL.AutoSize = true;
            this.lb_NhapDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NhapDL.Location = new System.Drawing.Point(7, 9);
            this.lb_NhapDL.Name = "lb_NhapDL";
            this.lb_NhapDL.Size = new System.Drawing.Size(133, 25);
            this.lb_NhapDL.TabIndex = 5;
            this.lb_NhapDL.Text = "Nhập dữ liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kết quả";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.45876F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.54124F));
            this.tableLayoutPanel2.Controls.Add(this.tb_ChuoiANguoc, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_ChuoiBNguoc, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 191);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(776, 100);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chuỗi b";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ChuoiANguoc
            // 
            this.tb_ChuoiANguoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ChuoiANguoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ChuoiANguoc.Location = new System.Drawing.Point(154, 3);
            this.tb_ChuoiANguoc.Multiline = true;
            this.tb_ChuoiANguoc.Name = "tb_ChuoiANguoc";
            this.tb_ChuoiANguoc.ReadOnly = true;
            this.tb_ChuoiANguoc.Size = new System.Drawing.Size(619, 44);
            this.tb_ChuoiANguoc.TabIndex = 4;
            // 
            // tb_ChuoiBNguoc
            // 
            this.tb_ChuoiBNguoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ChuoiBNguoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ChuoiBNguoc.Location = new System.Drawing.Point(154, 53);
            this.tb_ChuoiBNguoc.Multiline = true;
            this.tb_ChuoiBNguoc.Name = "tb_ChuoiBNguoc";
            this.tb_ChuoiBNguoc.ReadOnly = true;
            this.tb_ChuoiBNguoc.Size = new System.Drawing.Size(619, 44);
            this.tb_ChuoiBNguoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chuỗi a";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.tableLayoutPanel3.SetRowSpan(this.button1, 2);
            this.button1.Size = new System.Drawing.Size(142, 68);
            this.button1.TabIndex = 8;
            this.button1.Text = "Chuỗi con";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(418, 345);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(370, 74);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 3);
            this.button2.Name = "button2";
            this.tableLayoutPanel3.SetRowSpan(this.button2, 2);
            this.button2.Size = new System.Drawing.Size(142, 68);
            this.button2.TabIndex = 10;
            this.button2.Text = "Đảo chuỗi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form_Chuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_NhapDL);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_Chuoi";
            this.Text = "Chuỗi";
            this.Load += new System.EventHandler(this.Form_Chuoi_Load);
            this.ctMS_Change.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ctMS_Change;
        private System.Windows.Forms.ToolStripMenuItem đổiMàuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiFontToolStripMenuItem;
        private System.Windows.Forms.Label lb_ChuoiA;
        private System.Windows.Forms.Label lb_ChuoiB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_ChuoiB;
        private System.Windows.Forms.TextBox tb_ChuoiA;
        private System.Windows.Forms.Label lb_NhapDL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_ChuoiANguoc;
        private System.Windows.Forms.TextBox tb_ChuoiBNguoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button2;
    }
}

