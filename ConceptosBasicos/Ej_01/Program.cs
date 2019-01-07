using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int min;
            int max;
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            min = n;
            max = n;
            for(int i = 0; i<4;i++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                if (n > max)
                    max = n;
                if (n < min)
                    min = n;
            }

            Console.WriteLine(String.Format("Min: {0} Max: {1}", min, max));


            Console.ReadKey();
        }
    }
}
