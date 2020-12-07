using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
   public class TieuDeDAL
    {
        dbQuanLyDiaDataContext db;
       
        public TieuDeDAL()
        {
            db = new dbQuanLyDiaDataContext();
        }
        public bool themTieuDe(eTieuDe tieuDe)
        {
            TieuDe td = new TieuDe();
            td.TieuDe1 = tieuDe.TieuDe;
            td.SoLuongDia = 0;
            td.GiaThue = tieuDe.GiaThue;
            td.SoNgayDuocThue = tieuDe.SoNgayDuocThue;
            td.LoaiDia = tieuDe.LoaiDia;
            td.Deleted = false;
            db.TieuDes.InsertOnSubmit(td);
            db.SubmitChanges();
            return true;
        }

        public List<eTieuDe> getAllTieuDe()
        {
            List<eTieuDe> ls = new List<eTieuDe>();
            IEnumerable<TieuDe> tieude = db.TieuDes.Where(kh => kh.Deleted == false);
            foreach (TieuDe td in tieude)
            {
                eTieuDe eTD = new eTieuDe();
                eTD.MaTieuDe = td.MaTieuDe;
                eTD.TieuDe = td.TieuDe1;
                eTD.SoLuongDia = td.SoLuongDia;
                eTD.GiaThue = (float)td.GiaThue;
                eTD.SoNgayDuocThue = td.SoNgayDuocThue;
                eTD.LoaiDia = td.LoaiDia;
                eTD.Deleted = td.Deleted;
                ls.Add(eTD);
            }
            return ls;
        }
        public bool deleteTieuDe(string id)
        {
            TieuDe khachHang = new TieuDe();
            var temp = db.TieuDes.Where(kh => kh.MaTieuDe.Trim() == id).FirstOrDefault();
            khachHang = (TieuDe)temp;
            khachHang.Deleted = true;
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

        public eTieuDe getTieuDeTheoLoai(string loai)
        {
            
           var tieude = db.TieuDes.Where(td => td.Deleted == false && td.LoaiDia==loai).FirstOrDefault();
            if (tieude != null)
            {
                eTieuDe eTd = new eTieuDe();
                eTd.GiaThue =(float)tieude.GiaThue;
                eTd.LoaiDia = tieude.LoaiDia;
                eTd.MaTieuDe = tieude.MaTieuDe;
                eTd.SoLuongDia = tieude.SoLuongDia;
                eTd.SoNgayDuocThue = tieude.SoNgayDuocThue;
                eTd.TieuDe = tieude.TieuDe1;
                return eTd;

            }
            return null;
        }
    }
}
