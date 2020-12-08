using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlTypes;

namespace Data
{
    
    public class DAL_DonHang
    {
        dbQuanLyDiaDataContext db = new dbQuanLyDiaDataContext();
        //tao don hang khi thue dia

        
        public bool taoDonHang(string maKH)
        {
            DonHang dhang = new DonHang();
            dhang.MaKhachHang = maKH;
           
            dhang.NgayThue = DateTime.Now;
           
            try
            {
                db.DonHangs.InsertOnSubmit(dhang);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi không thêm được " + e.Message);
            }
            return true;
        }
        //
        public string getMaDonHangTheoMaDia(string madia)
        {
            var ldh = from dh in db.DonHangs
                         join ct in db.ChiTietDonHangs on dh.MaDonHang equals ct.MaDonHang
                         where ct.MaDia == madia
                         select ct.MaDonHang;
            return ldh.ToString();      
        }
    }
}
