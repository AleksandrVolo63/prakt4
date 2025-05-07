namespace Задание_3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSum = 0;

            Console.WriteLine("Вычисление суммы квадратов чисел от 1 до 10:");
            Console.WriteLine("(каждый квадрат представлен как сумма нечетных чисел)");

            for (int n = 1; n <= 10; n++)
            {
                int square = 0;
                Console.Write($"{n}² = ");


                for (int i = 1; i <= n; i++)
                {
                    int oddNumber = 2 * i - 1;
                    square += oddNumber;


                    if (i == 1)
                        Console.Write(oddNumber);
                    else
                        Console.Write(" + " + oddNumber);
                }

                Console.WriteLine($" = {square}");
                totalSum += square;
            }

            Console.WriteLine($"\nСумма всех квадратов: {totalSum}");
        }
    }
}