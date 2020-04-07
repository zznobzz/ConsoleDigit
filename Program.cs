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
                    var temp = string.Join(",", digits);
                    Console.WriteLine($"Список на данный момент:{temp}");
                }
                else
                {
                    Console.WriteLine($"Введите корректное положительное число!");
                }
                var stat = digits.GetStatistic();
                var statH = string.Join(",", stat.HighNum);
                var statL = string.Join(",", stat.LowNum);
                Console.WriteLine($"Самые длинные числа содержат знаков: {stat.High}. Список:{statH} ");
                Console.WriteLine($"Самые короткие числа содержат знаков: {stat.Low}. Список:{statL}");
                Console.WriteLine($"Среддняя длина чисел в списке: {stat.Average}");
            }
        }
    }

}