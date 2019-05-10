using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class EmployeeAssDyn
    {
        private double basicSalary;
        private double bonus;
        private int employeeId;
        public double BasicSalary { get { return basicSalary; } set { basicSalary = value; } }
        public double Bonus { get { return bonus; } set { bonus = value; } }
        public int EmployeeId { get { return employeeId; } set { employeeId = value; } }
        public EmployeeAssDyn()
        {
            BasicSalary = 10000;
        }
        public virtual double CalculateSalary()
        {
            return BasicSalary;
        }
    }
}
