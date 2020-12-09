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
        public string taoDonHang(string maKH)
        {
            return dalDonHang.taoDonHang(maKH);
        }

    }
}
