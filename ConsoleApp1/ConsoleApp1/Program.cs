using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumber();
            Console.WriteLine($"ваше число: {number}");
        }

        static int GetNumber()
        {
            string userInput;
            int number = 0;
            bool isConverted = false;

            while (isConverted == false)
            {
                Console.Write("Введите число: ");
                userInput = Console.ReadLine();
                isConverted = int.TryParse(userInput, out number);
                Console.WriteLine(number);
            }
            return number;
        }
    }
}