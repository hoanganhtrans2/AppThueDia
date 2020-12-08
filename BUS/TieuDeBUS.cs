using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace BUS
{
   public class TieuDeBUS
    {
        TieuDeDAL deDAL;
        public TieuDeBUS()
        {
            deDAL = new TieuDeDAL();
        }
        public bool themTieuDe(eATieuDe tieuDe)
        {
            return deDAL.themTieuDe(tieuDe);
        }
        public List<eATieuDe> getAllTieuDe()
        {
            return deDAL.getAllTieuDe();
        }
        public bool deleteTieuDe(string id)
        {
            return deDAL.deleteTieuDe(id);
        }

        public eATieuDe getTieuDeTheoLoai(string loai)
        {
            return deDAL.getTieuDeTheoLoai(loai);
        }

        public bool capNhatThongTinChoThue(string loaiDia, float giaThue, int soNgayThue)
        {
            return deDAL.capNhatThongTinChoThue(loaiDia, giaThue, soNgayThue);
        }

    }
}
