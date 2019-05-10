using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class SeniorProjectManager:EmployeeAssDyn
    {
        public double CarAllowance { get; set; }
        public SeniorProjectManager()
        {
            CarAllowance = 6000;
        }
        public override double CalculateSalary()
        {
            return BasicSalary + CarAllowance;
        }
    }
}
