using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DTO_KhachHang
    {
        private string maKhachHang;
        private string diaChi;
        private string soDienThoai;
        private bool deleted;
        private string tenKhachHang;

        public string MaKhachHang
        {
            get
            {
                return maKhachHang;
            }

            set
            {
                maKhachHang = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public bool Deleted
        {
            get
            {
                return deleted;
            }

            set
            {
                deleted = value;
            }
        }

        public string TenKhachHang
        {
            get
            {
                return tenKhachHang;
            }

            set
            {
                tenKhachHang = value;
            }
        }

        public DTO_KhachHang(string maKhachHang, string diaChi, string soDienThoai, bool deleted, string tenKhachHang)
        {
            this.MaKhachHang = maKhachHang;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
            this.Deleted = deleted;
            this.TenKhachHang = tenKhachHang;
        }
    }
}
