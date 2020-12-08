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
                    MessageBox.Show("Mã khách hàng hợp lệ.");
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
            //ListViewItem item = new ListViewItem();
            //item.Text = "MD000001";
            //item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Rom" });
            //lvDiaThue.Items.Add(item);
            //ListViewItem item2 = new ListViewItem();
            //item2.Text = "MD000002";
            //item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Tiec trang mau" });
            //lvDiaThue.Items.Add(item2);
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
            string maDonHang = "";
            DTO_ChiTietDonHang chitiet;
            busDonHang.taoDonHang(maKH);
            foreach (ListViewItem item in lvDiaThue.Items)
            {
                maDonHang = busDonHang.getMaDonHangTheoMaDia(item.Text);
                DTO_TieuDe td = busTieuDe.getTieuDeTheoMa(busDisk.getMaTieuDeTheoDia(item.Text));
                chitiet = new DTO_ChiTietDonHang(maDonHang, item.Text, 1, td.GiaThue, new DateTime(), new float(), new bool(), DateTime.Now.AddDays(td.SoNgayDuocThue));
                busChiTiet.taoChiTietDonHang(chitiet);
            }
            MessageBox.Show("Thuê thành công");
        }
    }
}
