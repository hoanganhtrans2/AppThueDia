using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BUS;

namespace AppThueDia
{
    public partial class frmTieuDe : Form
    {
        public frmTieuDe()
        {
            InitializeComponent();
        }
        TieuDeBUS tieuDeBUS;
        BindingSource bsTieuDe;
        List<eATieuDe> lsTieuDe;
        List<string> loaiDia;
        private void frmTieuDe_Load(object sender, EventArgs e)
        {
            tieuDeBUS = new TieuDeBUS();
            bsTieuDe = new BindingSource();
            lsTieuDe = new List<eATieuDe>();
            loaiDia = new List<string>() { "GAME", "MOVIE" };
            cbLoaiDia.DataSource = loaiDia;
            bsTieuDe.DataSource = tieuDeBUS.getAllTieuDe();
            dgvDSDia.DataSource = bsTieuDe;
            CustomGirdView();

        }
        private void btnThemTD_Click(object sender, EventArgs e)
        {

            choPhepNhapThongTin();
            if (btnThemTD.Text == "Lưu Lại")
            {

                if (kiemTraThongTinNhap())
                {
                    eATieuDe tieuDe = taoTieuDe();
                    if (tieuDeBUS.themTieuDe(tieuDe))
                    {
                        voHieuNhapThongTin();
                        btnThemTD.Text = "Thêm";
                        btnSuaTD.Text = "Sửa";
                        MessageBox.Show("Thêm tiêu đề mới thành công");
                        bsTieuDe.DataSource = tieuDeBUS.getAllTieuDe();
                        dgvDSDia.DataSource = bsTieuDe;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không lưu được");
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai thông tin");
                }
            }
            else
            {
                btnThemTD.Text = "Lưu Lại";
                btnSuaTD.Text = "Hủy";
            }

        }
        public void CustomGirdView()
        {
            dgvDSDia.Dock = DockStyle.Fill;
            dgvDSDia.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;
           // dgvDSDia.Columns["Deleted"].Visible = false;

        }
        public bool kiemTraThongTinNhap()
        {
            eATieuDe tieuDe = taoTieuDe();
            if (tieuDe!=null&&tieuDe.TieuDe.Length>0) return true;
            return false;
        }

        public void choPhepNhapThongTin()
        {
            
            eATieuDe temp = tieuDeBUS.getTieuDeTheoLoai(cbLoaiDia.Text);
            txtGiaThue.Text = temp.GiaThue.ToString();
            txtSoNgay.Text = temp.SoNgayDuocThue.ToString();
            txtTieuDe.Enabled = true;
            txtGiaThue.Enabled = false;
            txtSoNgay.Enabled = false;
            txtTrangThai.Enabled = false;
            txtMaDia.Enabled = true;
            txtSoLuong.Text = "0";
            txtTrangThai.Text = "Nhập mới";

        }
        public void voHieuNhapThongTin()
        {
            txtGiaThue.Text = "";
            txtSoLuong.Text = "";
            txtTieuDe.Text = "";
            txtSoNgay.Text = "";
            cbLoaiDia.Text = "";
            txtTrangThai.Text = "";
            txtTieuDe.Enabled = false;
            txtGiaThue.Enabled = false;
            txtSoNgay.Enabled = false;
            txtTrangThai.Enabled = false;
            txtMaDia.Enabled = true;
            txtSoLuong.Text = "";
            List<string> loaiDia = new List<string>() { "GAME", "MOVIE" };
            cbLoaiDia.DataSource = loaiDia;
        }

        public eATieuDe taoTieuDe()
        {
            eATieuDe etieuDe = new eATieuDe();
            try
            {
                etieuDe.TieuDe = txtTieuDe.Text;
                etieuDe.GiaThue = float.Parse(txtGiaThue.Text);
                etieuDe.Deleted = false;
                etieuDe.SoNgayDuocThue = int.Parse(txtSoNgay.Text);
                etieuDe.LoaiDia = cbLoaiDia.Text;
            }
            catch
            {
                return null;
            }
            return etieuDe;
        }

        public void capNhatThongTinVaoTextBox(eATieuDe eTieuDe)
        {
            txtGiaThue.Text = eTieuDe.GiaThue.ToString();
            txtSoLuong.Text = eTieuDe.SoLuongDia.ToString();
            txtTieuDe.Text = eTieuDe.TieuDe;
            txtSoNgay.Text = eTieuDe.SoNgayDuocThue.ToString();
            cbLoaiDia.Text = eTieuDe.LoaiDia;
            txtTrangThai.Text = eTieuDe.Deleted ? "Không còn cho thuê" : "Cho thuê";
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        eATieuDe currenTieuDe;
        private void dgvDSDia_Click(object sender, EventArgs e)
        {
            try
            {
                eATieuDe tieuDe = (eATieuDe)bsTieuDe.Current;
                currenTieuDe = tieuDe;
                capNhatThongTinVaoTextBox(tieuDe);
            }
            catch
            {
                throw;
            }
        }

        private void btnSuaTD_Click(object sender, EventArgs e)
        {
            //hủy thêm tiêu đề mới
            if (btnSuaTD.Text == "Hủy")
            {
                btnThemTD.Text = "Thêm";
                btnSuaTD.Text = "Sửa";
                voHieuNhapThongTin();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            eATieuDe tieuDe = currenTieuDe;
            if (tieuDe.MaTieuDe.Length > 0)
            {
                DialogResult dlgHoiXoa;
                dlgHoiXoa = MessageBox.Show("Xác nhận xóa tiêu đề " + tieuDe.TieuDe, "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dlgHoiXoa == DialogResult.Yes)
                {

                    if (tieuDeBUS.deleteTieuDe(tieuDe.MaTieuDe))
                    {
                        MessageBox.Show("Xóa thành công");
                        bsTieuDe.DataSource = tieuDeBUS.getAllTieuDe();
                        dgvDSDia.DataSource = bsTieuDe;
                    }
                    else MessageBox.Show("Xóa thất bại");

                }
            }
        }

        private void dgvDSDia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex==6)
            {
                eATieuDe tieuDe = currenTieuDe;
                DialogResult dlgHoiXoa;
                dlgHoiXoa = MessageBox.Show("Xác nhận xóa tiêu đề " + tieuDe.TieuDe, "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dlgHoiXoa == DialogResult.Yes)
                {
                   
                    if (tieuDeBUS.deleteTieuDe(tieuDe.MaTieuDe))
                    {
                        MessageBox.Show("Xóa thành công");
                        bsTieuDe.DataSource = tieuDeBUS.getAllTieuDe();
                        dgvDSDia.DataSource = bsTieuDe;
                    }
                    else MessageBox.Show("Xóa thất bại");

                }
            }
        }

        private void cbLoaiDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cbLoaiDia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eATieuDe temp = new eATieuDe();
            switch (cbLoaiDia.SelectedIndex)
            {

                case 0:
                    temp = tieuDeBUS.getTieuDeTheoLoai("GAME");
                    txtGiaThue.Text = temp.GiaThue.ToString();
                    txtSoNgay.Text = temp.SoNgayDuocThue.ToString();
                    break;
                default:
                    temp = tieuDeBUS.getTieuDeTheoLoai("MOVIE");
                    txtGiaThue.Text = temp.GiaThue.ToString();
                    txtSoNgay.Text = temp.SoNgayDuocThue.ToString();
                    break;

            }
        }
    }
}
