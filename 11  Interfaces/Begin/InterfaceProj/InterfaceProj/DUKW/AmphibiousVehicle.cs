using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProj.DUKW
{
    class AmphibiousVehicle : ILandVehicle, IWaterVehicle
    {
        public void Brake()
        {
        }

        void IWaterVehicle.Brake()
        {
        }
    }
}
