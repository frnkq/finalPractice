using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 0;
            int n = 0;
            do
            {
                if (checkIfPretty(n))
                {
                    Console.WriteLine(n);
                    numbers++;
                }
                n++;
            } while (numbers < 4);

            Console.ReadKey();
        }

            public static bool checkIfPretty(int n)
        {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if(n %i == 0)
                {
                    sum += i;
                }
                if (sum == n)
                    return true;

            }
            return false;

        }
    }

    }

