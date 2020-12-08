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
    public partial class frmCapNhatThongTinThue : Form
    {
        public frmCapNhatThongTinThue()
        {
            InitializeComponent();
        }
        TieuDeBUS tieuDeBUS;
        eATieuDe tdMOVIE;
        eATieuDe tdGAME;
        private void frmCapNhatThongTinThue_Load(object sender, EventArgs e)
        {
            tieuDeBUS = new TieuDeBUS();
            tdMOVIE = new eATieuDe();
            tdGAME = new eATieuDe();
            List<string> loaiDia = new List<string>() { "GAME", "MOVIE" };
            cboLoaiDiaThue.DataSource = loaiDia;
            LoadData();
        }

        public void LoadData()
        {
            
            tdMOVIE = tieuDeBUS.getTieuDeTheoLoai("MOVIE");
            tdGAME = tieuDeBUS.getTieuDeTheoLoai("GAME");
            if (tdMOVIE != null && tdGAME != null)
            {
                txtGiaThue.Text = tdGAME.GiaThue.ToString();
                mudSoNgayDuocThue.Value = tdGAME.SoNgayDuocThue;
                lblGiaChoThueMOVIE.Text = tdMOVIE.GiaThue.ToString();
                lblGiaChoThueGAME.Text = tdGAME.GiaThue.ToString();
                lblSoNgayChoThueGAME.Text = tdGAME.SoNgayDuocThue.ToString();
                lblSoNgayChoThueMOVIE.Text = tdMOVIE.SoNgayDuocThue.ToString();
            }
        }

        private void cboLoaiDiaThue_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eATieuDe temp = new eATieuDe();
            switch (cboLoaiDiaThue.SelectedIndex)
            {

                case 0:
                    temp = tieuDeBUS.getTieuDeTheoLoai("GAME");
                    txtGiaThue.Text = temp.GiaThue.ToString();
                    mudSoNgayDuocThue.Value = tdGAME.SoNgayDuocThue;
                    break;
                default:
                    temp = tieuDeBUS.getTieuDeTheoLoai("MOVIE");
                    txtGiaThue.Text = temp.GiaThue.ToString();
                    mudSoNgayDuocThue.Value = tdGAME.SoNgayDuocThue;
                    break;

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string loaiDia = cboLoaiDiaThue.Text;
                float giaThue = float.Parse(txtGiaThue.Text);
                int ngayThue =(int)mudSoNgayDuocThue.Value;
                if (tieuDeBUS.capNhatThongTinChoThue(loaiDia, giaThue, ngayThue))
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadData();
                    eATieuDe temp = tieuDeBUS.getTieuDeTheoLoai("GAME");
                    txtGiaThue.Text = temp.GiaThue.ToString();
                    mudSoNgayDuocThue.Value = tdGAME.SoNgayDuocThue;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai định dạng");
                txtGiaThue.Clear();
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            eATieuDe temp = tieuDeBUS.getTieuDeTheoLoai("GAME");
            txtGiaThue.Text = temp.GiaThue.ToString();
            mudSoNgayDuocThue.Value = tdGAME.SoNgayDuocThue;
        }

        private void frmCapNhatThongTinThue_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
