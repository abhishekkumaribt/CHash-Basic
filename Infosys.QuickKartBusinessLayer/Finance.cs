using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class Finance
    {
        public static double GetCalculatedSalary(EmployeeAssDyn employee)
        {
            if(employee is SystemsEngineer)
                employee.Bonus = 5000;
            else if(employee is Manager)
                employee.Bonus = 9000;
            else if (employee is SeniorProjectManager)
                employee.Bonus = 15000;
            else
                employee.Bonus = 0;
            return employee.CalculateSalary() + employee.Bonus;
        }
    }
}
