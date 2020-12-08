using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DTO_TieuDe
    {
        private string maTieuDe;
        private string tieuDe;
        private int soLuongDia;
        private float giaThue;
        private int soNgayDuocThue;
        private string loaiDia;
        private bool deleted;

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

        public string TieuDe
        {
            get
            {
                return tieuDe;
            }

            set
            {
                tieuDe = value;
            }
        }

        public int SoLuongDia
        {
            get
            {
                return soLuongDia;
            }

            set
            {
                soLuongDia = value;
            }
        }

        public float GiaThue
        {
            get
            {
                return giaThue;
            }

            set
            {
                giaThue = value;
            }
        }

        public int SoNgayDuocThue
        {
            get
            {
                return soNgayDuocThue;
            }

            set
            {
                soNgayDuocThue = value;
            }
        }

        public string LoaiDia
        {
            get
            {
                return loaiDia;
            }

            set
            {
                loaiDia = value;
            }
        }

        public bool Deleted
        {
            get
            {
                return deleted;
            }

            set
            {
                deleted = value;
            }
        }

        public DTO_TieuDe(string maTieuDe, string tieuDe, int soLuongDia, float giaThue, int soNgayDuocThue, string loaiDia, bool deleted)
        {
            this.MaTieuDe = maTieuDe;
            this.TieuDe = tieuDe;
            this.SoLuongDia = soLuongDia;
            this.GiaThue = giaThue;
            this.SoNgayDuocThue = soNgayDuocThue;
            this.LoaiDia = loaiDia;
            this.Deleted = deleted;
        }
        public DTO_TieuDe()
        {

        }
    }
}
