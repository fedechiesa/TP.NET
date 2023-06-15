using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Convertor
    {
        public double ConvertToInches(double centimeters)
        {
            return centimeters / 2.54;
        }

        public decimal Dolarizar(decimal pesos, decimal cotizacion)
        {
            return pesos / cotizacion;
        }
    }
}