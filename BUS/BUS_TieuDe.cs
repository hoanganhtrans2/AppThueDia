using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace BUS
{
    public class BUS_TieuDe
    {
        DAL_TieuDe dalTieuDe = new DAL_TieuDe();
        public DTO_TieuDe getTieuDeTheoMa(string maTieuDe)
        {
            return dalTieuDe.getTieuDeTheoMa(maTieuDe);
        }
    }
}
