using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace BUS
{
    public class ChiTietDonHangBUS
    {
        ChiTietDonHangDAL chiTietDonhangDAL;
        public ChiTietDonHangBUS()
        {
            chiTietDonhangDAL = new ChiTietDonHangDAL();
        }

        public List<eATieuDeGameDVD> getChiTietDonHang(string madh)
        {
            return chiTietDonhangDAL.getChiTietDonHang(madh);
        }
    }
}
