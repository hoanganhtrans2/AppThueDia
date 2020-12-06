using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AppThueDia
{
    public partial class frmChucNang : DevExpress.XtraEditors.XtraForm
    {
        public frmChucNang()
        {
            InitializeComponent();
        }

        private void frmChucNang_Load(object sender, EventArgs e)
        {
            frmThueDia f = new frmThueDia();
            f.TopLevel = false;
            pnMain.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();

        }

        private void menuThueDia_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            frmThueDia f = new frmThueDia();
            f.TopLevel = false;
            pnMain.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void menuQLKH_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            frmKhachHang f = new frmKhachHang();
            f.TopLevel = false;
            pnMain.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void menuTieuDe_Click(object sender, EventArgs e)
        {
            if (frmDangNhap.idDN != 0)
            {
                pnMain.Controls.Clear();
                frmTieuDe f = new frmTieuDe();
                f.TopLevel = false;
                pnMain.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.Show();
            }
            else MessageBox.Show("Cần đăng nhập để thực hiện chức năng này!");
            
        }

        private void menuDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
            this.Hide();
        }

        private void menuTraDia_Click(object sender, EventArgs e)
        {
            frmTraDia fTD = new frmTraDia();
            fTD.Show();
        }

        private void menuDatTieuDe_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            frmDatTieuDe f = new frmDatTieuDe();
            f.TopLevel = false;
            pnMain.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void menuQLDia_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            frmDia f = new frmDia();
            f.TopLevel = false;
            pnMain.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void huyPhiTraTre_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            frmHuyKhoanPhiTre f = new frmHuyKhoanPhiTre();
            f.TopLevel = false;
            pnMain.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }
    }
}