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
    public partial class frmHuyKhoanPhiTre : Form
    {
        public frmHuyKhoanPhiTre()
        {
            InitializeComponent();
        }
        KhachHangBUS khachHangBUS;
        ChiTietDonHangBUS chiTietDonHangBUS;
        DonHangBUS donHangBUS;
        BindingSource bsKhachHang;
        BindingSource bsDonHang;
        private string currenMaKhachHang;

        private void frmHuyKhoanPhiTre_Load(object sender, EventArgs e)
        {
            khachHangBUS = new KhachHangBUS();
            bsKhachHang = new BindingSource();
            bsDonHang = new BindingSource();
            donHangBUS = new DonHangBUS();
            bsKhachHang.DataSource = khachHangBUS.getAllKhachHang();
            ltbKhachHang.DataSource = bsKhachHang;
            ltbKhachHang.DisplayMember = "TenKhachHang";
            ltbKhachHang.ValueMember = "MaKhachHang";
            


        }
        public void CustomGirdView()
        {
            
            dgvDonHang.ReadOnly = true;
            dgvDonHang.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;
           // dgvDonHang.Columns["MaDonHang"].Visible = false;
            
        }

        public void CustomGirdViewChiTietDonHang()
        {

            dgvChiTietDonHang.ReadOnly = true;
            dgvChiTietDonHang.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;
            dgvChiTietDonHang.Columns["MaDia"].Visible = false;
            dgvChiTietDonHang.Columns["MaTieuDe"].Visible = false;
            dgvChiTietDonHang.Columns["TrangThai"].Visible = false;
            dgvChiTietDonHang.Columns["SoLuongDia"].Visible = false;
            dgvChiTietDonHang.Columns["Deleted"].Visible = false;
            dgvChiTietDonHang.Columns["DeletedDiskDVDGame"].Visible = false;

        }



        public void LoadKhachHangToLable(eKhachHang khachHang)
        {
            txtDiaChi.Text = khachHang.DiaChi;
            txtSoDienThoai.Text = khachHang.SoDienThoai;
            txtTenKhachHang.Text = khachHang.TenKhachHang;

        }
        private void ltbKhachHang_Click(object sender, EventArgs e)
        {
            if (ltbKhachHang.SelectedIndex != -1)
            {
                string mahk = ltbKhachHang.SelectedValue.ToString();
                currenMaKhachHang = mahk;
                eKhachHang khachHang = new eKhachHang();
                bsDonHang.DataSource = donHangBUS.getDonHangCuaKhachHang(mahk);
                khachHang = khachHangBUS.getKhachHangById(mahk);
                if(khachHang!=null)
                {
                    LoadKhachHangToLable(khachHang);
                }
                dgvDonHang.DataSource = bsDonHang;
                CustomGirdView();

                if(dgvDonHang.Rows.Count>=1)
                {
                    //eDonHang donHang = (eDonHang)bsDonHang.Current;
                    //if (donHang != null)
                    //{
                    //    List<eTieuDeGameDVD> ls = new List<eTieuDeGameDVD>();
                    //    ls = chiTietDonHangBUS.getChiTietDonHang(donHang.MaDonHang);
                    //    if (ls != null)
                    //    {
                    //        dgvChiTietDonHang.DataSource = ls;
                    //        CustomGirdViewChiTietDonHang();
                    //    }
                    //}
                }    
            }
        }

        eDonHang currentDonHang = new eDonHang();
        private void dgvDonHang_Click(object sender, EventArgs e)
        {
            try
            {
                eDonHang donHang = (eDonHang)bsDonHang.Current;
                currentDonHang = donHang;
                if (donHang != null)
                {
                    chiTietDonHangBUS = new ChiTietDonHangBUS();
                    List<eTieuDeGameDVD> ls = new List<eTieuDeGameDVD>();
                    ls = chiTietDonHangBUS.getChiTietDonHang(donHang.MaDonHang);
                    if (ls!=null)
                    {
                        dgvChiTietDonHang.DataSource = ls;
                        CustomGirdViewChiTietDonHang();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(currentDonHang.ThanhToanPhiNo == "Hủy khoản nợ"&& e.ColumnIndex == 6)
            {
                MessageBox.Show("Khoản nợ đã được hủy");
            }
            if (e.ColumnIndex == 6 && currentDonHang.ThanhToanPhiNo!= "Hủy khoản nợ")
            {
                eDonHang donHang = currentDonHang;
                DialogResult dlgHoiXoa;
                dlgHoiXoa = MessageBox.Show("Xác nhận hủy khoản phí trả trể", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dlgHoiXoa == DialogResult.Yes)
                {
                    if (donHangBUS.huyPhiTraTre(donHang.MaDonHang))
                    {
                        MessageBox.Show("Hủy khoản nợ thành công");
                        bsDonHang.DataSource = donHangBUS.getDonHangCuaKhachHang(currenMaKhachHang);             
                        dgvDonHang.DataSource = bsDonHang;
                    }
                    else MessageBox.Show("Hủy khoản nợ thất bại");
                    
                }

            }
        }
    }
}
