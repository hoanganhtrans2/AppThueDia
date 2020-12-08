using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DTO_ChiTietDonHang
    {
        private string maDonHang;
        private string maDia;
        private int soLuongDiaThue;
        private float phiThue;
        private DateTime ngayTraDia;
        private float phiTraTre;
        private bool thanhToanPhiNo;
        private DateTime hanTraDia;
        private double phiThue1;
        private DateTime? ngayTraDia1;
        private double? phiTraTre1;
        private bool? thanhToanPhiNo1;
        private DateTime? hanTraDia1;

        public DTO_ChiTietDonHang(string maDonHang, string maDia, float phiThue, DateTime ngayTraDia, float phiTraTre, bool thanhToanPhiNo, DateTime hanTraDia)
        {
            this.maDonHang = maDonHang;
            this.maDia = maDia;
            this.phiThue = phiThue;
            this.ngayTraDia = ngayTraDia;
            this.phiTraTre = phiTraTre;
            this.thanhToanPhiNo = thanhToanPhiNo;
            this.hanTraDia = hanTraDia;
        }

        public DTO_ChiTietDonHang(string maDonHang, string maDia, int soLuongDiaThue, double phiThue1, DateTime? ngayTraDia1, double? phiTraTre1, bool? thanhToanPhiNo1, DateTime? hanTraDia1)
        {
            this.maDonHang = maDonHang;
            this.maDia = maDia;
            this.soLuongDiaThue = soLuongDiaThue;
            this.phiThue1 = phiThue1;
            this.ngayTraDia1 = ngayTraDia1;
            this.phiTraTre1 = phiTraTre1;
            this.thanhToanPhiNo1 = thanhToanPhiNo1;
            this.hanTraDia1 = hanTraDia1;
        }

        public string MaDonHang
        {
            get
            {
                return maDonHang;
            }

            set
            {
                maDonHang = value;
            }
        }

        public string MaDia
        {
            get
            {
                return maDia;
            }

            set
            {
                maDia = value;
            }
        }

        public int SoLuongDiaThue
        {
            get
            {
                return soLuongDiaThue;
            }

            set
            {
                soLuongDiaThue = value;
            }
        }

        public float PhiThue
        {
            get
            {
                return phiThue;
            }

            set
            {
                phiThue = value;
            }
        }
        public DateTime NgayTraDia
        {
            get
            {
                return ngayTraDia;
            }

            set
            {
                ngayTraDia = value;
            }
        }
        public float PhiTraTre
        {
            get
            {
                return phiTraTre;
            }

            set
            {
                phiTraTre = value;
            }
        }
        public bool ThanhToanPhiNo
        {
            get
            {
                return thanhToanPhiNo;
            }

            set
            {
                thanhToanPhiNo = value;
            }
        }
        public DateTime HanTraDia
        {
            get
            {
                return hanTraDia;
            }

            set
            {
                hanTraDia = value;
            }
        }


    }
}
