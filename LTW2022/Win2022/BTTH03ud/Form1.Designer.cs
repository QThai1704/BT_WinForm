namespace BTTH03ud
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
            this.dlChonAnh = new System.Windows.Forms.OpenFileDialog();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btChia = new System.Windows.Forms.Button();
            this.btBang = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btTich = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btCong = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.tbHienThiKetQua = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbHienThiBieuThuc = new System.Windows.Forms.TextBox();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayout.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlChonAnh
            // 
            this.dlChonAnh.FileName = "dlChonAnh";
            // 
            // tableLayout
            // 
            this.tableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout.ColumnCount = 4;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.Controls.Add(this.btChia, 3, 3);
            this.tableLayout.Controls.Add(this.btBang, 2, 3);
            this.tableLayout.Controls.Add(this.btXoa, 1, 3);
            this.tableLayout.Controls.Add(this.bt0, 0, 3);
            this.tableLayout.Controls.Add(this.btTich, 3, 2);
            this.tableLayout.Controls.Add(this.bt9, 2, 2);
            this.tableLayout.Controls.Add(this.bt8, 1, 2);
            this.tableLayout.Controls.Add(this.bt7, 0, 2);
            this.tableLayout.Controls.Add(this.btTru, 3, 1);
            this.tableLayout.Controls.Add(this.bt6, 2, 1);
            this.tableLayout.Controls.Add(this.bt4, 0, 1);
            this.tableLayout.Controls.Add(this.btCong, 3, 0);
            this.tableLayout.Controls.Add(this.bt3, 2, 0);
            this.tableLayout.Controls.Add(this.bt1, 0, 0);
            this.tableLayout.Controls.Add(this.bt2, 1, 0);
            this.tableLayout.Controls.Add(this.bt5, 1, 1);
            this.tableLayout.Location = new System.Drawing.Point(0, 117);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 4;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.Size = new System.Drawing.Size(785, 313);
            this.tableLayout.TabIndex = 7;
            // 
            // btChia
            // 
            this.btChia.BackColor = System.Drawing.Color.Fuchsia;
            this.btChia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChia.Location = new System.Drawing.Point(591, 237);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(191, 73);
            this.btChia.TabIndex = 15;
            this.btChia.Text = "/";
            this.btChia.UseVisualStyleBackColor = false;
            this.btChia.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btBang
            // 
            this.btBang.BackColor = System.Drawing.Color.Red;
            this.btBang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBang.Location = new System.Drawing.Point(395, 237);
            this.btBang.Name = "btBang";
            this.btBang.Size = new System.Drawing.Size(190, 73);
            this.btBang.TabIndex = 14;
            this.btBang.Text = "=";
            this.btBang.UseVisualStyleBackColor = false;
            this.btBang.Click += new System.EventHandler(this.btBang_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.BlueViolet;
            this.btXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(199, 237);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(190, 73);
            this.btXoa.TabIndex = 13;
            this.btXoa.Text = "C";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.Color.White;
            this.bt0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(3, 237);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(190, 73);
            this.bt0.TabIndex = 12;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btTich
            // 
            this.btTich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btTich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTich.Location = new System.Drawing.Point(591, 159);
            this.btTich.Name = "btTich";
            this.btTich.Size = new System.Drawing.Size(191, 72);
            this.btTich.TabIndex = 11;
            this.btTich.Text = "*";
            this.btTich.UseVisualStyleBackColor = false;
            this.btTich.Click += new System.EventHandler(this.btCong_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.Yellow;
            this.bt9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(395, 159);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(190, 72);
            this.bt9.TabIndex = 10;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.Indigo;
            this.bt8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(199, 159);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(190, 72);
            this.bt8.TabIndex = 9;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.Aqua;
            this.bt7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(3, 159);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(190, 72);
            this.bt7.TabIndex = 8;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btTru
            // 
            this.btTru.BackColor = System.Drawing.Color.Pink;
            this.btTru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTru.Location = new System.Drawing.Point(591, 81);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(191, 72);
            this.btTru.TabIndex = 7;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = false;
            this.btTru.Click += new System.EventHandler(this.btCong_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.Orchid;
            this.bt6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(395, 81);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(190, 72);
            this.bt6.TabIndex = 6;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(3, 81);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(190, 72);
            this.bt4.TabIndex = 4;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btCong
            // 
            this.btCong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCong.Location = new System.Drawing.Point(591, 3);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(191, 72);
            this.btCong.TabIndex = 3;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = false;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.YellowGreen;
            this.bt3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(395, 3);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(190, 72);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Khaki;
            this.bt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(3, 3);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(190, 72);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.OrangeRed;
            this.bt2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(199, 3);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(190, 72);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.Gold;
            this.bt5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(199, 81);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(190, 72);
            this.bt5.TabIndex = 5;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt1_Click);
            // 
            // tbHienThiKetQua
            // 
            this.tbHienThiKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHienThiKetQua.BackColor = System.Drawing.Color.Cyan;
            this.tbHienThiKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHienThiKetQua.Location = new System.Drawing.Point(0, 89);
            this.tbHienThiKetQua.Name = "tbHienThiKetQua";
            this.tbHienThiKetQua.Size = new System.Drawing.Size(785, 27);
            this.tbHienThiKetQua.TabIndex = 6;
            this.tbHienThiKetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lpToolStripMenuItem
            // 
            this.lpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpToolStripMenuItem.Name = "lpToolStripMenuItem";
            this.lpToolStripMenuItem.Size = new System.Drawing.Size(94, 45);
            this.lpToolStripMenuItem.Text = "Help";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(262, 46);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // backImageToolStripMenuItem
            // 
            this.backImageToolStripMenuItem.Name = "backImageToolStripMenuItem";
            this.backImageToolStripMenuItem.Size = new System.Drawing.Size(262, 46);
            this.backImageToolStripMenuItem.Text = "Back Image";
            this.backImageToolStripMenuItem.Click += new System.EventHandler(this.backImageToolStripMenuItem_Click);
            // 
            // tbHienThiBieuThuc
            // 
            this.tbHienThiBieuThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHienThiBieuThuc.BackColor = System.Drawing.Color.Yellow;
            this.tbHienThiBieuThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHienThiBieuThuc.Location = new System.Drawing.Point(0, 65);
            this.tbHienThiBieuThuc.Name = "tbHienThiBieuThuc";
            this.tbHienThiBieuThuc.ReadOnly = true;
            this.tbHienThiBieuThuc.Size = new System.Drawing.Size(785, 27);
            this.tbHienThiBieuThuc.TabIndex = 5;
            this.tbHienThiBieuThuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(262, 46);
            this.backColorToolStripMenuItem.Text = "Back color";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.backColorToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.lpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 49);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.editToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(77, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 46);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(184, 46);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(184, 46);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backColorToolStripMenuItem,
            this.backImageToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.changeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(134, 45);
            this.changeToolStripMenuItem.Text = "Change";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 433);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.tbHienThiKetQua);
            this.Controls.Add(this.tbHienThiBieuThuc);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayout.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlChonAnh;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Button btBang;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btTich;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.TextBox tbHienThiKetQua;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem lpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backImageToolStripMenuItem;
        private System.Windows.Forms.TextBox tbHienThiBieuThuc;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
    }
}

