using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DTO_KH_DatTruoc_TieuDe
    {
        private string id;
        private DateTime ngayDatHang;
        private string maKhachHang;
        private string maTieuDe;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public DateTime NgayDatHang
        {
            get
            {
                return ngayDatHang;
            }

            set
            {
                ngayDatHang = value;
            }
        }

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

        public string MaTieuDe
        {
            get
            {
                return maTieuDe;
            }

            set
            {
                maTieuDe = value;
            }
        }

        public DTO_KH_DatTruoc_TieuDe(string id, DateTime ngayDatHang, string maKhachHang, string maTieuDe)
        {
            this.Id = id;
            this.NgayDatHang = ngayDatHang;
            this.MaKhachHang = maKhachHang;
            this.MaTieuDe = maTieuDe;
        }
    }
}
