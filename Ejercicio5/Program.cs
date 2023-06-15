namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaResto cuentaResto= new CuentaResto();


            Console.WriteLine("ingrese cantidad de panchos: ");
            var hotDog = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese cantidad de papas fritas: ");
            var frenchFries = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese cantidad de gaseosas: ");
            var soda = double.Parse(Console.ReadLine());

            var total = cuentaResto.TomarPedido(hotDog, frenchFries, soda);
            Console.WriteLine("el total a pagar es: " + total);



        }
    }
}