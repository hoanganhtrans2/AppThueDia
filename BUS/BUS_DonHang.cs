using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace BUS
{
    public class BUS_DonHang
    {
        DAL_DonHang dalDonHang = new DAL_DonHang();
        public bool taoDonHang(string maKH)
        {
            return dalDonHang.taoDonHang(maKH);
        }
        public string getMaDonHangTheoMaDia(string madia)
        {
            return dalDonHang.getMaDonHangTheoMaDia(madia);
        }
    }
}
