using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности:");
            int length = int.Parse(Console.ReadLine());

            int min = int.MaxValue;
            int i = 0;

            while (i < length)
            {
                Console.Write($"Введите число {i + 1}: ");
                int number = int.Parse(Console.ReadLine());

                if (number < min)
                    min = number;
                i++;
            }

            Console.WriteLine($"Наименьшее число в последовательности равно {min}");
        }
    }
}
