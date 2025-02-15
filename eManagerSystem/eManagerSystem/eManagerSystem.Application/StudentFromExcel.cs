﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using LinqToExcel.Attributes;
namespace eManagerSystem.Application
{
    [Serializable]
    public class StudentFromExcel
    {
        [ExcelColumn("MSSV")]
        public string MSSV {get; set;}

        [ExcelColumn("HoTen")]
        public string FullName { get; set; }

        [ExcelColumn("Lop")]
        public string Grade { get; set; }
    }
}
