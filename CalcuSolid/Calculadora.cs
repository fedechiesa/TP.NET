using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcuSolid
{
    internal class Calculadora
    {
        private readonly IOperacion _operacion;

        public Calculadora(IOperacion operacion)
        {
            _operacion = operacion;
        }

        public double RealizarOperacion(double a, double b)
        {
            return _operacion.Calcular(a, b);
        }
    }
}
