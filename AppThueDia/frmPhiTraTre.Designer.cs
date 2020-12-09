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
            this.grbPhiTraTre = new System.Windows.Forms.GroupBox();
            this.btnXong = new System.Windows.Forms.Button();
            this.lvPhiTraTre = new System.Windows.Forms.DataGridView();
            this.grbPhiTraTre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvPhiTraTre)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPhiTraTre
            // 
            this.grbPhiTraTre.Controls.Add(this.lvPhiTraTre);
            this.grbPhiTraTre.Controls.Add(this.btnXong);
            this.grbPhiTraTre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbPhiTraTre.Location = new System.Drawing.Point(0, 0);
            this.grbPhiTraTre.Margin = new System.Windows.Forms.Padding(4);
            this.grbPhiTraTre.Name = "grbPhiTraTre";
            this.grbPhiTraTre.Padding = new System.Windows.Forms.Padding(4);
            this.grbPhiTraTre.Size = new System.Drawing.Size(964, 472);
            this.grbPhiTraTre.TabIndex = 2;
            this.grbPhiTraTre.TabStop = false;
            this.grbPhiTraTre.Text = "Thông tin phí trả trễ của khách hàng:";
            // 
            // btnXong
            // 
            this.btnXong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnXong.Location = new System.Drawing.Point(4, 409);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(956, 59);
            this.btnXong.TabIndex = 2;
            this.btnXong.Text = "Xong";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // lvPhiTraTre
            // 
            this.lvPhiTraTre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lvPhiTraTre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPhiTraTre.Location = new System.Drawing.Point(4, 23);
            this.lvPhiTraTre.Name = "lvPhiTraTre";
            this.lvPhiTraTre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lvPhiTraTre.Size = new System.Drawing.Size(956, 386);
            this.lvPhiTraTre.TabIndex = 3;
            this.lvPhiTraTre.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.lvPhiTraTre_CellLeave);
            this.lvPhiTraTre.Click += new System.EventHandler(this.lvPhiTraTre_Click);
            // 
            // frmPhiTraTre
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 472);
            this.Controls.Add(this.grbPhiTraTre);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhiTraTre";
            this.Text = "Thông tin nợ phí";
            this.Load += new System.EventHandler(this.frmPhiTraTre_Load);
            this.grbPhiTraTre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvPhiTraTre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbPhiTraTre;
        private System.Windows.Forms.Button btnXong;
        private System.Windows.Forms.DataGridView lvPhiTraTre;
    }
}