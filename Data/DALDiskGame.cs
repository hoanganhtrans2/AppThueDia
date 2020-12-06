using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
   public class DALDiskGame
    {
        dbQuanLyDiaDataContext db;

        public DALDiskGame()
        {
            db = new dbQuanLyDiaDataContext();
        }
        public bool themDia(int soLuongDia, string maTieuDe)
        {
            for(int i=0;i<soLuongDia;i++)
            {
                Disk_Game diskGame = new Disk_Game();
                diskGame.MaTieuDe = maTieuDe;
                db.Disk_Games.InsertOnSubmit(diskGame);
            }
            try { 
                db.SubmitChanges(); 
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi thêm được " + e.Message);
            }
            return true;
        }

        public List<eTieuDeGameDVD> getAllDiskGameDVD()
        {
            List<eTieuDeGameDVD> ls = new List<eTieuDeGameDVD>();

            var ds = from td in db.TieuDes
                     join disk in db.Disk_Games on td.MaTieuDe.Trim() equals disk.MaTieuDe.Trim()
                     where disk.Deleted == false
                     select new eTieuDeGameDVD
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
            var group = from td in ds group td by td.MaTieuDe;

            foreach(var td in group)
            {
                
                foreach (eTieuDeGameDVD obj in td)
                {
                    ls.Add(obj);
                }
            }
            
            return ls;
        }

        public bool deleteDia(string id)
        {
            var temp = db.Disk_Games.Where(disk => disk.MaDia.Trim() == id).FirstOrDefault();        
            temp.Deleted = true;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi không xoa được " + e.Message);
            }
            return true;
        }

    }
}
