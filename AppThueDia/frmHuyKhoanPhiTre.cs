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

        HuyKhoanNoBUS huyKhoanNoBUS;
        BindingSource bsKhachHang;
        BindingSource bsDonHang;
        private string currenMaKhachHang;

        private void frmHuyKhoanPhiTre_Load(object sender, EventArgs e)
        {
            khachHangBUS = new KhachHangBUS();
            bsKhachHang = new BindingSource();
            bsDonHang = new BindingSource();
            huyKhoanNoBUS = new HuyKhoanNoBUS();
            bsKhachHang.DataSource = khachHangBUS.getAllKhachHang();
            ltbKhachHang.DataSource = bsKhachHang;
            ltbKhachHang.DisplayMember = "TenKhachHang";
            ltbKhachHang.ValueMember = "MaKhachHang";
           
        }
        public void CustomGirdView()
        {
            dgvDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonHang.ReadOnly = true;
            dgvDonHang.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDonHang.Columns["MaDonHang"].Visible = false;
            dgvDonHang.Columns["MaDia"].Visible = false;
            dgvDonHang.Columns["MaTieuDe"].Visible = false;
            dgvDonHang.Columns["ThanhToanPhiNo"].Visible = false; 
            dgvDonHang.Columns["MaKhachHang"].Visible = false; 
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
                bsDonHang.DataSource = huyKhoanNoBUS.getChiTietDonHangCuaKhachHang(mahk);
                khachHang = khachHangBUS.getKhachHangById(mahk);
                if(khachHang!=null)
                {
                    LoadKhachHangToLable(khachHang);
                }
                dgvDonHang.DataSource = bsDonHang;
                CustomGirdView();

                
            }
        }

        eHuyKhoanNo curtenHuyKhoanNo;
        private void dgvDonHang_Click(object sender, EventArgs e)
        {
            try
            {
                curtenHuyKhoanNo = (eHuyKhoanNo)bsDonHang.Current;
               
            }
            catch
            {
                throw;
            }
        }

        private void btnHuyPhiTre_Click(object sender, EventArgs e)
        {
            if (curtenHuyKhoanNo != null)
            {
                DialogResult dlgHoiXoa;
                dlgHoiXoa = MessageBox.Show("Xác nhận hủy khoản nợ của khách hàng", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dlgHoiXoa == DialogResult.Yes)
                {

                    if (huyKhoanNoBUS.huyPhiTraTre(curtenHuyKhoanNo))
                    {
                        MessageBox.Show("Hủy thành công");
                        bsDonHang.DataSource = huyKhoanNoBUS.getChiTietDonHangCuaKhachHang(curtenHuyKhoanNo.MaKhachHang);
                        CustomGirdView();
                    }
                    else MessageBox.Show("Hủy thất bại");

                }
            }
            else
            {
                MessageBox.Show("Chọn khoản nợ cần hủy");
            }
        }

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ltbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
