using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Promedio
    {
        int cantidadNumeros = 4;
        public double Promediar(double a, double b, double c, double d)
        {
            return (a + b + c + d) / cantidadNumeros;
        }
    }
}
