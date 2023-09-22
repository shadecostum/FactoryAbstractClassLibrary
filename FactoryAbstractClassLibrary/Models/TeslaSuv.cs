using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstractClassLibrary.Models
{
    internal class TeslaSuv : ITesla
    {
        public void start()
        {
            Console.WriteLine("Tesla Suv Start");
        }

        public void stop()
        {
            Console.WriteLine("Tesla Suv Stop");

        }
    }
}
