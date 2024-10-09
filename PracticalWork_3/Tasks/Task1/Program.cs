using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number % 2 == 0)
                Console.WriteLine($"{number} — чётное число.");
            else
                Console.WriteLine($"{number} — нечётное число.");
        }
    }
}
