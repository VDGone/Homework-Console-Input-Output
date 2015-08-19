using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.NumbersFromOneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
