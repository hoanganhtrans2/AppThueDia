using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DAL_TaiKhoan
    {
        dbQuanLyDiaDataContext db = new dbQuanLyDiaDataContext();
        public bool dangNhap(string taikhoan, string matkhau)
        {
            TaiKhoan tk = db.TaiKhoans.Where(x => x.TaiKhoan1.Trim() == taikhoan).FirstOrDefault();
            if (tk != null)
                if (tk.MatKhau.Trim() == matkhau)
                    return true;
            return false;
        }
    }
}
