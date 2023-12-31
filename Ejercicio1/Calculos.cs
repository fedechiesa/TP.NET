﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Calculos
    {
        public float Sumar(float a, float b)
        {
            return a + b;
        }
        public float Restar(float a, float b)
        {
            return a - b;
        }
        public float Multiplicar(float a, float b)
        {
            return a * b;
        }
        public float Dividir(float a, float b)
        {
            if (b == 0)
            {
                throw new ArgumentException("No se puede dividir por CERO");
            }
            return a / b;

        }
        public float Resto(float a, float b)
        {
            return a % b;
        }
        public static double Potenciar(double a, double n)
        {
            return Math.Pow(a, n);
        }
            
        public float TriangleArea(float b, float h)
        {
            return (b * h) / 2;
        }
        public static double CircleArea()
        {
            Console.WriteLine("ingrese el radio del circulo:");
            double r = double.Parse(Console.ReadLine());
            return 2 * Math.PI * r;
        }
        public float CelsiusAFahrenheit()
        {
            Console.WriteLine("ingrese grados celsius");
            float celsius = float.Parse(Console.ReadLine());
            float fahrenheit = celsius * 9 / 5 + 32;
            return fahrenheit;

        }

    }
}
