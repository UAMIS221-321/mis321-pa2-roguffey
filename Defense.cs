using System;
using mis321_pa2_roguffey.Interfaces;

namespace mis321_pa2_roguffey
{
    public class Defense : IDefend
    {
        public double Defend(double power)
        {
            return power;
        }
    }
}