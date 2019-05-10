using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer.Hands_on_Try_Out_1
{
    class FuelOverflowException : Exception
    {
        public FuelOverflowException():base()
        {
            
        }
    }
    public class FourWheeler:Vehicle
    {
        private char engineCoolantLevel;
        public char EngineCoolantLevel { get { return engineCoolantLevel; }
            set
            {
                if (new List<char> { 'H', 'M', 'L' }.Contains(value))
                    engineCoolantLevel = value;
                else
                    engineCoolantLevel = 'H';
            }
        }
        public FourWheeler(bool areBreaksWorking,float fuelLevel,char engineCoolantLevel):base(areBreaksWorking,fuelLevel)
        {
            EngineCoolantLevel = engineCoolantLevel;
        }
        public bool FixEngineCoolantLevel()
        {
            if (EngineCoolantLevel != 'H')
            {
                EngineCoolantLevel = 'H';
                return true;
            }
            else
                return false;
        }
        public override void RefuelVehicle(float fuelVolume)
        {
            try
            {
                if (FuelLevel + fuelVolume > 50)
                    throw new FuelOverflowException();
            }
            catch (FuelOverflowException)
            {
                fuelVolume = 0;
            }
            FuelLevel += fuelVolume;
        }
        public override void UpdateVehicleStatus()
        {
            if (EngineCoolantLevel == 'L' || AreBreaksWorking == false)
                VehicleStatus = "Critical";
            else
                VehicleStatus = "OK";
        }
    }
}
