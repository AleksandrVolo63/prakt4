﻿namespace Задание_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            int sign = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += sign * (1.0 / i);
                sign *= -1;
            }

            Console.WriteLine($"Сумма ряда: {sum:F4}");
        }
    }
}