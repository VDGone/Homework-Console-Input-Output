using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SumOfFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter five numbers: ");
            
            string[] allNumbers =Console.ReadLine().Split();
            double a = double.Parse(allNumbers[0]);
            double b = double.Parse(allNumbers[1]);
            double c = double.Parse(allNumbers[2]);
            double d = double.Parse(allNumbers[3]);
            double e = double.Parse(allNumbers[4]);

            Console.WriteLine("The sum of five is: {0}", a + b + c + d + e);

        }
    }
}
