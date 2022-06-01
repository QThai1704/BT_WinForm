namespace BTTH01
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
            this.btHienThi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSNT = new System.Windows.Forms.Label();
            this.lbSCP = new System.Windows.Forms.Label();
            this.lbSHH = new System.Windows.Forms.Label();
            this.tbSoN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btHienThi
            // 
            this.btHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btHienThi.Location = new System.Drawing.Point(669, 12);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(119, 93);
            this.btHienThi.TabIndex = 2;
            this.btHienThi.Text = "Hiển thị";
            this.btHienThi.UseVisualStyleBackColor = true;
            this.btHienThi.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số n:";
            // 
            // lbSNT
            // 
            this.lbSNT.AutoSize = true;
            this.lbSNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSNT.Location = new System.Drawing.Point(12, 120);
            this.lbSNT.Name = "lbSNT";
            this.lbSNT.Size = new System.Drawing.Size(199, 25);
            this.lbSNT.TabIndex = 7;
            this.lbSNT.Text = "Các số nguyên tố <n:";
            // 
            // lbSCP
            // 
            this.lbSCP.AutoSize = true;
            this.lbSCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSCP.Location = new System.Drawing.Point(12, 198);
            this.lbSCP.Name = "lbSCP";
            this.lbSCP.Size = new System.Drawing.Size(231, 25);
            this.lbSCP.TabIndex = 3;
            this.lbSCP.Text = "Các số chính phương <n:";
            // 
            // lbSHH
            // 
            this.lbSHH.AutoSize = true;
            this.lbSHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSHH.Location = new System.Drawing.Point(12, 272);
            this.lbSHH.Name = "lbSHH";
            this.lbSHH.Size = new System.Drawing.Size(195, 25);
            this.lbSHH.TabIndex = 4;
            this.lbSHH.Text = "Các số hoàn hảo <n:";
            // 
            // tbSoN
            // 
            this.tbSoN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSoN.Location = new System.Drawing.Point(155, 45);
            this.tbSoN.Name = "tbSoN";
            this.tbSoN.Size = new System.Drawing.Size(446, 22);
            this.tbSoN.TabIndex = 1;
            this.tbSoN.Leave += new System.EventHandler(this.tbSoN_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSoN);
            this.Controls.Add(this.lbSHH);
            this.Controls.Add(this.lbSCP);
            this.Controls.Add(this.lbSNT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btHienThi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHienThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSNT;
        private System.Windows.Forms.Label lbSCP;
        private System.Windows.Forms.Label lbSHH;
        private System.Windows.Forms.TextBox tbSoN;
    }
}

