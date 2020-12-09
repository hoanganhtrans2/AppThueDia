using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace BUS
{
    public class BUS_Disk
    {
        DAL_Disk dalDisk = new DAL_Disk();
        public string getMaTieuDeTheoDia(string maDia)
        {
            return dalDisk.getMaTieuDeTheoDia(maDia);
        }
        public int kiemTraMaDia(string maDia)
        {
            return dalDisk.kiemTraMaDia(maDia);
        }
        public bool datTrangThaiChoDia(string madia, int trangthai)
        {
            return dalDisk.datTrangThaiChoDia(madia, trangthai);
        }
    }
}
