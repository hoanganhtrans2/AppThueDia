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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public static string idDN = "";
        BUS_TaiKhoan bustk = new BUS_TaiKhoan();
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            //Image background = new Bitmap(@"D:\Quan ly thue dia\AppThueDia\dvdback.jpg");
            txtUserName.Text = "admin";
            txtPassword.Text = "admin";
            this.BackgroundImage = Properties.Resources.dvdback;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (bustk.dangNhap(txtUserName.Text, txtPassword.Text) == true)
            {
                idDN = txtUserName.Text;
                frmChucNang f = new frmChucNang();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mặt khẩu không đúng.");
            }

        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}