using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace BUS
{
    public class BUS_DatTruoc
    {
        DAL_DatTruoc daldt = new DAL_DatTruoc();

        public bool kiemTraDatTruocTieuDe(string matieude)
        {
            return daldt.kiemTraDatTruocTieuDe(matieude);
        }
        public bool ganMaDia(string madia, string matieude)
        {
            return daldt.ganMaDia(madia, matieude);
        }
        public int getMaDatTruoc(string madia)
        {
            return daldt.getMaDatTruoc(madia);
        }
    }
}
