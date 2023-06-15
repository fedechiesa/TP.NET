using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Operadores
    {
        public int a = 10;
        public int b = 15;

        bool condition1 = true;
        bool condition2 = false;

        public int MasIgual()
        {
            return a += b;
        }
        public int Incrementar()
        {
            b++;
            return b;

        }
        public bool And()
        {
            return condition1 & condition2;
        }
        public bool Or()
        {
            return condition1 | condition2;
        }

    }
}
