using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstractClassLibrary.Models
{
    public class SUVFactory : ICarFactory
    {
        public IBmw CreateBMW()
        {
            return new BMWSuv();
        }

        public ITesla CreateTesla()
        {
            return new TeslaSuv();
        }
    }
}
