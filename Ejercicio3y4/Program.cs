namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Convertor convertor = new Convertor();
            var toInches = convertor.ConvertToInches(45);
            Console.WriteLine("longitud : " + toInches);

            Console.WriteLine("Ingrese el valor en pesos:");
            var pesos = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cotizacion del dia:");
            var cotizacion = decimal.Parse(Console.ReadLine());
            

            decimal dolarizado = convertor.Dolarizar(pesos, cotizacion);
            Console.WriteLine(pesos + "pesos son: " + dolarizado + "u$d");
        }
    }
}