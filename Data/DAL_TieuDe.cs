using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
    public class DAL_TieuDe
    {
        dbQuanLyDiaDataContext db = new dbQuanLyDiaDataContext();
        public DTO_TieuDe getTieuDeTheoMa(string maTieuDe)
        {
            DTO_TieuDe tieude = new DTO_TieuDe();
            TieuDe td = db.TieuDes.Where(x => x.MaTieuDe == maTieuDe).FirstOrDefault();
            tieude.MaTieuDe = td.MaTieuDe;
            tieude.GiaThue = (float)td.GiaThue;
            tieude.LoaiDia = td.LoaiDia;
            tieude.SoLuongDia = td.SoLuongDia;
            tieude.SoNgayDuocThue = td.SoNgayDuocThue;
            tieude.TieuDe = td.TieuDe1;
            return tieude;

        }
    }
}
