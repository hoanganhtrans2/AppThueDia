using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Entity
{
  public  class eADonHang
    {
        private string maDonHang;
        private DateTime hanTraDia;
        private DateTime ngayTraDia;
        private DateTime ngayThue;
        private float phiTraTre;
        private bool? thanhToanPhiNo;
        private bool huyPhiTre;


        public string MaDonHang { get => maDonHang; set => maDonHang = value; }
        [DisplayName("Hạng trả đĩa")]
        public DateTime HanTraDia { get => hanTraDia; set => hanTraDia = value; }
        [DisplayName("Ngày Trả Đĩa")]
        public DateTime NgayTraDia { get => ngayTraDia; set => ngayTraDia = value; }
        [DisplayName("Ngày Thuê Đĩa")]
        public DateTime NgayThue { get => ngayThue; set => ngayThue = value; }
        [DisplayName("Phí Trả Trể")]
        public float PhiTraTre { get => phiTraTre; set => phiTraTre = value; }
        [DisplayName("Thanh Toán Phí Nợ")]
        public bool? ThanhToanPhiNo { get => thanhToanPhiNo; set => thanhToanPhiNo = value; }
        [DisplayName("Hủy Phí Trả Trể")]
        public bool HuyPhiTre { get => huyPhiTre; set => huyPhiTre = value; }
    }
}
