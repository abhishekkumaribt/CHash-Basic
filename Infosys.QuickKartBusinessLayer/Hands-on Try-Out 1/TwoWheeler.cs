using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer.Hands_on_Try_Out_1
{
    public class TwoWheeler:Vehicle
    {
        private short chainTension;
        public short ChainTension { get { return chainTension; } set
            {
                if (value >= 1 && value <= 7)
                    chainTension = value;
                else
                    chainTension = 7;
            }
        }
        public TwoWheeler(bool areBreaksWorking, float fuelLevel,short chainTension):base(areBreaksWorking,fuelLevel)
        {
            ChainTension = chainTension;
        }
        public bool FixChainTension()
        {
            if (ChainTension == 7)
                return false;
            ChainTension = 7;
            return true;
        }
        public override void RefuelVehicle(float fuelVolume)
        {
            try
            {
                if (FuelLevel + fuelVolume > 10)
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
            if (ChainTension < 5 || ChainTension > 9 || AreBreaksWorking == false)
                VehicleStatus = "Critical";
            else
                VehicleStatus = "OK";
        }
    }
}
