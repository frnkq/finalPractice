using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++)
            {
                if (isCentric(i))
                    Console.WriteLine(i);
            }

            Console.WriteLine("finished");
            Console.ReadKey();
        }

       static bool isCentric(int n)
        {
            int sumA = 0;
            int sumB = 0;

            for(int i = 1; i < n; i++)
            {
                sumA += i;
            }
            for(int j = n+1; j < int.MaxValue; j++)
            {
                sumB += j;

                if (sumB == sumA)
                    return true;
                if (sumB > sumA)
                    break;
            }
            return false;
        }
    }
}
