using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Data
{
   public class HuyKhoanNoDAL
    {
        dbQuanLyDiaDataContext db;

        public HuyKhoanNoDAL()
        {
            db = new dbQuanLyDiaDataContext();
        }

        public List<eHuyKhoanNo> getChiTietDonHangCuaKhachHang(string makh)
        {
            List<eHuyKhoanNo> ls = new List<eHuyKhoanNo>();

            var ds = from td in db.TieuDes
                     join disk in db.Disk_Games on td.MaTieuDe.Trim() equals disk.MaTieuDe.Trim()
                     join ctdh in db.ChiTietDonHangs on disk.MaDia.Trim() equals ctdh.MaDia.Trim()
                     join donhang in db.DonHangs on  ctdh.MaDonHang.Trim() equals donhang.MaDonHang.Trim()
                     where donhang.MaKhachHang.Trim() == makh.Trim()
                     select new eHuyKhoanNo
                     {
                         MaDia = disk.MaDia,
                        MaTieuDe = td.MaTieuDe,
                        TieuDe = td.TieuDe1,
                        GiaThue = (float)td.GiaThue,
                        SoNgayDuocThue = td.SoNgayDuocThue,
                        LoaiDia = td.LoaiDia,
                        MaDonHang = donhang.MaDonHang,
                        HanTraDia =ctdh.HanTraDia,
                         NgayTraDia = ctdh.NgayTraDia,
                         NgayThue = ctdh.NgayThue,
                         PhiTraTre = (float)ctdh.PhiTraTre,
                         ThanhToanPhiNo = ctdh.ThanhToanPhiNo,
                         MaKhachHang = donhang.MaKhachHang
                     };
            foreach (eHuyKhoanNo item in ds)
            {
                if (item.ThanhToanPhiNo==null)
                    item.DisplayThanhToanPhiNo =  "Chưa Thanh Toán";
                else if (!(bool)item.ThanhToanPhiNo)
                    item.DisplayThanhToanPhiNo = "Hủy khoản phí trễ";
                else
                    item.DisplayThanhToanPhiNo = "Đã Thanh Toán";
                ls.Add(item);
            }

            return ls;
        }

        public bool huyPhiTraTre(eHuyKhoanNo huyKhoanNo)
        {
            
            var temp = db.ChiTietDonHangs.Where(dh => dh.MaDonHang.Trim() == huyKhoanNo.MaDonHang.Trim() 
            && dh.MaDia.Trim()==huyKhoanNo.MaDia.Trim()).FirstOrDefault();

            temp.ThanhToanPhiNo = false;
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
