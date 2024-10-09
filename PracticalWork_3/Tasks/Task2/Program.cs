using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько у вас на руках карт?");
            int numberOfCards = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= numberOfCards; i++)
            {
                Console.Write($"Введите номинал карты {i}: ");
                string cardValue = Console.ReadLine();

                if (cardValue == "J" || cardValue == "Q" || cardValue == "K" || cardValue == "T")
                    sum += 10;
                else if (int.TryParse(cardValue, out int number) && number >= 2 && number <= 10)
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine($"Некорректное значение карты. Введите корректное число от 2 до 10.");
                    // Если значение карты неверное, то программа не засчитает его в общее количество очков.
                    continue;
                }
            }

            Console.WriteLine($"Сумма карт равна {sum}");
        }
    }
}
