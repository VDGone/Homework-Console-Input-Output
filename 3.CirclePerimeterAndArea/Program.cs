using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CirclePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");
            double radius = double.Parse(Console.ReadLine());

            double pi = Math.PI;
            double perimeter = 2 * pi * radius;
            double area = pi * (radius * radius);

            Console.WriteLine("Perimeter of the circle: {0:0.00}\nArea of the circle: {1:0.00}", perimeter , area);

        }
    }
}
