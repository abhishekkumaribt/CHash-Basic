using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer.Hands_on_Try_Out_1
{
    public abstract class Vehicle
    {
        private float fuelLevel;
        public bool AreBreaksWorking { get; set; }
        public float FuelLevel { get { return fuelLevel; }
            set
            {
                if(this is TwoWheeler)
                {
                    if (value > 10)
                        fuelLevel = 10;
                    else
                        fuelLevel = value;
                }
                if (this is FourWheeler)
                {
                    if (value > 50)
                        fuelLevel = 50;
                    else
                        fuelLevel = value;
                }
            }
        }
        public string VehicleStatus { get; set; }
        public Vehicle(bool areBreaksWorking,float fuelLevel)
        {
            AreBreaksWorking = areBreaksWorking;
            FuelLevel = fuelLevel;
        }
        public bool FixBreaks()
        {
            if (AreBreaksWorking == false)
            {
                AreBreaksWorking = true;
                return true;
            }
            else
                return false;
        }
        public abstract void RefuelVehicle(float fuelVolume);
        public abstract void UpdateVehicleStatus();
    }
}
