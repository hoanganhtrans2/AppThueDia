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
        public string taoDonHang(string maKH)
        {
            DonHang dh = new DonHang();
            dh.MaKhachHang = maKH;
            dh.NgayThue = DateTime.Now;
            db.DonHangs.InsertOnSubmit(dh);
            //db.SubmitChanges();
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi không thêm được " + e.Message);
            }
            var c = from d in db.DonHangs select d.MaDonHang;
            int i = 0;
            foreach (var item in c)
            {
                i++;
            }
            if (i < 10)
                return "HD00000" + i.ToString();
            else if (i >= 10 && i < 100)
                return "HD0000" + i.ToString();
            else if (i >= 100)
                return "HD000" + i.ToString();
            return "";
        }
    }
}
