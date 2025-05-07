namespace Задание_3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество этапов (N): ");
            int N = int.Parse(Console.ReadLine());

            double distanceFromHome = 0.0;
            double totalPath = 0.0;

            for (int n = 1; n <= N; n++)
            {
                double step = 1.0 / n;
                totalPath += step;



                if (n % 2 == 1)
                {
                    distanceFromHome -= step;
                }
                else
                {
                    distanceFromHome += step;
                }
            }

            Console.WriteLine($"а) После {N} этапов расстояние от дома: {Math.Abs(distanceFromHome):F6} км");
            Console.WriteLine($"б) Общий пройденный путь: {totalPath:F6} км");
        }
    }
}