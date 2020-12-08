using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DTO_DonHang
    {
        private string maDonHang;

        
        private DateTime ngayThue;
        
        
        private string maKhachHang;

        public string MaDonHang
        {
            get
            {
                return maDonHang;
            }

            set
            {
                maDonHang = value;
            }
        }

        

        

        public DateTime NgayThue
        {
            get
            {
                return ngayThue;
            }

            set
            {
                ngayThue = value;
            }
        }

        

        

        public string MaKhachHang
        {
            get
            {
                return maKhachHang;
            }

            set
            {
                maKhachHang = value;
            }
        }
    }
}
