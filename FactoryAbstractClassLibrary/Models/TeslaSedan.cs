using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstractClassLibrary.Models
{
    internal class TeslaSedan : ITesla
    {
        public void start()
        {
            Console.WriteLine("Tesla Sedan Start");

        }

        public void stop()
        {
            Console.WriteLine("Tesla Sedan Start");
            
        }
    }
}
