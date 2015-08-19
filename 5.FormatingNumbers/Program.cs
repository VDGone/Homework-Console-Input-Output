using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FormatingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 0 and 500.");
            int a = int.Parse(Console.ReadLine());

            if (0 <= a && a <= 500)
            {
            }
            else if (0 > a || a > 500)
            {
                Console.WriteLine("Invalid number. Try again.");
                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Another number: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("And another: ");
            double c = double.Parse(Console.ReadLine());

            string binary = Convert.ToString(a, 2);

            Console.WriteLine("{0:X} |{1}| {2,1:0.00}|{3,-1:0.000}", a , binary , b , c);
        }
    }
}
