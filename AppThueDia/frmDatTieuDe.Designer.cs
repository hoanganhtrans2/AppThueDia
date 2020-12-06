namespace AppThueDia
{
    partial class frmDatTieuDe
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
            this.dgvDatTieuDe = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDia = new System.Windows.Forms.TextBox();
            this.btnTimMaKH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.btnHuyDatTieuDe = new System.Windows.Forms.Button();
            this.btnDatTieuDe = new System.Windows.Forms.Button();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatTieuDe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatTieuDe
            // 
            this.dgvDatTieuDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatTieuDe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NgayDatHang,
            this.MaKhachHang,
            this.MaTieuDe});
            this.dgvDatTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatTieuDe.Location = new System.Drawing.Point(3, 22);
            this.dgvDatTieuDe.Name = "dgvDatTieuDe";
            this.dgvDatTieuDe.RowTemplate.Height = 28;
            this.dgvDatTieuDe.Size = new System.Drawing.Size(1271, 317);
            this.dgvDatTieuDe.TabIndex = 0;
            this.dgvDatTieuDe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatTieuDe_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NgayDatHang
            // 
            this.NgayDatHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayDatHang.HeaderText = "Ngày đặt";
            this.NgayDatHang.Name = "NgayDatHang";
            this.NgayDatHang.ReadOnly = true;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKhachHang.HeaderText = "Mã Khách Hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.ReadOnly = true;
            // 
            // MaTieuDe
            // 
            this.MaTieuDe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTieuDe.HeaderText = "Mã Tiêu Đề";
            this.MaTieuDe.Name = "MaTieuDe";
            this.MaTieuDe.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khách hàng:";
            // 
            // txtMaDia
            // 
            this.txtMaDia.Location = new System.Drawing.Point(118, 102);
            this.txtMaDia.Name = "txtMaDia";
            this.txtMaDia.Size = new System.Drawing.Size(276, 26);
            this.txtMaDia.TabIndex = 2;
            // 
            // btnTimMaKH
            // 
            this.btnTimMaKH.Location = new System.Drawing.Point(400, 102);
            this.btnTimMaKH.Name = "btnTimMaKH";
            this.btnTimMaKH.Size = new System.Drawing.Size(148, 26);
            this.btnTimMaKH.TabIndex = 3;
            this.btnTimMaKH.Text = "Tìm";
            this.btnTimMaKH.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.txtMaDia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTimMaKH);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 293);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm đặt trước";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(92, 196);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(191, 38);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Hiển thị tất cả";
            this.btnShowAll.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDatTieuDe);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1277, 342);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
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
            this.label6.Text = "ĐẶT TIÊU ĐỀ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tiêu đề:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày đặt:";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Enabled = false;
            this.txtTieuDe.Location = new System.Drawing.Point(229, 55);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(276, 26);
            this.txtTieuDe.TabIndex = 10;
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Enabled = false;
            this.txtGiaThue.Location = new System.Drawing.Point(229, 102);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(276, 26);
            this.txtGiaThue.TabIndex = 9;
            // 
            // btnHuyDatTieuDe
            // 
            this.btnHuyDatTieuDe.Enabled = false;
            this.btnHuyDatTieuDe.Location = new System.Drawing.Point(357, 251);
            this.btnHuyDatTieuDe.Name = "btnHuyDatTieuDe";
            this.btnHuyDatTieuDe.Size = new System.Drawing.Size(148, 36);
            this.btnHuyDatTieuDe.TabIndex = 3;
            this.btnHuyDatTieuDe.Text = "Hủy đặt";
            this.btnHuyDatTieuDe.UseVisualStyleBackColor = true;
            // 
            // btnDatTieuDe
            // 
            this.btnDatTieuDe.Location = new System.Drawing.Point(525, 251);
            this.btnDatTieuDe.Name = "btnDatTieuDe";
            this.btnDatTieuDe.Size = new System.Drawing.Size(148, 36);
            this.btnDatTieuDe.TabIndex = 3;
            this.btnDatTieuDe.Text = "Đặt";
            this.btnDatTieuDe.UseVisualStyleBackColor = true;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Enabled = false;
            this.txtSoNgay.Location = new System.Drawing.Point(229, 149);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(276, 26);
            this.txtSoNgay.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSoNgay);
            this.groupBox2.Controls.Add(this.btnDatTieuDe);
            this.groupBox2.Controls.Add(this.btnHuyDatTieuDe);
            this.groupBox2.Controls.Add(this.txtGiaThue);
            this.groupBox2.Controls.Add(this.txtTieuDe);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(592, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 293);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // frmDatTieuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 680);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatTieuDe";
            this.Text = "f";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatTieuDe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDia;
        private System.Windows.Forms.Button btnTimMaKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTieuDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Button btnHuyDatTieuDe;
        private System.Windows.Forms.Button btnDatTieuDe;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}