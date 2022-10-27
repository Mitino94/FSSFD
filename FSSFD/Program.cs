using System;
using System.Linq;

namespace FSSFD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Введите первое число!");

            if (!int.TryParse(Console.ReadLine(), out int firstNumber))
            {
                Console.WriteLine("Число введено неверно!");

                Console.ReadLine();

                return;
            }

            Console.WriteLine("Введите второе число!");

            if (!int.TryParse(Console.ReadLine(), out int secondNumber))
            {
                Console.WriteLine("Число введено неверно!");

                Console.ReadLine();

                return;
            }

            Console.WriteLine($"Сумма ваших чисел равна {firstNumber + secondNumber}");
            Console.WriteLine($"Разность ваших чисел равна {firstNumber - secondNumber}");
            Console.WriteLine($"Произведение ваших чисел равна {firstNumber * secondNumber}");

            Console.ReadLine();
        }
    }
}
