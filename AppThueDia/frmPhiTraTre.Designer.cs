namespace AppThueDia
{
    partial class frmPhiTraTre
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
            this.lvPhiTraTre = new System.Windows.Forms.ListView();
            this.maDonHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maDia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hanTraDia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngayTraDia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phiTraTre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbPhiTraTre = new System.Windows.Forms.GroupBox();
            this.btnXong = new System.Windows.Forms.Button();
            this.grbPhiTraTre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPhiTraTre
            // 
            this.lvPhiTraTre.CheckBoxes = true;
            this.lvPhiTraTre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maDonHang,
            this.maDia,
            this.hanTraDia,
            this.ngayTraDia,
            this.phiTraTre});
            this.lvPhiTraTre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvPhiTraTre.GridLines = true;
            this.lvPhiTraTre.HideSelection = false;
            this.lvPhiTraTre.Location = new System.Drawing.Point(4, 23);
            this.lvPhiTraTre.Margin = new System.Windows.Forms.Padding(4);
            this.lvPhiTraTre.Name = "lvPhiTraTre";
            this.lvPhiTraTre.Size = new System.Drawing.Size(929, 366);
            this.lvPhiTraTre.TabIndex = 1;
            this.lvPhiTraTre.UseCompatibleStateImageBehavior = false;
            // 
            // maDonHang
            // 
            this.maDonHang.Text = "Mã đơn hàng";
            this.maDonHang.Width = 200;
            // 
            // maDia
            // 
            this.maDia.Text = "Mã đĩa";
            this.maDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maDia.Width = 150;
            // 
            // hanTraDia
            // 
            this.hanTraDia.Text = "Hạn trả đĩa";
            this.hanTraDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hanTraDia.Width = 200;
            // 
            // ngayTraDia
            // 
            this.ngayTraDia.Text = "Ngày trả đĩa";
            this.ngayTraDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ngayTraDia.Width = 200;
            // 
            // phiTraTre
            // 
            this.phiTraTre.Text = "Phí Trả Trễ";
            this.phiTraTre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phiTraTre.Width = 200;
            // 
            // grbPhiTraTre
            // 
            this.grbPhiTraTre.Controls.Add(this.btnXong);
            this.grbPhiTraTre.Controls.Add(this.lvPhiTraTre);
            this.grbPhiTraTre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbPhiTraTre.Location = new System.Drawing.Point(0, 0);
            this.grbPhiTraTre.Margin = new System.Windows.Forms.Padding(4);
            this.grbPhiTraTre.Name = "grbPhiTraTre";
            this.grbPhiTraTre.Padding = new System.Windows.Forms.Padding(4);
            this.grbPhiTraTre.Size = new System.Drawing.Size(937, 452);
            this.grbPhiTraTre.TabIndex = 2;
            this.grbPhiTraTre.TabStop = false;
            this.grbPhiTraTre.Text = "Thông tin phí trả trễ của khách hàng:";
            // 
            // btnXong
            // 
            this.btnXong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXong.Location = new System.Drawing.Point(782, 389);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(151, 59);
            this.btnXong.TabIndex = 2;
            this.btnXong.Text = "Xong";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // frmPhiTraTre
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 452);
            this.Controls.Add(this.grbPhiTraTre);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhiTraTre";
            this.Text = "Thông tin nợ phí";
            this.Load += new System.EventHandler(this.frmPhiTraTre_Load);
            this.grbPhiTraTre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPhiTraTre;
        private System.Windows.Forms.ColumnHeader maDonHang;
        private System.Windows.Forms.ColumnHeader maDia;
        private System.Windows.Forms.ColumnHeader hanTraDia;
        private System.Windows.Forms.ColumnHeader ngayTraDia;
        private System.Windows.Forms.ColumnHeader phiTraTre;
        private System.Windows.Forms.GroupBox grbPhiTraTre;
        private System.Windows.Forms.Button btnXong;
    }
}