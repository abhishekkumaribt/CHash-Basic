using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infosys.QuickKartBusinessLayer;
using Infosys.QuickKartBusinessLayer.Hands_on_Try_Out_1;

namespace Infosys.QuickKartTestApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Vehicle veh1 = new TwoWheeler(false, 20, 18);
            Vehicle veh2 = new FourWheeler(false, 60, 'M');
            Maintenance maintain = new Maintenance();
            maintain.RefuelVehicle(veh1, 15);
            maintain.ServiceVehicle(veh1);
            Console.WriteLine(maintain.MaintenanceCharges);
            maintain = new Maintenance();
            maintain.RefuelVehicle(veh2, 60);
            maintain.ServiceVehicle(veh2);
            Console.WriteLine(maintain.MaintenanceCharges);
            Console.ReadKey();
        }
    }
}
