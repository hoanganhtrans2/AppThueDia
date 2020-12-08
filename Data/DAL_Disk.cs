using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Data
{
    public class DAL_Disk
    {
        dbQuanLyDiaDataContext db = new dbQuanLyDiaDataContext();
        public string getMaTieuDeTheoDia(string maDia)
        {
            Disk_Game d = db.Disk_Games.Where(x => x.MaDia == maDia).FirstOrDefault();
            return d.MaTieuDe;
        }
        //kiem tra ma dia khi tra dia
        public int kiemTraMaDia(string madia)
        {
            IEnumerable<Disk_Game> dsdisk = db.Disk_Games;
            Disk_Game d = db.Disk_Games.Where(x => x.MaDia == madia).FirstOrDefault();
            if (d != null)
                if (d.TrangThai == "rented")
                    return 1; //dia tra hop le
                else if (d.TrangThai == "onhold")
                    return 2; //dia dang duoc dat truoc
                else return 3; //dia san sang cho thue

            else
                return 0; //khong tim thay dia
        }
        //check if exist
        //dat trang thai onhold cho dia
        public bool datOnholdChoDia(string madia)
        {
            Disk_Game d = db.Disk_Games.Where(x => x.MaDia == madia).FirstOrDefault();
            d.TrangThai = "on hold";
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Đặt đĩa không thành công " + e.Message);
            }
            return true;
        }
    }
}
