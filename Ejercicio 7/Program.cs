namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operadores operadores= new Operadores();
            Console.WriteLine(operadores.MasIgual());

            Console.WriteLine(operadores.Incrementar());

            Console.WriteLine(operadores.And());

            Console.WriteLine(operadores.Or());



            PrintLength printer= new PrintLength();

            printer.PrinterLength(null);
            printer.PrinterLength("Hello, World!"); 
            


            int number = -7;
            int shiftedNumber = number >> 31; // Desplazamiento aritmético hacia la derecha
            int resultado = shiftedNumber + number;

            Console.WriteLine(resultado); // Resultado: -2147483640

            Console.ReadLine();
        }
    }
}