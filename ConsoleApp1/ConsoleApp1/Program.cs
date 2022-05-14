using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNumber();
        }

        static void GetNumber()
        {
            bool isConverted = false;
            int number = 0;
            Console.WriteLine("Введите число");

            while (isConverted == false)
            {
                string input = Console.ReadLine();
                isConverted = int.TryParse(input, out number);

                if (isConverted == true)
                {
                    Console.WriteLine($"Ваше число: {number}");
                }
                else
                {
                    Console.WriteLine("Не удалось сконвертировать");
                }
            }

        }
    }
}