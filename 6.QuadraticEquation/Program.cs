using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for c: ");
            double c = double.Parse(Console.ReadLine());

            double d = (b * b) - (4 * a * c);
            if (d > 0)
            {
                double xOne = (-b - Math.Sqrt(d)) / (2 * a);
                double xTwo = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Roots are : {0} and {1}", xOne, xTwo);
            }
            
            else if (d == 0)
            {
                double onlyOneRoot = -b / (2 * a) ;
                Console.WriteLine("There is only one root: {0}", onlyOneRoot );
            }
            
            else if (d < 0)
            {
                Console.WriteLine("There is no root");
            }

        }
    }
}
