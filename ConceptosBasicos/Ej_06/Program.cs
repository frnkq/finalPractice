using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_06
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int start = 0;
            int end = 0;

            Console.WriteLine("Ingrese inicio");
            start = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese fin");
            end = int.Parse(Console.ReadLine());

            for(int i = start; i <= end; i++)
            {
                if (isBisiesto(i))
                    Console.WriteLine(String.Format("Bisiesto: {0}", i));
            }

            Console.WriteLine("finished");
            Console.ReadKey();
        }
        static bool isBisiesto(int n)
        {
            if(n % 100 == 0)
            {
                if (n % 400 == 0 && n % 4 == 0)
                    return true;
            }
            return false;
        }
    }
}
