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

        public List<eADonHang> getDonHangCuaKhachHang(string maKh)
        {
            List<eADonHang> ls = new List<eADonHang>();
            var dsdh = from dhang in db.DonHangs
                       join ctdh in db.ChiTietDonHangs on dhang.MaDonHang equals ctdh.MaDonHang
                       where dhang.MaDonHang.Trim() == maKh.Trim()
                       select new eADonHang
                       {
                           MaDonHang = dhang.MaDonHang,
                           HanTraDia = (DateTime)ctdh.HanTraDia,
                           NgayTraDia = (DateTime)ctdh.NgayTraDia,
                           NgayThue = (DateTime)dhang.NgayThue,
                           PhiTraTre = (float)ctdh.PhiTraTre,
                           ThanhToanPhiNo = ctdh.ThanhToanPhiNo,
                       };
                //db.DonHangs.Where(dhang => dhang.MaKhachHang.Trim()==maKh.Trim());
            foreach (eADonHang dh in dsdh)
            {
                eADonHang donHang = new eADonHang();
                donHang.MaDonHang = dh.MaDonHang;
                donHang.HanTraDia = dh.HanTraDia;
                donHang.NgayTraDia =(DateTime)dh.NgayTraDia;
                donHang.NgayThue = (DateTime)dh.NgayThue;
                donHang.PhiTraTre =(float)dh.PhiTraTre;
                donHang.ThanhToanPhiNo = dh.ThanhToanPhiNo;
                //donHang.HuyPhiTre = donHang.ThanhToanPhiNo == "Hủy khoản nợ" ? true : false;
                ls.Add(donHang);
            }
            return ls;
        }

        public bool huyPhiTraTre(string madh, string madia)
        {
            ChiTietDonHang donHang = new ChiTietDonHang();
            var temp = db.ChiTietDonHangs.Where(dh => dh.MaDonHang.Trim()==madh.Trim() && dh.MaDia.Trim()==madia.Trim()).FirstOrDefault();
            donHang = (ChiTietDonHang)temp;
            donHang.ThanhToanPhiNo = false;
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
