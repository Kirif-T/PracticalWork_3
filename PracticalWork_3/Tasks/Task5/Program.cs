using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = GetMaxNumberFromUser();
            Random random = new Random();
            int secretNumber = random.Next(0, maxNumber);

            Console.WriteLine("Я загадал число от 0 до " + maxNumber + ". Угадывайте!");

            while (true)
            {
                int guess = GetGuessFromUser(secretNumber);
                if (guess == secretNumber)
                {
                    Console.WriteLine("Вы угадали! Число было " + secretNumber);
                    break;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Ваше число меньше загаданного.");
                }
                else
                {
                    Console.WriteLine("Ваше число больше загаданного.");
                }
            }
        }

        private static int GetMaxNumberFromUser()
        {
            Console.Write("Введите максимальное целое число диапазона: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int GetGuessFromUser(int secretNumber)
        {
            string input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("Программа завершается. Загаданное число было " + secretNumber);
                return -1;
            }
            else
            {
                return Convert.ToInt32(input);
            }
        }
    }
}
