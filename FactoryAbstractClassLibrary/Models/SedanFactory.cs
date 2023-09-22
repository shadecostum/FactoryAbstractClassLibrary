using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstractClassLibrary.Models
{
    public class SedanFactory : ICarFactory
    {
        public IBmw CreateBMW()
        {
            return new BMWSedan();
        }

        public ITesla CreateTesla()
        {
            return new TeslaSedan();
        }
    }
}
