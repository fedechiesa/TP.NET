using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class PrintLength
    {
        public void PrinterLength(string text)
        {
            int length = text?.Length ?? 0;
            Console.WriteLine($"Largo del texto:" + length);
        }
    }
}
