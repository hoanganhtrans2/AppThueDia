using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace BUS
{
   public class BaoCaoTieuDeBUS
    {
        BaoCaoTieuDeDAL baoCaoTieuDeDAL;
        public BaoCaoTieuDeBUS()
        {
            baoCaoTieuDeDAL = new BaoCaoTieuDeDAL();
        }

        public List<eBaoCaoTieuDe> getBaoCao()
        {
            return baoCaoTieuDeDAL.getBaoCao();
        }
    }
}
