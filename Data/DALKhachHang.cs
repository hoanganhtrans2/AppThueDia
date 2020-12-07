using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
    public class DALKhachHang
    {
        dbQuanLyDiaDataContext db = new dbQuanLyDiaDataContext();

        public List<eKhachHang> getAllKhachHang()
        {
            List<eKhachHang> ls = new List<eKhachHang>();
            IEnumerable<KhachHang> khachHangs = from kh in db.KhachHangs
                                                orderby kh.TenKhachHang
                                                where kh.Deleted == false
                                                select kh;

            foreach (KhachHang kh in khachHangs)
            {
                eKhachHang eKhach = new eKhachHang();
                eKhach.MaKhachHang = kh.MaKhachHang;
                eKhach.TenKhachHang = kh.TenKhachHang;
                eKhach.SoDienThoai = kh.SoDienThoai;
                eKhach.Deleted = kh.Deleted;
                eKhach.DiaChi = kh.DiaChi;
                ls.Add(eKhach);
            }
            return ls;
        }

        public eKhachHang getKhachHangById(string makh)
        {
            eKhachHang khachHang = new eKhachHang();
            var kHang = db.KhachHangs.Where(kh => kh.MaKhachHang.Trim() == makh.Trim()).FirstOrDefault();
            if (kHang != null)
            {
                khachHang.MaKhachHang = kHang.MaKhachHang;
                khachHang.TenKhachHang = kHang.TenKhachHang;
                khachHang.SoDienThoai = kHang.SoDienThoai;
                khachHang.DiaChi = kHang.DiaChi;
                return khachHang;
            }
            return null;
        }


        public bool deleteKhachHang(string id)
        {
            KhachHang khachHang = new KhachHang();
            var temp = db.KhachHangs.Where(kh => kh.MaKhachHang.Trim() == id).FirstOrDefault();
            khachHang = (KhachHang)temp;
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

        public List<eKhachHang> getDanhSachKhachHangCoMatHangQuahang()
        {
            List<eKhachHang> ls = new List<eKhachHang>();
            IEnumerable<KhachHang> temp  = from ctdh in db.ChiTietDonHangs
                                                join donhang in db.DonHangs on ctdh.MaDonHang.Trim() equals donhang.MaDonHang.Trim()
                                                join kh in db.KhachHangs on donhang.MaKhachHang equals kh.MaKhachHang
                                                where (ctdh.HanTraDia < DateTime.Now)
                                                select kh;
            IEnumerable<KhachHang> khachHangs = temp.Distinct();

            foreach (KhachHang kh in khachHangs)
            {
                eKhachHang eKhach = new eKhachHang();
                eKhach.MaKhachHang = kh.MaKhachHang;
                eKhach.TenKhachHang = kh.TenKhachHang;
                eKhach.SoDienThoai = kh.SoDienThoai;
                eKhach.Deleted = kh.Deleted;
                eKhach.DiaChi = kh.DiaChi;
                ls.Add(eKhach);
            }
            return ls;
        }

        public List<eKhachHang> getDanhSachKhachHangTreNo()
        {
            List<eKhachHang> ls = new List<eKhachHang>();
            IEnumerable<KhachHang> temp = from ctdh in db.ChiTietDonHangs
                                          join donhang in db.DonHangs on ctdh.MaDonHang.Trim() equals donhang.MaDonHang.Trim()
                                          join kh in db.KhachHangs on donhang.MaKhachHang equals kh.MaKhachHang
                                          where (ctdh.HanTraDia < DateTime.Now && ctdh.ThanhToanPhiNo == null)
                                          select kh;
            IEnumerable<KhachHang> khachHangs = temp.Distinct();

            foreach (KhachHang kh in khachHangs)
            {
                eKhachHang eKhach = new eKhachHang();
                eKhach.MaKhachHang = kh.MaKhachHang;
                eKhach.TenKhachHang = kh.TenKhachHang;
                eKhach.SoDienThoai = kh.SoDienThoai;
                eKhach.Deleted = kh.Deleted;
                eKhach.DiaChi = kh.DiaChi;
                ls.Add(eKhach);
            }
            return ls;
        }

        public List<eHuyKhoanNo> getThongTinDiaKhachHangChuaTra(string makh)
        {
            

            List<eHuyKhoanNo> ls = new List<eHuyKhoanNo>();

            var ds = from td in db.TieuDes
                     join disk in db.Disk_Games on td.MaTieuDe.Trim() equals disk.MaTieuDe.Trim()
                     join ctdh in db.ChiTietDonHangs on disk.MaDia.Trim() equals ctdh.MaDia.Trim()
                     join donhang in db.DonHangs on ctdh.MaDonHang.Trim() equals donhang.MaDonHang.Trim()
                     where (donhang.MaKhachHang.Trim() == makh.Trim() && ctdh.HanTraDia < DateTime.Now)
                     select new eHuyKhoanNo
                     {
                         MaDia = disk.MaDia,
                         MaTieuDe = td.MaTieuDe,
                         TieuDe = td.TieuDe1,
                         GiaThue = (float)td.GiaThue,
                         SoNgayDuocThue = td.SoNgayDuocThue,
                         LoaiDia = td.LoaiDia,
                         MaDonHang = donhang.MaDonHang,
                         HanTraDia = ctdh.HanTraDia,
                         NgayTraDia = ctdh.NgayTraDia,
                         NgayThue = ctdh.NgayThue,
                         PhiTraTre = (float)ctdh.PhiTraTre,
                         ThanhToanPhiNo = ctdh.ThanhToanPhiNo,
                         MaKhachHang = donhang.MaKhachHang
                     };

            foreach (eHuyKhoanNo item in ds)
            {
                if (item.ThanhToanPhiNo == null)
                    item.DisplayThanhToanPhiNo = "Chưa Thanh Toán";
                else if (!(bool)item.ThanhToanPhiNo)
                    item.DisplayThanhToanPhiNo = "Hủy khoản phí trễ";
                else
                    item.DisplayThanhToanPhiNo = "Đã Thanh Toán";
                ls.Add(item);
            }

            return ls;
        }

    }
}
