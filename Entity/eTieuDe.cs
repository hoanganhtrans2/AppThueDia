using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class eTieuDe
    {
        private string maTieuDe;
        private string tieuDe;
        private int soLuongDia;
        private float giatHue;
       
        private int soNgayDuocThue;
        private string loaiDia;
        private bool deleted;

        [DisplayName("Mã Tiêu Đề")]
        public string MaTieuDe { get => maTieuDe; set => maTieuDe = value; }
        [DisplayName("Tiêu Đề")]
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        [DisplayName("Số Lượng Đĩa")]
        public int SoLuongDia { get => soLuongDia; set => soLuongDia = value; }
        [DisplayName("Giá Cho Thuê")]
        public float GiaThue { get => giatHue; set => giatHue = value; }
      
        
        [DisplayName("Số Ngày Được Thuê")]
        public int SoNgayDuocThue { get => soNgayDuocThue; set => soNgayDuocThue = value; }
        [DisplayName("Loại Đĩa")]
        public string LoaiDia { get => loaiDia; set => loaiDia = value; }

        [Display(Order=-1)]
        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
