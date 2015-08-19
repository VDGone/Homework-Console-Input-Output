using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");

            int lenght = int.Parse(Console.ReadLine());

            if ((lenght == 0) || (lenght == 1))
            {
                Console.WriteLine(lenght);
            }
            else
            {
                int a = 0;
                int b = 1;
                int c = 0;
                Console.Write("{0} {1}", a, b);

                for (int i = 2; i <= lenght; i++)
                {
                    c = a + b;
                    Console.Write(" {0}", c);
                    a = b;
                    b = c;
                }
            }
        }
    }
}
