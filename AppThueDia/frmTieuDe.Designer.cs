namespace AppThueDia
{
    partial class frmTieuDe
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
            this.dgvDSDia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDia = new System.Windows.Forms.TextBox();
            this.btnTimMaKH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbLoaiDia = new System.Windows.Forms.ComboBox();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.btnSuaTD = new System.Windows.Forms.Button();
            this.btnThemTD = new System.Windows.Forms.Button();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSDia
            // 
            this.dgvDSDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDia.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDSDia.Location = new System.Drawing.Point(3, 22);
            this.dgvDSDia.Name = "dgvDSDia";
            this.dgvDSDia.ReadOnly = true;
            this.dgvDSDia.RowTemplate.Height = 28;
            this.dgvDSDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDia.Size = new System.Drawing.Size(1271, 357);
            this.dgvDSDia.TabIndex = 0;
            this.dgvDSDia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDia_CellClick);
            this.dgvDSDia.Click += new System.EventHandler(this.dgvDSDia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiêu đề:";
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
            this.btnTimMaKH.Location = new System.Drawing.Point(400, 98);
            this.btnTimMaKH.Name = "btnTimMaKH";
            this.btnTimMaKH.Size = new System.Drawing.Size(148, 36);
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
            this.groupBox1.Size = new System.Drawing.Size(574, 277);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm tiêu đề";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.cbLoaiDia);
            this.groupBox2.Controls.Add(this.txtSoNgay);
            this.groupBox2.Controls.Add(this.btnSuaTD);
            this.groupBox2.Controls.Add(this.btnThemTD);
            this.groupBox2.Controls.Add(this.txtTrangThai);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.txtGiaThue);
            this.groupBox2.Controls.Add(this.txtTieuDe);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(592, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 293);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(232, 210);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 36);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa Tiêu Đề";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbLoaiDia
            // 
            this.cbLoaiDia.FormattingEnabled = true;
            this.cbLoaiDia.Location = new System.Drawing.Point(468, 102);
            this.cbLoaiDia.Name = "cbLoaiDia";
            this.cbLoaiDia.Size = new System.Drawing.Size(171, 27);
            this.cbLoaiDia.TabIndex = 11;
            this.cbLoaiDia.SelectedIndexChanged += new System.EventHandler(this.cbLoaiDia_SelectedIndexChanged);
            this.cbLoaiDia.SelectionChangeCommitted += new System.EventHandler(this.cbLoaiDia_SelectionChangeCommitted);
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Enabled = false;
            this.txtSoNgay.Location = new System.Drawing.Point(215, 99);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(116, 26);
            this.txtSoNgay.TabIndex = 8;
            // 
            // btnSuaTD
            // 
            this.btnSuaTD.Location = new System.Drawing.Point(525, 210);
            this.btnSuaTD.Name = "btnSuaTD";
            this.btnSuaTD.Size = new System.Drawing.Size(148, 36);
            this.btnSuaTD.TabIndex = 3;
            this.btnSuaTD.Text = "Sửa";
            this.btnSuaTD.UseVisualStyleBackColor = true;
            this.btnSuaTD.Click += new System.EventHandler(this.btnSuaTD_Click);
            // 
            // btnThemTD
            // 
            this.btnThemTD.Location = new System.Drawing.Point(357, 210);
            this.btnThemTD.Name = "btnThemTD";
            this.btnThemTD.Size = new System.Drawing.Size(148, 36);
            this.btnThemTD.TabIndex = 3;
            this.btnThemTD.Text = "Thêm";
            this.btnThemTD.UseVisualStyleBackColor = true;
            this.btnThemTD.Click += new System.EventHandler(this.btnThemTD_Click);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Location = new System.Drawing.Point(215, 175);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(116, 26);
            this.txtTrangThai.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(215, 138);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(116, 26);
            this.txtSoLuong.TabIndex = 9;
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Enabled = false;
            this.txtGiaThue.Location = new System.Drawing.Point(215, 63);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(202, 26);
            this.txtGiaThue.TabIndex = 9;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Enabled = false;
            this.txtTieuDe.Location = new System.Drawing.Point(215, 23);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(276, 26);
            this.txtTieuDe.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Trạng thái:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số ngày giữ đĩa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá thuê:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Loại đĩa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tiêu đề:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSDia);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1277, 382);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
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
            this.label6.Text = "TIÊU ĐỀ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTieuDe
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
            this.Name = "frmTieuDe";
            this.Text = "f";
            this.Load += new System.EventHandler(this.frmTieuDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDia;
        private System.Windows.Forms.Button btnTimMaKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuaTD;
        private System.Windows.Forms.Button btnThemTD;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLoaiDia;
        private System.Windows.Forms.Button btnXoa;
    }
}