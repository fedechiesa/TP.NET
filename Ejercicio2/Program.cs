namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Promedio promedio= new Promedio();
            var resultado = promedio.Promediar(55, 71, 46, 87);
            Console.WriteLine("El promedio es : " + resultado);

        }
    }
}