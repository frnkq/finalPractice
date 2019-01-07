using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            double n = Double.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                if ((n % i == 0))
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
