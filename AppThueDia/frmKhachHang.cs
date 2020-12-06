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
    public partial class frmKhachHang : Form
    {
        KhachHangBUS khachHangBUS;
        List<eKhachHang> listKhachHang;
        private BindingSource bsKhachHang;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            bsKhachHang = new BindingSource();
            khachHangBUS = new KhachHangBUS();
            listKhachHang = new List<eKhachHang>();
            listKhachHang = khachHangBUS.getAllKhachHang();
            bsKhachHang.DataSource = listKhachHang;        
            dgvDSDia.DataSource = bsKhachHang;
            CustomGirdView();


        }

        public void  CustomGirdView()
        {
            dgvDSDia.Dock = DockStyle.Fill;
            dgvDSDia.AutoResizeColumns();
            
        }

        private void dgvDSDia_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
           
        }

        private void dgvDSDia_Click(object sender, EventArgs e)
        {
            try
            {
                eKhachHang eKhachHang = (eKhachHang)bsKhachHang.Current;
                txtMaDia.Text = eKhachHang.MaKhachHang;
                txtTenKH.Text = eKhachHang.TenKhachHang;
                txtSoDienThoai.Text = eKhachHang.SoDienThoai;
                txtDiaChi.Text = eKhachHang.DiaChi;
            }
            catch
            {
                throw;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDia.Text.Length > 0)
            {
                DialogResult dlgHoiXoa;
                dlgHoiXoa = MessageBox.Show("Xác nhận xóa khách hàng " + txtTenKH.Text, "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dlgHoiXoa == DialogResult.Yes)
                {
             
                    if (khachHangBUS.deleteKhachHang(txtMaDia.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công");
                        listKhachHang = khachHangBUS.getAllKhachHang();
                        bsKhachHang.DataSource = listKhachHang;
                        dgvDSDia.DataSource = bsKhachHang;

                    }
                    else MessageBox.Show("Xóa thất bại");
                    
                }
            }
        }
    }
}
