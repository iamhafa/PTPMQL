﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PTPMQL.Models;

namespace PTPMQL.Models
{
    public class NhanVien : Person
    {
        public string NhanVienID { get; set; }
        public string CongTy { get; set; }
    }
}