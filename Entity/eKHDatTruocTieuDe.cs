using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class eKHDatTruocTieuDe
    {
        private int id;
        private DateTime ngayDatHang;

        public int Id { get => id; set => id = value; }
        public DateTime NgayDatHang { get => ngayDatHang; set => ngayDatHang = value; }
    }
}
