using System.IO;
namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\CODE\\utn\\tp.federico.chiesa\\Ejercicio6\\Test.txt");
            sw.WriteLine("Work in Progress");
            sw.Close();
        }
    }
}