using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    class Department
    {
        public int deptNumber;
        public bool isProducing;
        public float produce;
        public float GetIncentive(float multiplyFactor)
        {
            float incentive = 0;
            if (isProducing)
                incentive = produce * multiplyFactor;
            return incentive;
        }
    }
}
