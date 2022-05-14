using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = " ";
            GetNumber(out number);
            Console.WriteLine($"ваше число: {number}");
        }

        static int GetNumber(out string number)
        {
            while (true)
            {
                Console.WriteLine("Введите число");
                number = Console.ReadLine();
                int convertedNumber;
                if (int.TryParse(number, out convertedNumber))
                {
                    return convertedNumber;
                }
                else
                {
                    Console.WriteLine("Не удалось сконвертировать");
                }
            }
        }
    }
}