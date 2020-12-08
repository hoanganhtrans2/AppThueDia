using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
    public class DAL_ChiTietDonHang
    {
        dbQuanLyDiaDataContext db = new dbQuanLyDiaDataContext();
        //cap nhat chi tiet don hang khi tra dia
        public bool capNhatTraDia(string madia, DateTime ngaytra)
        {
            ChiTietDonHang ct = db.ChiTietDonHangs.Where(x => x.MaDia == madia).FirstOrDefault();
            ct.NgayTraDia = ngaytra;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Cập nhật không thành công " + e.Message);
            }
            return true;
        }
        //
        public bool taoChiTietDonHang(DTO_ChiTietDonHang chitiet)
        {
            ChiTietDonHang ctdh = new ChiTietDonHang();
            ctdh.MaDonHang = chitiet.MaDonHang;
            ctdh.MaDia = chitiet.MaDia;
            ctdh.HanTraDia = chitiet.HanTraDia;
            ctdh.NgayTraDia = chitiet.NgayTraDia;
            ctdh.PhiTraTre = chitiet.PhiTraTre;
            ctdh.ThanhToanPhiNo = chitiet.ThanhToanPhiNo;
            ctdh.PhiThue = chitiet.PhiThue;

            db.ChiTietDonHangs.InsertOnSubmit(ctdh);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Thêm chi tiết đơn hàng không thành công " + e.Message);
            }
            return true;
        }
        //lay danh sach phi tra tre
        public List<DTO_ChiTietDonHang> getDanhSachChiTietDH(string makh)
        {
            List<DTO_ChiTietDonHang> lChiTiet = new List<DTO_ChiTietDonHang>();
            var chitiet = from dh in db.DonHangs
                          join ct in db.ChiTietDonHangs on dh.MaDonHang equals ct.MaDonHang
                          where dh.MaKhachHang == makh && ct.ThanhToanPhiNo == null && ct.PhiTraTre != null
                          select ct;
            foreach (var item in chitiet)
            {
                DTO_ChiTietDonHang cttam = new DTO_ChiTietDonHang(item.MaDonHang, item.MaDia
                    ,(float)item.PhiThue, (DateTime)item.NgayTraDia,(float)item.PhiTraTre, (bool)item.ThanhToanPhiNo, (DateTime)item.HanTraDia);
                lChiTiet.Add(cttam);
            }
            return lChiTiet;
        }
        //
        public double getPhiThue(string mahd, string madia)
        {
            ChiTietDonHang ct = db.ChiTietDonHangs.Where(x => x.MaDonHang == mahd && x.MaDia == mahd).FirstOrDefault();
            return ct.PhiThue;
        }

    }
}
