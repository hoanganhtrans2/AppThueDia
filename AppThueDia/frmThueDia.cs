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
using System.Globalization;

namespace AppThueDia
{
    public partial class frmThueDia : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        BUS_Disk busDisk = new BUS_Disk();
        BUS_TieuDe busTieuDe = new BUS_TieuDe();
        BUS_ChiTietHoaDon busChiTiet = new BUS_ChiTietHoaDon();
        BUS_DonHang busDonHang = new BUS_DonHang();
        int index;
        public static string maKH = "";

        public frmThueDia()
        {
            InitializeComponent();
        }
        //su kien enter ma khach hang
        private void txtMaKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (busKH.kiemTraKhachHang(txtMaKhachHang.Text) == 0)
                    MessageBox.Show("Khách hàng đã bị xóa.");
                else if (busKH.kiemTraKhachHang(txtMaKhachHang.Text) == 1)
                {                  
                    txtMaDia.Enabled = true;
                    maKH = txtMaKhachHang.Text;
                    frmPhiTraTre ftt = new frmPhiTraTre();
                    ftt.ShowDialog();
                    txtPhiTraTre.Text = frmPhiTraTre.tongPhiTraTre.ToString();
                }
                else MessageBox.Show("Mã khách hàng không hợp lệ.");
            }
        }
        //su kien enter ma dia
        private void txtMaDia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (busDisk.kiemTraMaDia(txtMaDia.Text) == 3)
                {
                    loadToTextbox(txtMaDia.Text);
                    //load listview
                    ListViewItem item = new ListViewItem();
                    item.Text = txtMaDia.Text;
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtTieuDe.Text });
                    lvDiaThue.Items.Add(item);
                    //KH000000
                    //MD000001
                    txtMaDia.Clear();
                    btnThue.Enabled = true;
                    loadThanhTien();
                }
                else
                {
                    MessageBox.Show("Mã đĩa không hợp lệ.");
                    txtMaDia.Clear();
                }

            }
        }

        private void frmThueDia_Load(object sender, EventArgs e)
        {
            lvDiaThue.View = View.Details;
            lvDiaThue.MultiSelect = false;
            index = 0;
        }

        private void lvDiaThue_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvDiaThue.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDiaThue.SelectedItems[0];
                index = item.Index;
                btnXoaItem.Enabled = true;
                loadToTextbox(item.Text);
            }
        }

        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn bỏ chọn đĩa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                lvDiaThue.Items[index].Remove();
                btnXoaItem.Enabled = false;
            }
            else btnXoaItem.Enabled = false;
        }

        private void loadToTextbox(string maDia)
        {
            DTO_TieuDe td = new DTO_TieuDe();
            DateTime date = DateTime.Now;
            if (td.LoaiDia == "movie")
                date = date.AddDays(15);
            else
                date = date.AddDays(30);

            td = busTieuDe.getTieuDeTheoMa(busDisk.getMaTieuDeTheoDia(maDia));
            txtLoaiDia.Text = td.LoaiDia;
            txtGiaThue.Text = td.GiaThue.ToString() + " vnđ.";
            txtTieuDe.Text = td.TieuDe;
            txtSoNgay.Text = date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Thuê đĩa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                string maDonHang = busDonHang.taoDonHang(maKH);
                //MessageBox.Show(maDonHang);
                foreach (ListViewItem item in lvDiaThue.Items)
                {
                    busChiTiet.taoChiTietDonHang(maDonHang, item.Text, txtLoaiDia.Text);
                    busDisk.datTrangThaiChoDia(item.Text, 3);
                }
                MessageBox.Show("Thuê thành công, tổng tiền đơn hàng: " + txtTongThanhTien.Text);
                btnThue.Enabled = false;
                lvDiaThue.Clear();
            }
            else btnXoaItem.Enabled = false;

        }
        //load tong thanh tien
        private void loadThanhTien()
        {
            double tt = 0;
            foreach (ListViewItem item in lvDiaThue.Items)
            {
                tt += busTieuDe.getGiaThue(busDisk.getMaTieuDeTheoDia(item.Text));
            }
            txtTongThanhTien.Text = tt.ToString() + " vnd";
        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
