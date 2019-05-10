using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class SystemsEngineer:EmployeeAssDyn
    {
        public double SpecialistAllowance { get; set; }
        public string Specialization { get; set; }
        public SystemsEngineer(string specialization):base()
        {
            Specialization = specialization;
        }
        public override double CalculateSalary()
        {
            if(Array.IndexOf(new[] {"C#","Java","SQL" }, Specialization) > -1)
                SpecialistAllowance = 3000;
            else
                SpecialistAllowance = 0;
            return BasicSalary + SpecialistAllowance;
        }
    }
}
