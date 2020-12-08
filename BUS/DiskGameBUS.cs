using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace BUS
{
  public  class DiskGameBUS
    {

        DiskGameDAL diskGameDVDDAL;
        public DiskGameBUS()
        {
            diskGameDVDDAL = new DiskGameDAL();
        }

        public List<eATieuDeGameDVD> getAllDiskGameDVD()
        {
            return diskGameDVDDAL.getAllDiskGameDVD();
        }

        public bool deleteDia(string id)
        {
            return diskGameDVDDAL.deleteDia(id);
        }
        public List<eAHuyKhoanNo> getThongTinDiaKhachHangChuaTra(string makh)
        {
            return diskGameDVDDAL.getThongTinDiaKhachHangChuaTra(makh);
        }

        public List<eAHuyKhoanNo> getThongTinKhachHangDangNo(string makh)
        {
            return diskGameDVDDAL.getThongTinKhachHangDangNo(makh);
        }
    }
}
