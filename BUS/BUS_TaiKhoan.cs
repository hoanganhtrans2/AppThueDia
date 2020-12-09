using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan Datatk = new DAL_TaiKhoan();
        public bool dangNhap(string taikhoan, string matkhau)
        {
            return Datatk.dangNhap(taikhoan, matkhau);
        }
    }
}
