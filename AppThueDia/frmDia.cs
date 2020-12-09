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
    public partial class frmDia : Form
    {

        public frmDia()
        {
            InitializeComponent();
        }
        DiskGameBUS diskGameBUS;
        List<eATieuDeGameDVD> lsTieuDeGameDVD;
        BindingSource bsDia;
        List<string> loaiDia;
        List<string> trangThaiDia;
        private void frmDia_Load(object sender, EventArgs e)
        {
            diskGameBUS = new DiskGameBUS();
            bsDia = new BindingSource();
            lsTieuDeGameDVD = new List<eATieuDeGameDVD>();
            loaiDia = new List<string>() { "DVD", "MOVIE" };
            trangThaiDia = new List<string>() { "onshelf", "rented", "onhold" };
            cbLoaiDia.DataSource = loaiDia;
            bsDia.DataSource = diskGameBUS.getAllDiskGameDVD();
            dgvDia.DataSource = bsDia;           
            CustomGirdView();

           
        }
        public void CustomGirdView()
        {
            dgvDia.ReadOnly = true;
            dgvDia.Dock = DockStyle.Fill;
            dgvDia.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDia.Columns["Deleted"].Visible = false;
            dgvDia.Columns["SoLuongDia"].Visible = false;
            dgvDia.Columns["MaTieuDe"].Visible = false;

        }
        public void capNhatThongTinVaoTextBox(eATieuDeGameDVD tieuDeGameDVD)
        {
            txtMaDia.Text = tieuDeGameDVD.MaDia;
            txtGiaThue.Text = tieuDeGameDVD.GiaThue.ToString();
            txtMaTieuDe.Text = tieuDeGameDVD.MaTieuDe;
            txtTieuDe.Text = tieuDeGameDVD.TieuDe;
            cbLoaiDia.Text = tieuDeGameDVD.LoaiDia;
            cbTrangThai.Text = tieuDeGameDVD.TrangThai;
        }

        eATieuDeGameDVD currentTieuDeGameDVD;
        private void dgvDia_Click(object sender, EventArgs e)
        {
            try
            {
                eATieuDeGameDVD tieuDe = (eATieuDeGameDVD)bsDia.Current;
                currentTieuDeGameDVD = tieuDe;
                capNhatThongTinVaoTextBox(tieuDe);
            }
            catch
            {
                throw;
            }
        }

        private void dgvDia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDia_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
           
        }

        private void dgvDia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                eATieuDeGameDVD tieuDe = currentTieuDeGameDVD;
              
                    DialogResult dlgHoiXoa;
                    dlgHoiXoa = MessageBox.Show("Xác nhận xóa mã đĩa "+ tieuDe.MaDia+ "tiêu đề đĩa " + tieuDe.TieuDe, "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dlgHoiXoa == DialogResult.Yes)
                    {

                        if (diskGameBUS.deleteDia(tieuDe.MaDia))
                        {
                            MessageBox.Show("Xóa thành công");
                            bsDia.DataSource = diskGameBUS.getAllDiskGameDVD();
                            dgvDia.DataSource = bsDia;
                        }
                        else MessageBox.Show("Xóa thất bại");

                    }
                
            }
               
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
