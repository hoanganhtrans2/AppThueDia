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

namespace AppThueDia
{
    public partial class frmTraDia : Form
    {
        BUS_Disk busDisk = new BUS_Disk();
        BUS_TieuDe busTieuDe = new BUS_TieuDe();
        BUS_ChiTietHoaDon buschitiet = new BUS_ChiTietHoaDon();
        BUS_DatTruoc busdt = new BUS_DatTruoc();
        public frmTraDia()
        {
            InitializeComponent();
        }

        private void btnTraDia_Click(object sender, EventArgs e)
        {
            if (busDisk.kiemTraMaDia(txtMaDia.Text) == 1)
            {
                buschitiet.capNhatTraDia(txtMaDia.Text, dtNgayTra.Value);
                if (busdt.kiemTraDatTruocTieuDe(busDisk.getMaTieuDeTheoDia(txtMaDia.Text)) == true)
                {
                    busdt.ganMaDia(txtMaDia.Text, busDisk.getMaTieuDeTheoDia(txtMaDia.Text));
                    busDisk.datTrangThaiChoDia(txtMaDia.Text, 1);
                    MessageBox.Show("Đã gán đĩa cho đặt trước cho đặt trước có mã: " + busdt.getMaDatTruoc(txtMaDia.Text).ToString());
                }
                else
                {
                    busDisk.datTrangThaiChoDia(txtMaDia.Text, 2);
                    MessageBox.Show("Trả đĩa thành công");
                    txtMaDia.Clear();
                }
            }
            else
                MessageBox.Show("Mã đĩa không hợp lệ ");



        }
    }
}
