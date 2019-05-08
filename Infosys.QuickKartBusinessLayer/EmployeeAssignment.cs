using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    class EmployeeAssignment
    {
        public int fixedSalary;
        public DateTime workingFrom;
        public Department department;
        private double GetAllowance(DateTime cutOffDate)
        {
            double workExperience = (cutOffDate.Subtract(workingFrom)).TotalDays / 365;
            double allownce = 0;
            if (workExperience < 5)
                allownce = 0.05;
            else if (workExperience < 10 && workExperience >= 5)
                allownce = 0.1;
            else if (workExperience < 15 && workExperience >= 10)
                allownce = 0.15;
            else if (workExperience >= 15)
                allownce = 0.2;
            allownce = fixedSalary * allownce;
            return allownce;
        }
        private double GetAllowance()
        {
            DateTime cutOffDate = new DateTime(2014, 03, 31);
            return GetAllowance(cutOffDate);
        }
        public double GetTotalSalary(DateTime cutOffDate, float multiplyFactor)
        {
            double totalSalary = 0;
            totalSalary = fixedSalary + GetAllowance(cutOffDate) + department.GetIncentive(multiplyFactor);
            return totalSalary;
        }
        public double GetTotalSalary(float multiplyFactor)
        {
            double totalSalary = 0;
            totalSalary = fixedSalary + GetAllowance() + department.GetIncentive(multiplyFactor);
            return totalSalary;
        }
    }
}
