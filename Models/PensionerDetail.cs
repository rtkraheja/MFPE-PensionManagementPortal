﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pension_Management_Portal.Models
{
    public class PensionerDetail
    {
        public string Name { get; set; }
        public double PensionAmount { get; set; }
        public string Pan { get; set; }
        public string AadharNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PensionTypeValue PensionType { get; set; }
        public int BankType { get; set; }
        public int Status { get; set; }
    }

   

    public enum BankType
    {
        Public = 1,
        Private = 2
    }
}
