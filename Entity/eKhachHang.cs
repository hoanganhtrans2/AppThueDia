using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
    public class eKhachHang
    {
        private string maKhachHang;
        private string diaChi;
        private string soDienThoai;
        private bool deleted;
        private string tenKhachHang;

        [DisplayName("Mã Khách Hàng")]
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }

        [DisplayName("Tên Khách Hàng")]
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }

        [DisplayName("Địa Chỉ")]
        public string DiaChi { get => diaChi; set => diaChi = value; }

        [DisplayName("Số Điện Thoại")]
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }

        public bool Deleted { get => deleted; set => deleted = value; }



    }
}
