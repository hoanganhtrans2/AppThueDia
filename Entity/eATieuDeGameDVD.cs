using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class eATieuDeGameDVD
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
        private bool deletedDiskDVDGame;

        [DisplayName("Mã Đĩa")]
        public string MaDia { get => maDia; set => maDia = value; }
        [DisplayName("Mã Tiêu Đề")]
        public string MaTieuDe { get => maTieuDe; set => maTieuDe = value; }

        [DisplayName("Tiêu Đề")]
        public string TieuDe { get => tieuDe; set => tieuDe = value; }

        [DisplayName("Trạng Thái Đĩa")]
        public string TrangThai { get => trangThai; set => trangThai = value; }
         
        [DisplayName("Số Lượng Đĩa")]
        public int SoLuongDia { get => soLuongDia; set => soLuongDia = value; }
        [DisplayName("Giá Cho Thuê")]
        public float GiaThue { get => giatHue; set => giatHue = value; }


        [DisplayName("Số Ngày Được Thuê")]
        public int SoNgayDuocThue { get => soNgayDuocThue; set => soNgayDuocThue = value; }
        [DisplayName("Loại Đĩa")]
        public string LoaiDia { get => loaiDia; set => loaiDia = value; }

        [DisplayName("Xóa Đĩa")]
        public bool DeletedDiskDVDGame { get => deletedDiskDVDGame; set => deletedDiskDVDGame = value; }

        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
