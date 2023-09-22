using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstractClassLibrary.Models
{
    public interface ICarFactory
    {
        ITesla CreateTesla();

        IBmw CreateBMW();

    }
}
