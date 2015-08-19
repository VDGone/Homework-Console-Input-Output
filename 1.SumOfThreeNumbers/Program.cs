using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SumOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("And another: ");
            double c = double.Parse(Console.ReadLine());

            double sum = a + b + c;
            Console.WriteLine("Sum of your numbers is: {0}", sum );
        }
    }
}
