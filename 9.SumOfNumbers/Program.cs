using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times you want to add numbers? Enter number: ");
            double number = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < number; i++) 
            {
                Console.WriteLine("Enter number to add: ");
                double anotherNumber = double.Parse(Console.ReadLine());
                sum = sum + anotherNumber;
            }
            Console.WriteLine("the sum is: {0}", sum);
        }
    }
}
