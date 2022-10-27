using System;
using System.Linq;

namespace FSSFD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа через запятую");

            int[] twoNumbers = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

            Console.WriteLine($"Сумма ваших волшебных чисел равна {twoNumbers[0] + twoNumbers[1]}");

            Console.ReadLine();
        }
    }
}
