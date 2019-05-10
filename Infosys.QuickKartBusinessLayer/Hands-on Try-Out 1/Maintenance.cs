using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer.Hands_on_Try_Out_1
{
    public class Maintenance
    {
        public double MaintenanceCharges { get; set; }
        public void RefuelVehicle(Vehicle vehicle, float volumeToBeFilled)
        {
            float volumeBefore = vehicle.FuelLevel;
            vehicle.RefuelVehicle(volumeToBeFilled);
            float volumeAfter = vehicle.FuelLevel;
            if (volumeBefore == volumeAfter)
                volumeToBeFilled = 0;
            MaintenanceCharges += volumeToBeFilled * 70;
        }
        public void ServiceVehicle(Vehicle vehicle)
        {
            vehicle.UpdateVehicleStatus();
            if (vehicle.VehicleStatus == "Critical")
            {
                if (vehicle.FixBreaks())
                    MaintenanceCharges += 20.5;
                if (vehicle is TwoWheeler && ((TwoWheeler)vehicle).FixChainTension())
                    MaintenanceCharges += 30.75;
                if (vehicle is FourWheeler && ((FourWheeler)vehicle).FixEngineCoolantLevel())
                    MaintenanceCharges += 50.20;
                vehicle.VehicleStatus = "OK";
            }
        }
    }
}
