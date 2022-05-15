using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = " ";
            GetNumber(ref number);
            Console.WriteLine($"ваше число: {number}");
        }

        static void GetNumber(ref string number)
        {
            bool isConverted = false;
            while (isConverted == false)
            {
                Console.WriteLine("Введите число");
                number = Console.ReadLine();
                int convertedNumber;
                if (int.TryParse(number, out convertedNumber))
                {
                    Console.WriteLine("Получилось");
                    isConverted = true;
                }
                else
                {
                    Console.WriteLine("Не удалось сконвертировать");
                }
            }
        }
    }
}