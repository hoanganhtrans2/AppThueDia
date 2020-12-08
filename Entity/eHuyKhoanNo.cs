using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
   public class eHuyKhoanNo
    {

        private string maDonHang;
        private DateTime? hanTraDia;
        private DateTime? ngayTraDia;
        private DateTime? ngayThue;
        private float? phiTraTre;
        private bool? thanhToanPhiNo;
        private string displayThanhToanPhiNo;
        private string maTieuDe;
        private string tieuDe;      
        private float giatHue;
        private int soNgayDuocThue;
        private string loaiDia;
        private string maDia;
        private string maKhachHang;


        [DisplayName("Mã Tiêu Đề")]
        public string MaTieuDe { get => maTieuDe; set => maTieuDe = value; }
        [DisplayName("Tiêu Đề")]
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        
        [DisplayName("Giá cho thuê")]      
        public float GiaThue { get => giatHue; set => giatHue = value; }

        [DisplayName("Số Ngày Được Thuê")]
        public int SoNgayDuocThue { get => soNgayDuocThue; set => soNgayDuocThue = value; }
       
        [DisplayName("Loại Đĩa")]
        public string LoaiDia { get => loaiDia; set => loaiDia = value; }
        public string MaDonHang { get => maDonHang; set => maDonHang = value; }
              
        [DisplayName("Ngày Thuê Đĩa")]
        public DateTime? NgayThue { get => ngayThue; set => ngayThue = value; }

        [DisplayName("Hạn trả đĩa")]
        public DateTime? HanTraDia { get => hanTraDia; set => hanTraDia = value; }

        [DisplayName("Ngày Trả Đĩa")]
        public DateTime? NgayTraDia { get => ngayTraDia; set => ngayTraDia = value; }

        [DisplayName("Phí Trả Trể")]
        public float? PhiTraTre { get => phiTraTre; set => phiTraTre = value; }
        [DisplayName("Thanh Toán Phí Nợ")]
        public bool? ThanhToanPhiNo { get => thanhToanPhiNo; set => thanhToanPhiNo = value; }

        [DisplayName("Thông tin thanh toán nợ")]
        public string DisplayThanhToanPhiNo { get => displayThanhToanPhiNo; set => displayThanhToanPhiNo = value; }
        public string MaDia { get => maDia; set => maDia = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
    }
}
