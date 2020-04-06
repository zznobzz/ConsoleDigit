using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var digits = new Digit("Digits List");


            while (true)
            {
                Console.WriteLine("Введите число или q для окончания ввода:");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }

                if (int.TryParse(input, out var value) && value > 0)
                {
                    digits.AddDigit(input);
                    Console.WriteLine($"Добавлено число {input}");
                    //var sortDigits =digits.S
                    var temp = string.Join(",", digits);
                    Console.WriteLine($"Список на данный момент:{temp}");
                }
                else
                {
                    Console.WriteLine($"Введите корректное положительное число!");
                }
                var stat = digits.GetStatistic();
                Console.WriteLine($"Самое длинное число содержит знаков: {stat.High} ");
                Console.WriteLine($"Самое короткое число содержит знаков: {stat.Low} ");
                Console.WriteLine($"В среднем длина числа содержит знаков: {stat.Average}");
            }
        }
    }

}