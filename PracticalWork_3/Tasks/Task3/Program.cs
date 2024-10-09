using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
                i++;
            }

            if (isPrime)
                Console.WriteLine($"{number} — простое число.");
            else
                Console.WriteLine($"{number} — не простое число.");
        }
    }
}
