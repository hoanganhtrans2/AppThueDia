﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DTO_TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;

        public string TenTaiKhoan
        {
            get
            {
                return tenTaiKhoan;
            }

            set
            {
                tenTaiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }
    }
}
