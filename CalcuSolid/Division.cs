using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcuSolid
{
    internal class Division : IOperacion
    {
        public double Calcular(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero.");
            }

            return a / b;
        }
    }
}
