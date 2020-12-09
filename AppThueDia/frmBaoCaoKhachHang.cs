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
    public partial class frmBaoCaoKhachHang : Form
    {
        public frmBaoCaoKhachHang()
        {
            InitializeComponent();
        }
        KhachHangBUS khachHangBUS;
        DiskGameBUS diskGameBUS;
        BindingSource bsKhachHang;
        List<string> lscbo = new List<string>() { "Tất cả khách hàng",
            "Khách hàng có mặt hàng quá hạn", "Khách hàng nợ phí trả chậm" };
       
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        public void LoadKhachHangToLable(eKhachHang khachHang)
        {
            txtDiaChi.Text = khachHang.DiaChi;
            txtSoDienThoai.Text = khachHang.SoDienThoai;
            txtTenKhachHang.Text = khachHang.TenKhachHang;

        }

        private void frmBaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            khachHangBUS = new KhachHangBUS();
            diskGameBUS = new DiskGameBUS();

            bsKhachHang = new BindingSource();

            cboKhachHang.DataSource = lscbo;
            bsKhachHang.DataSource = khachHangBUS.getAllKhachHang();
            ltbKhachHang.DataSource = bsKhachHang;
            ltbKhachHang.DisplayMember = "TenKhachHang";
            ltbKhachHang.ValueMember = "MaKhachHang";

            eKhachHang temp = (eKhachHang)bsKhachHang.Current;
            LoadKhachHangToLable(temp);
        }

        public void CustomGirdViewQH()
        {
            dgvQuaHan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuaHan.ReadOnly = true;
            dgvQuaHan.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;
            dgvQuaHan.Columns["MaDonHang"].Visible = false; 
            dgvQuaHan.Columns["DisplayThanhToanPhiNo"].Visible = false;
            //dgvQuaHan.Columns["MaDia"].Visible = false;
            dgvQuaHan.Columns["MaTieuDe"].Visible = false;
            dgvQuaHan.Columns["ThanhToanPhiNo"].Visible = false;
            dgvQuaHan.Columns["MaKhachHang"].Visible = false;
            dgvQuaHan.Columns["GiaThue"].Visible = false;
            dgvQuaHan.Columns["PhiTraTre"].Visible = false;
        }




        private void cboKhachHang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cboKhachHang.SelectedIndex)
            {
                case 0:
                    bsKhachHang.DataSource = khachHangBUS.getAllKhachHang();
                    ltbKhachHang.DataSource = bsKhachHang;
                    break;
                case 1:
                    bsKhachHang.DataSource = khachHangBUS.getDanhSachKhachHangCoMatHangQuahang();
                    ltbKhachHang.DataSource = bsKhachHang;
                    break;
                case 2:
                    bsKhachHang.DataSource = khachHangBUS.getDanhSachKhachHangTreNo();
                    ltbKhachHang.DataSource = bsKhachHang;
                    break;
                default:
                    break;
            }
        }

        private void ltbKhachHang_Click(object sender, EventArgs e)
        {
           
            if (ltbKhachHang.SelectedIndex != -1)
            {
                string makh = ltbKhachHang.SelectedValue.ToString();
                eKhachHang khachHang = khachHangBUS.getKhachHangById(makh);
                LoadKhachHangToLable(khachHang);
                LoadKhachHangToLable(khachHang);    
                List<eAHuyKhoanNo> ls = diskGameBUS.getThongTinDiaKhachHangChuaTra(khachHang.MaKhachHang);
                dgvQuaHan.DataSource = ls;
                lblSoDia.Text = ls.Count.ToString();
                CustomGirdViewQH();

                List<eAHuyKhoanNo> lsKhNo = diskGameBUS.getThongTinKhachHangDangNo(khachHang.MaKhachHang);
                dgvThongTinTreHan.DataSource = lsKhNo;
                float tong = 0;
                foreach (eAHuyKhoanNo obj in lsKhNo)
                    tong += (float)obj.PhiTraTre;
                lblChiPhiNo.Text = tong.ToString() + "đ";
                CustomGirdViewTH();
            }
        }

        public void CustomGirdViewTH()
        {
            dgvThongTinTreHan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongTinTreHan.ReadOnly = true;
            dgvThongTinTreHan.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;
            dgvThongTinTreHan.Columns["MaDonHang"].Visible = false;
            //dgvThongTinTreHan.Columns["MaDia"].Visible = false;
            dgvThongTinTreHan.Columns["MaTieuDe"].Visible = false;
           // dgvThongTinTreHan.Columns["ThanhToanPhiNo"].Visible = false;
            dgvThongTinTreHan.Columns["MaKhachHang"].Visible = false;
            dgvThongTinTreHan.Columns["GiaThue"].Visible = false;
            dgvThongTinTreHan.Columns["ThanhToanPhiNo"].Visible = false;
            // dgvThongTinTreHan.Columns["PhiTraTre"].Visible = false;
        }
    }
}
