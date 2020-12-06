using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
  public  class DonHangDAL
    {
        dbQuanLyDiaDataContext db;
        public DonHangDAL()
        {
            db = new dbQuanLyDiaDataContext();
        }

        public List<eDonHang> getDonHangCuaKhachHang(string maKh)
        {
            List<eDonHang> ls = new List<eDonHang>();
            IEnumerable<DonHang> dsdh = db.DonHangs.Where(dhang => dhang.MaKhachHang.Trim()==maKh.Trim());
            foreach (DonHang dh in dsdh)
            {
                eDonHang donHang = new eDonHang();
                donHang.MaDonHang = dh.MaDonHang;
                donHang.HanTraDia = dh.HanTraDia;
                donHang.NgayTraDia = dh.NgayTraDia;
                donHang.NgayThue = dh.NgayThue;
                donHang.PhiTraTre =(float)dh.PhiTraTre;
                donHang.ThanhToanPhiNo = dh.ThanhToanPhiNo;
                donHang.HuyPhiTre = donHang.ThanhToanPhiNo == "Hủy khoản nợ" ? true : false;
                ls.Add(donHang);
            }
            return ls;
        }

        public bool huyPhiTraTre(string madh)
        {
            DonHang donHang = new DonHang();
            var temp = db.DonHangs.Where(dh => dh.MaDonHang.Trim()==madh.Trim()).FirstOrDefault();
            donHang = (DonHang)temp;
            donHang.ThanhToanPhiNo = "Hủy khoản nợ";
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
