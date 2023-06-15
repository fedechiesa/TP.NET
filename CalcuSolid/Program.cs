namespace CalcuSolid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Le damos dos numeros para realizar las operaciones
            double numero1 = 10;
            double numero2 = 5;

            IOperacion operacion = new Suma(); // Elegimos que operacion realizar

            Calculadora calculadora = new Calculadora(operacion);
            double resultado = calculadora.RealizarOperacion(numero1, numero2);

            Console.WriteLine($"El resultado es: {resultado}");
            Console.ReadLine();

        }
    }
}