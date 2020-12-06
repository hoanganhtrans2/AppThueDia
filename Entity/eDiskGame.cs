using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class eDiskGame
    {
        private string maDia;
        private bool choThue;
        private bool deleted;

        public string MaDia { get => maDia; set => maDia = value; }
        public bool ChoThue { get => choThue; set => choThue = value; }
        public bool Deleted { get => deleted; set => deleted = value; }

        public enum TrangThai {
            trenKe,
            daChoThue,
        }
            

    }
}
