using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumbersDividableByGivenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int p = 0;
            var deck = new List<int>();

            for (int i = firstNumber; i <= secondNumber; i ++)
            {
                if (i % 5 == 0)
                {
                    p++;
                    deck.Add(i);
                }
            }
            Console.WriteLine("Numbers devided by 5:\ntotal: {0}\n{1}", p, string.Join(", ", deck));
        }
    }
}
