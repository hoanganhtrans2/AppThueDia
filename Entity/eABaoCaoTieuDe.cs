using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class eABaoCaoTieuDe
    {
        private string maTieuDe;
        private string tieuDe;
        private int soLuongDia;
        private float giatHue;
        private int soNgayDuocThue;
        private string loaiDia;
        private bool deleted;
       
        private string maDia;
        private string trangThai;

        private int totalRented;
        private int totalOnshelf;
        private int totalOnhold;
        private int tongSoDacTruoc;
        private int totalDeleted;


        [DisplayName("Mã Đĩa")]
        public string MaDia { get => maDia; set => maDia = value; }
        [DisplayName("Mã Tiêu Đề")]
        public string MaTieuDe { get => maTieuDe; set => maTieuDe = value; }

        [DisplayName("Tiêu Đề")]
        public string TieuDe { get => tieuDe; set => tieuDe = value; }

        [DisplayName("Loại Đĩa")]
        public string LoaiDia { get => loaiDia; set => loaiDia = value; }

        [DisplayName("Trạng Thái Đĩa")]
        public string TrangThai { get => trangThai; set => trangThai = value; }

        
        [DisplayName("Giá Cho Thuê")]
        public float GiaThue { get => giatHue; set => giatHue = value; }


        [DisplayName("Số Ngày Được Thuê")]
        public int SoNgayDuocThue { get => soNgayDuocThue; set => soNgayDuocThue = value; }
       

        [DisplayName("Số Lượng Đĩa")]
        public int SoLuongDia { get => soLuongDia; set => soLuongDia = value; }

        [DisplayName("Số bản sao được thuê")]
       
        public int TotalRented { get => totalRented; set => totalRented = value; }

        [DisplayName("Số bản sao trên kệ")]
        public int TotalOnshelf { get => totalOnshelf; set => totalOnshelf = value; }

        [DisplayName("Số bản sao đặc trước")]
        public int TotalOnhold { get => totalOnhold; set => totalOnhold = value; }
        [DisplayName("Số bản sao đặc trước đang chờ sử lý")]
        public int TongSoDacTruoc { get => tongSoDacTruoc; set => tongSoDacTruoc = value; }

        [DisplayName("Tổng số đĩa hư hại")]
        public int TotalDeleted { get => totalDeleted; set => totalDeleted = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
