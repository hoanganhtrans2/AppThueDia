using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Entity;

namespace AppThueDia
{
    public partial class frmBaoCaoTieuDe : Form
    {
        public frmBaoCaoTieuDe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        BaoCaoTieuDeBUS baoCaoTieuDeBUS;
        List<eABaoCaoTieuDe> lsTieuDeBC;
        private void frmBaoCaoTieuDe_Load(object sender, EventArgs e)
        {
            baoCaoTieuDeBUS = new BaoCaoTieuDeBUS();
            lsTieuDeBC = new List<eABaoCaoTieuDe>();
            lsTieuDeBC = baoCaoTieuDeBUS.getBaoCao();
            dgvBaoCao.DataSource = lsTieuDeBC;

            CustomGirdView();
        }

        public void CustomGirdView()
        {
            dgvBaoCao.ReadOnly = true;
            dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaoCao.Dock = DockStyle.Fill;
            dgvBaoCao.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBaoCao.Columns["Deleted"].Visible = false;
            dgvBaoCao.Columns["MaDia"].Visible = false;
            dgvBaoCao.Columns["MaTieuDe"].Visible = false;
            dgvBaoCao.Columns["TrangThai"].Visible = false;

        }
    }
}
