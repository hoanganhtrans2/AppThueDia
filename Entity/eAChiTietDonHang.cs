using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class eAChiTietDonHang
    {
        private int soLuongDiaThue;
        private float phiThue;

        public int SoLuongDiaThue { get => soLuongDiaThue; set => soLuongDiaThue = value; }
        public float PhiThue { get => phiThue; set => phiThue = value; }

        private string maDonHang;
        private DateTime hanTraDia;
        private DateTime ngayTraDia;
        private DateTime ngayThue;
        private float phiTraTre;
        private string thanhToanPhiNo;
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
        public string ThanhToanPhiNo { get => thanhToanPhiNo; set => thanhToanPhiNo = value; }
        [DisplayName("Hủy Phí Trả Trể")]
        public bool HuyPhiTre { get => huyPhiTre; set => huyPhiTre = value; }

    }
}
