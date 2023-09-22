using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstractClassLibrary.Models
{
    public class BMWSedan : IBmw
    {
        public void start()
        {
            Console.WriteLine("BMW Sedan start");
        }

        public void stop()
        {
            Console.WriteLine("Bmw sedan stop");
        }
    }
}
