using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DAL_KhachHang
    {
        dbQuanLyDiaDataContext db = new dbQuanLyDiaDataContext();
        public int kiemTraKhachHang(string maKH)
        {
            IEnumerable<KhachHang> kh = db.KhachHangs;
            KhachHang k = db.KhachHangs.Where(x => x.MaKhachHang == maKH).FirstOrDefault();
            if (k != null)
                if (k.Deleted == true)
                    return 0; //khach hang da bi xoa 
                else return 1; //khach hang hop le
            else return -1; //khong tim thay khach hang
        }
        //lay ten khach hang bang ma khach hang
        public string getNameKhachHang(string makh)
        {
            KhachHang kh = db.KhachHangs.Where(x => x.MaKhachHang == makh).FirstOrDefault();
            return kh.TenKhachHang;
        }

    }
}
