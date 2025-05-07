namespace Задание_3._15
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

            double sum = 1.0;
            double factorial = 1.0;

            Console.WriteLine("Вычисление суммы ряда:");
            Console.Write("1");

            for (int k = 1; k <= n; k++)
            {
                factorial *= k;
                double term = 1.0 / factorial;
                sum += term;

                Console.Write($" + 1/{k}!"); 
            }

            Console.WriteLine($" = {sum:F10}");
        }
    }
}