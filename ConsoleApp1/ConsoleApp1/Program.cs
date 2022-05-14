﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isConverted = false;

            while (isConverted == false)
            {
                GetNumber(out isConverted);
            }
        }

        static void GetNumber(out bool isConverted)
        {
            int number = 0;
            Console.WriteLine("Введите число");
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