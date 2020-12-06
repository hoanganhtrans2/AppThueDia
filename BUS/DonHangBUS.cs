using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace BUS
{
  public  class DonHangBUS
    {
        DonHangDAL donHangDAL;
        public DonHangBUS()
        {
            donHangDAL = new DonHangDAL();

        }

        public List<eDonHang> getDonHangCuaKhachHang(string maKh)
        {
            return donHangDAL.getDonHangCuaKhachHang(maKh);
        }

        public bool huyPhiTraTre(string madh)
        {
            return donHangDAL.huyPhiTraTre(madh);
        }
    }

}
