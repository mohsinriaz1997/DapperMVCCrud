﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperMVCCRUD.Models
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public int Sallary { get; set; }
    }
}