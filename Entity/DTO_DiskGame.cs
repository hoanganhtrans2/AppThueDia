using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DTO_DiskGame
    {
        private string maDia;
        private string trangThai;
        private string maTieuDe;

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

        public string TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
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

        public DTO_DiskGame(string maDia, string trangThai, string maTieuDe)
        {
            this.MaDia = maDia;
            this.TrangThai = trangThai;
            this.MaTieuDe = maTieuDe;
        }
    }
}
