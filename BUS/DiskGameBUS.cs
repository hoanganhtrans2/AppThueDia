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

        DALDiskGame diskGameDVDDAL;
        public DiskGameBUS()
        {
            diskGameDVDDAL = new DALDiskGame();
        }

        public List<eTieuDeGameDVD> getAllDiskGameDVD()
        {
            return diskGameDVDDAL.getAllDiskGameDVD();
        }

        public bool deleteDia(string id)
        {
            return diskGameDVDDAL.deleteDia(id);
        }
        public List<eHuyKhoanNo> getThongTinDiaKhachHangChuaTra(string makh)
        {
            return diskGameDVDDAL.getThongTinDiaKhachHangChuaTra(makh);
        }

        public List<eHuyKhoanNo> getThongTinKhachHangDangNo(string makh)
        {
            return diskGameDVDDAL.getThongTinKhachHangDangNo(makh);
        }
    }
}
