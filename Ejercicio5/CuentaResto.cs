using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class CuentaResto
    {
        double hotDog = 2;
        double frenchFries = 1;
        double soda = 0.85;
        double parcialTotal = 0;
        double tip = 0.1;


        public double TomarPedido(double a, double b, double c)
        {
            hotDog = this.hotDog * a;
            frenchFries= this.frenchFries * b;
            soda = this.soda * c;
            parcialTotal = this.parcialTotal;
            tip = this.tip;

            parcialTotal =  (hotDog + frenchFries + soda);
            return parcialTotal * tip + parcialTotal;
        }

        
       
       

        
    }
}
