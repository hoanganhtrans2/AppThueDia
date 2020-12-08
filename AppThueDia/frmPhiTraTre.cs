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
using BUS;
using Entity;

namespace AppThueDia
{
    public partial class frmPhiTraTre : DevExpress.XtraEditors.XtraForm
    {
        BUS_KhachHang buskh = new BUS_KhachHang();
        BUS_ChiTietHoaDon buschitiet = new BUS_ChiTietHoaDon();
        public static double tongPhiTraTre;
        public frmPhiTraTre()
        {
            InitializeComponent();
        }

        private void frmPhiTraTre_Load(object sender, EventArgs e)
        {
            grbPhiTraTre.Text = "Thông tin phí trả trễ của khách hàng: " + buskh.getNameKhachHang(frmThueDia.maKH);
            ListViewItem item = new ListViewItem();
            lvPhiTraTre.View = View.Details;
            item.Text = "abc";
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "abc" });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "abc" });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "abc" });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "abc" });
            lvPhiTraTre.Items.Add(item);
            //List<DTO_ChiTietDonHang> lct = buschitiet.getDanhSachChiTietDH(frmThueDia.maKH);
            //foreach (DTO_ChiTietDonHang ct in lct)
            //{
            //    item.Text = ct.MaDonHang;
            //    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ct.MaDia });
            //    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ct.HanTraDia.ToString() });
            //    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ct.NgayTraDia.ToString() });
            //    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ct.PhiTraTre.ToString() });
            //    lvPhiTraTre.Items.Add(item);
            //}
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            tongPhiTraTre = 0;
            foreach (ListViewItem item in lvPhiTraTre.Items)
            {
                if (item.Selected == true)
                    tongPhiTraTre += buschitiet.getPhiThue(item.Text, item.SubItems[1].Text);
            }

            this.Hide();

        }
    }
}