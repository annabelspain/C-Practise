using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProj
{
    public class AmphibiousVehicle : ILandVehicle, IWaterVehicle
    {
        public void Brake()
        {
        }

        void IWaterVehicle.Brake()
        {            
        }
    }
}
