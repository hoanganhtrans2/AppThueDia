using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DTO_ChiTietDonHang
    {
        private string maDonHang;
        private string maDia;
        private float phiThue;
        private DateTime? ngayTraDia;
        private float? phiTraTre;
        private bool? thanhToanPhiNo;
        private DateTime? hanTraDia;
        private bool check;
        public DTO_ChiTietDonHang() { }

        public DTO_ChiTietDonHang(string maDonHang, string maDia, float phiThue, DateTime? ngayTraDia, float? phiTraTre, bool? thanhToanPhiNo, DateTime? hanTraDia)
        {
            this.maDonHang = maDonHang;
            this.maDia = maDia;
            this.phiThue = phiThue;
            this.ngayTraDia = ngayTraDia;
            this.phiTraTre = phiTraTre;
            this.thanhToanPhiNo = thanhToanPhiNo;
            this.hanTraDia = hanTraDia;
        }
        [DisplayName("Chọn thanh toán")]
        public bool Check { get => check; set => check = value; }
        [DisplayName("Mã Đơn Hàng")]
        public string MaDonHang { get => maDonHang; set => maDonHang = value; }
        [DisplayName("Mã Đĩa")]
        public string MaDia { get => maDia; set => maDia = value; }
        [DisplayName("Phí Thuê")]
        public float PhiThue { get => phiThue; set => phiThue = value; }
        [DisplayName("Ngày Trả Đĩa")]
        public DateTime? NgayTraDia { get => ngayTraDia; set => ngayTraDia = value; }
        [DisplayName("Phí Trả Trễ")]
        public float? PhiTraTre { get => phiTraTre; set => phiTraTre = value; }
        [DisplayName("Trạng thái thanh toán")]
        public bool? ThanhToanPhiNo { get => thanhToanPhiNo; set => thanhToanPhiNo = value; }
        [DisplayName("Hạn Trả Đĩa")]
        public DateTime? HanTraDia { get => hanTraDia; set => hanTraDia = value; }
        
    }
}
