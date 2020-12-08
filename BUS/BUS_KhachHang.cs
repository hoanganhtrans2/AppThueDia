using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();
        public BUS_KhachHang()
        {
            
        }
        public int kiemTraKhachHang(string maKH)
        {
            return dalKhachHang.kiemTraKhachHang(maKH);
        }
        public string getNameKhachHang(string makh)
        {
            return dalKhachHang.getNameKhachHang(makh);
        }
    }
}
