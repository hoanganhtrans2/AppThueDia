using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace BUS
{
   public class KhachHangBUS
    {
        DALKhachHang dAL;
        public KhachHangBUS()
        {
            dAL = new DALKhachHang();
        }
        public List<eKhachHang> getAllKhachHang()
        {
            return dAL.getAllKhachHang();
        }
        public bool deleteKhachHang(string id)
        {
            return dAL.deleteKhachHang(id);
        }
        public eKhachHang getKhachHangById(string makh)
        {
            return dAL.getKhachHangById(makh);
        }
    }
}
