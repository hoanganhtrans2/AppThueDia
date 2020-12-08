using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace BUS
{
    public class BUS_ChiTietHoaDon
    {
        DAL_ChiTietDonHang dalchitiet = new DAL_ChiTietDonHang();
        public bool taoChiTietDonHang(DTO_ChiTietDonHang chitiet)
        {
            return dalchitiet.taoChiTietDonHang(chitiet);
        }
        public List<DTO_ChiTietDonHang> getDanhSachChiTietDH(string makh)
        {
            return dalchitiet.getDanhSachChiTietDH(makh);
        }
        public double getPhiThue(string mahd, string madia)
        {
            return dalchitiet.getPhiThue(mahd, madia);
        }
        public bool capNhatTraDia(string madia, DateTime ngaytra)
        {
            return dalchitiet.capNhatTraDia(madia, ngaytra);
        }


    }
}
