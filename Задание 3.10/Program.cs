namespace Задание_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dailyRun = 10.0;
            double totalRun = 0.0;

            Console.WriteLine("а) Пробег по дням:");

            // а)
            for (int day = 1; day <= 10; day++)
            {
                if (day > 1)
                {
                    dailyRun *= 1.1;
                }

                Console.WriteLine($"День {day}: {dailyRun:F2} км");

                // б)
                if (day <= 7)
                {
                    totalRun += dailyRun;
                }
            }

            Console.WriteLine($"б) Суммарный пробег за 7 дней: {totalRun:F2} км");
        }
    }
}