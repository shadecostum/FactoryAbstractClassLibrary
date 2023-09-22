using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstractClassLibrary.Models
{
    public class BMWSuv : IBmw
    {
        public void start()
        {
            Console.WriteLine("BmW suv start");
        }

        public void stop()
        {
            Console.WriteLine("BmW suv stop");
        }
    }
}
