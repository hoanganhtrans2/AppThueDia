using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
   public class BaoCaoTieuDeDAL
    {
        dbQuanLyDiaDataContext db;
        public BaoCaoTieuDeDAL()
        {
            db = new dbQuanLyDiaDataContext();
        }

        public List<eABaoCaoTieuDe> getBaoCao()
        {
            List<eABaoCaoTieuDe> ls = new List<eABaoCaoTieuDe>();

            var ds = from td in db.TieuDes
                     join disk in db.Disk_Games on td.MaTieuDe.Trim() equals disk.MaTieuDe.Trim()
                     select new eABaoCaoTieuDe
                     {
                         MaDia = disk.MaDia,
                         TrangThai = disk.TrangThai,
                         MaTieuDe = td.MaTieuDe,
                         TieuDe = td.TieuDe1,
                         SoLuongDia = td.SoLuongDia,
                         GiaThue = (float)td.GiaThue,
                         SoNgayDuocThue = td.SoNgayDuocThue,
                         LoaiDia = td.LoaiDia,
                         Deleted = (bool)disk.Deleted
                     };
            var group = from td in ds group td by td.MaTieuDe;

            foreach (var td in group)
            {
                int onhold = 0, onshelf = 0, rented=0, deleted =0, count=0;
                eABaoCaoTieuDe temp = new eABaoCaoTieuDe();
                foreach (eABaoCaoTieuDe obj in td)
                {
                    if (obj.Deleted)
                    {
                        deleted++;
                    }
                    else if(obj.TrangThai=="onhold")
                    {
                        onhold++;
                    } else if (obj.TrangThai == "onshelf")
                    {
                        onshelf++;
                    }
                    else
                    {
                        rented++;
                    }
                    temp = obj;
                    count++;
                }
                temp.SoLuongDia = count;

                temp.TotalOnhold = onhold;
                temp.TotalOnshelf = onshelf;
                temp.TotalRented = rented;
                temp.TotalDeleted = deleted; 
                ls.Add(temp);
            }

            return ls;
        }
    }
}
