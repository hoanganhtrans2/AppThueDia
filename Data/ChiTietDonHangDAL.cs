using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
   public class ChiTietDonHangDAL
    {
        dbQuanLyDiaDataContext db;

        public ChiTietDonHangDAL()
        {
            db = new dbQuanLyDiaDataContext();
        }
        public List<eATieuDeGameDVD> getChiTietDonHang(string madh)
        {
            List<eATieuDeGameDVD> ls = new List<eATieuDeGameDVD>();

            var ds = from td in db.TieuDes
                     join disk in db.Disk_Games on td.MaTieuDe.Trim() equals disk.MaTieuDe.Trim()
                     join ctdh in db.ChiTietDonHangs on disk.MaDia.Trim() equals ctdh.MaDia.Trim()
                     where ctdh.MaDonHang.Trim() == madh
                     select new eATieuDeGameDVD
                     {
                         MaDia = disk.MaDia,
                         TrangThai = disk.TrangThai,
                         DeletedDiskDVDGame = (bool)disk.Deleted,
                         MaTieuDe = td.MaTieuDe,
                         TieuDe = td.TieuDe1,
                         SoLuongDia = td.SoLuongDia,
                         GiaThue = (float)td.GiaThue,
                         SoNgayDuocThue = td.SoNgayDuocThue,
                         LoaiDia = td.LoaiDia,
                         Deleted = td.Deleted
                     };
            foreach(eATieuDeGameDVD item in ds)
            {
                ls.Add(item);
            }    

            return ls;
        }
    }
}
