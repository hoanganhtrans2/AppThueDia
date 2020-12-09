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
using System.Globalization;

namespace AppThueDia
{
    public partial class frmPhiTraTre : DevExpress.XtraEditors.XtraForm
    {
        BUS_KhachHang buskh = new BUS_KhachHang();
        BUS_ChiTietHoaDon buschitiet = new BUS_ChiTietHoaDon();
        public static double tongPhiTraTre;
        BindingSource bd;
        public frmPhiTraTre()
        {
            InitializeComponent();
        }

        private void frmPhiTraTre_Load(object sender, EventArgs e)
        {
            grbPhiTraTre.Text = "Thông tin phí trả trễ của khách hàng: " + buskh.getNameKhachHang(frmThueDia.maKH);
            bd = new BindingSource();

            List<DTO_ChiTietDonHang> lct = buschitiet.getDanhSachChiTietDH(frmThueDia.maKH);
            bd.DataSource = lct;
            lvPhiTraTre.DataSource = lct;

        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            tongPhiTraTre = 0;

            this.Hide();

        }
        public List<DTO_ChiTietDonHang> temp = new List<DTO_ChiTietDonHang>();
        private void lvPhiTraTre_Click(object sender, EventArgs e)
        {
           
        }

        private void lvPhiTraTre_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            DTO_ChiTietDonHang ct = new DTO_ChiTietDonHang();
            ct = (DTO_ChiTietDonHang)bd.Current;
            DTO_ChiTietDonHang test = ct;
            if (temp.Count > 0 && ct.Check == true)
            {
                ct.Check = false;
                temp.Remove(ct);

            }

            ct.Check = true;
            temp.Add(ct);
        }
    }
}