using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Data
{
    public class DAL_DatTruoc
    {
        dbQuanLyDiaDataContext db = new dbQuanLyDiaDataContext();
        //kiem tra tieu de co dat truoc nao khong
        public bool kiemTraDatTruocTieuDe(string matieude)
        {
            KH_DatTruoc_TieuDe dt = db.KH_DatTruoc_TieuDes.Where(x => x.MaTieuDe == matieude && x.MaDia == null).FirstOrDefault();
            if (dt != null)
                return true;
            return false;
        }
        //gan ma dia cho dat truoc
        public bool ganMaDia(string madia, string matieude)
        {
            KH_DatTruoc_TieuDe dt = db.KH_DatTruoc_TieuDes.Where(x => x.MaTieuDe == matieude && x.MaDia == null).FirstOrDefault();
            dt.MaDia = madia;
            db.SubmitChanges();
            return true;
        }
        //get id dat truoc
        public int getMaDatTruoc(string maDia)
        {
            KH_DatTruoc_TieuDe dt = db.KH_DatTruoc_TieuDes.Where(x => x.MaDia == maDia).FirstOrDefault();
            return dt.ID;

        }
    }
}
