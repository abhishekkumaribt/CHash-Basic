using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infosys.QuickKartBusinessLayer;

namespace Infosys.QuickKartTestApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeAssDyn employee = new SystemsEngineer("C#");
            Console.WriteLine(Finance.GetCalculatedSalary(employee));
            employee = new Manager();
            Console.WriteLine(Finance.GetCalculatedSalary(employee));
            employee = new SeniorProjectManager();
            Console.WriteLine(Finance.GetCalculatedSalary(employee));
            Console.ReadKey();
        }
    }
}
