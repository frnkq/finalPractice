using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            double n = Double.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("Cuadrado: {0} Cubo: {1}",
                Math.Pow(n, 2),
                Math.Pow(n, 3)));
            Console.ReadKey();
        }
    }
}
