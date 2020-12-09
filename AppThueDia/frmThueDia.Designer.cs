namespace AppThueDia
{
    partial class frmThueDia
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
            this.txtMaDia = new System.Windows.Forms.TextBox();
            this.btnThue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLoaiDia = new System.Windows.Forms.TextBox();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaItem = new System.Windows.Forms.Button();
            this.lvDiaThue = new System.Windows.Forms.ListView();
            this.maDia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tieuDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTongThanhTien = new System.Windows.Forms.TextBox();
            this.txtPhiTraTre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đĩa:";
            // 
            // txtMaDia
            // 
            this.txtMaDia.Enabled = false;
            this.txtMaDia.Location = new System.Drawing.Point(217, 119);
            this.txtMaDia.Name = "txtMaDia";
            this.txtMaDia.Size = new System.Drawing.Size(276, 26);
            this.txtMaDia.TabIndex = 2;
            this.txtMaDia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaDia_KeyDown);
            // 
            // btnThue
            // 
            this.btnThue.Enabled = false;
            this.btnThue.Location = new System.Drawing.Point(519, 285);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(148, 36);
            this.btnThue.TabIndex = 3;
            this.btnThue.Text = "Thuê";
            this.btnThue.UseVisualStyleBackColor = true;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKhachHang);
            this.groupBox1.Controls.Add(this.txtMaDia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 257);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm đĩa";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(217, 57);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(276, 26);
            this.txtMaKhachHang.TabIndex = 2;
            this.txtMaKhachHang.TextChanged += new System.EventHandler(this.txtMaKhachHang_TextChanged);
            this.txtMaKhachHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKhachHang_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã khác hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLoaiDia);
            this.groupBox2.Controls.Add(this.txtSoNgay);
            this.groupBox2.Controls.Add(this.txtGiaThue);
            this.groupBox2.Controls.Add(this.txtTieuDe);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(592, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 257);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txtLoaiDia
            // 
            this.txtLoaiDia.Enabled = false;
            this.txtLoaiDia.Location = new System.Drawing.Point(245, 131);
            this.txtLoaiDia.Name = "txtLoaiDia";
            this.txtLoaiDia.Size = new System.Drawing.Size(276, 26);
            this.txtLoaiDia.TabIndex = 2;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Enabled = false;
            this.txtSoNgay.Location = new System.Drawing.Point(245, 172);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(276, 26);
            this.txtSoNgay.TabIndex = 2;
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Enabled = false;
            this.txtGiaThue.Location = new System.Drawing.Point(245, 90);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(276, 26);
            this.txtGiaThue.TabIndex = 2;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Enabled = false;
            this.txtTieuDe.ForeColor = System.Drawing.Color.Black;
            this.txtTieuDe.Location = new System.Drawing.Point(245, 49);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(276, 26);
            this.txtTieuDe.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hạn trả đĩa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giá thuê:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Loại đĩa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiêu đề:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaItem);
            this.groupBox3.Controls.Add(this.lvDiaThue);
            this.groupBox3.Location = new System.Drawing.Point(5, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 330);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách đĩa thuê:";
            // 
            // btnXoaItem
            // 
            this.btnXoaItem.Enabled = false;
            this.btnXoaItem.Location = new System.Drawing.Point(440, 285);
            this.btnXoaItem.Name = "btnXoaItem";
            this.btnXoaItem.Size = new System.Drawing.Size(135, 39);
            this.btnXoaItem.TabIndex = 1;
            this.btnXoaItem.Text = "Bỏ đĩa";
            this.btnXoaItem.UseVisualStyleBackColor = true;
            this.btnXoaItem.Click += new System.EventHandler(this.btnXoaItem_Click);
            // 
            // lvDiaThue
            // 
            this.lvDiaThue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maDia,
            this.tieuDe});
            this.lvDiaThue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvDiaThue.FullRowSelect = true;
            this.lvDiaThue.GridLines = true;
            this.lvDiaThue.HideSelection = false;
            this.lvDiaThue.Location = new System.Drawing.Point(3, 22);
            this.lvDiaThue.Name = "lvDiaThue";
            this.lvDiaThue.Size = new System.Drawing.Size(575, 246);
            this.lvDiaThue.TabIndex = 0;
            this.lvDiaThue.UseCompatibleStateImageBehavior = false;
            this.lvDiaThue.SelectedIndexChanged += new System.EventHandler(this.lvDiaThue_SelectedIndexChanged);
            // 
            // maDia
            // 
            this.maDia.Text = "Mã đĩa";
            this.maDia.Width = 200;
            // 
            // tieuDe
            // 
            this.tieuDe.Text = "Tiêu đề";
            this.tieuDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tieuDe.Width = 350;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1277, 43);
            this.label6.TabIndex = 7;
            this.label6.Text = "THUÊ ĐĨA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTongThanhTien);
            this.groupBox4.Controls.Add(this.txtPhiTraTre);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnThue);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(592, 338);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(673, 327);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phiếu thu";
            // 
            // txtTongThanhTien
            // 
            this.txtTongThanhTien.Enabled = false;
            this.txtTongThanhTien.Location = new System.Drawing.Point(203, 188);
            this.txtTongThanhTien.Name = "txtTongThanhTien";
            this.txtTongThanhTien.Size = new System.Drawing.Size(280, 26);
            this.txtTongThanhTien.TabIndex = 1;
            // 
            // txtPhiTraTre
            // 
            this.txtPhiTraTre.Enabled = false;
            this.txtPhiTraTre.Location = new System.Drawing.Point(203, 110);
            this.txtPhiTraTre.Name = "txtPhiTraTre";
            this.txtPhiTraTre.Size = new System.Drawing.Size(280, 26);
            this.txtPhiTraTre.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tổng thành tiền:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Phí trả trễ:";
            // 
            // frmThueDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 680);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThueDia";
            this.Text = "frmThueDia";
            this.Load += new System.EventHandler(this.frmThueDia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDia;
        private System.Windows.Forms.Button btnThue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoaiDia;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvDiaThue;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPhiTraTre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongThanhTien;
        private System.Windows.Forms.ColumnHeader maDia;
        private System.Windows.Forms.ColumnHeader tieuDe;
        private System.Windows.Forms.Button btnXoaItem;
    }
}