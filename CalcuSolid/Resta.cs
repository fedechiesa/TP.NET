﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcuSolid
{
    internal class Resta : IOperacion
    {
        public double Calcular(double a, double b)
        {
            return a - b;
        }
    }
}
