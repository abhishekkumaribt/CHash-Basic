using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class Manager:EmployeeAssDyn
    {
        public double PhoneAllowance { get; set; }
        public Manager()
        {
            PhoneAllowance = 4000;
        }
        public override double CalculateSalary()
        {
            return BasicSalary + PhoneAllowance;
        }
    }
}
