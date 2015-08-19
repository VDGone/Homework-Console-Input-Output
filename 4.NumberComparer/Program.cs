using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            double b = double.Parse(Console.ReadLine());

            double greater = Math.Max(a, b);
            Console.WriteLine("Greater: {0}", greater);

        }
    }
}
