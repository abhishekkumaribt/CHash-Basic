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
        static void Main(string[] args)
        {
            Category cat = new Category(101, "te45st");
            Console.WriteLine(cat.CategoryId);
            Console.WriteLine(cat.CategoryName);
            Console.ReadLine();
        }
    }
}
