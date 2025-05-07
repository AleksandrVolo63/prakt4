namespace Задание_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите число для повторения: ");
            int number = int.Parse(Console.ReadLine());


            Console.Write("Введите количество повторений (N): ");
            int N = int.Parse(Console.ReadLine());


            Console.Write($"Ряд чисел {number}: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}