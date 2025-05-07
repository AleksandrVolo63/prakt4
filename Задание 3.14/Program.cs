namespace Задание_3._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Введите n (1 < n <= 10): ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 1 || n > 10);

            long totalSum = 0;
            long factorial = 1;

            Console.WriteLine("Вычисление суммы факториалов:");
            for (int k = 1; k <= n; k++)
            {
                factorial *= k;
                totalSum += factorial;

                Console.Write($"{k}!");
                if (k < n)
                    Console.Write(" + ");
                else
                    Console.Write($" = {totalSum}");
            }
        }
    }
}