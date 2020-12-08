using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace BUS
{
   public class HuyKhoanNoBUS
    {
        HuyKhoanNoDAL huyKhoan;
        public HuyKhoanNoBUS()
        {
            huyKhoan = new HuyKhoanNoDAL();
        }
        public List<eAHuyKhoanNo> getChiTietDonHangCuaKhachHang(string makh)
        {
            return huyKhoan.getChiTietDonHangCuaKhachHang(makh);
        }

        public bool huyPhiTraTre(eAHuyKhoanNo huyKhoanNo)
        {
            return huyKhoan.huyPhiTraTre(huyKhoanNo);
        }
    }
}
