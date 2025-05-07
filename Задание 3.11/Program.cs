namespace Задание_3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double area = 100.0;      // начальная площадь (га)
            double yield = 20.0;      // начальная урожайность (ц/га)
            const double areaGrowth = 0.05;   // рост площади 5%
            const double yieldGrowth = 0.02;  // рост урожайности 2%

            // а) Урожайность по годам (2-8 годы)
            Console.WriteLine("а) Урожайность по годам (ц/га):");
            double currentYield = yield;
            for (int year = 1; year <= 8; year++)
            {
                if (year > 1)
                {
                    currentYield *= (1 + yieldGrowth);
                }
                if (year >= 2)
                {
                    Console.WriteLine($"Год {year}: {currentYield:F2} ц/га");
                }
            }

            // б) Площадь участка (4-7 годы)
            Console.WriteLine("б) Площадь участка по годам (га):");
            double currentArea = area;
            for (int year = 1; year <= 7; year++)
            {
                if (year > 1)
                {
                    currentArea *= (1 + areaGrowth);
                }
                if (year >= 4)
                {
                    Console.WriteLine($"Год {year}: {currentArea:F2} га");
                }
            }

            // в) Общий урожай за 6 лет
            Console.WriteLine("в) Общий урожай за 6 лет:");
            currentArea = area;
            currentYield = yield;
            double totalHarvest = 0;
            for (int year = 1; year <= 6; year++)
            {
                double harvest = currentArea * currentYield;
                totalHarvest += harvest;

                Console.WriteLine($"Год {year}: {harvest:F0} ц (площадь: {currentArea:F1} га, урожайность: {currentYield:F2} ц/га)");

                currentArea *= (1 + areaGrowth);
                currentYield *= (1 + yieldGrowth);
            }
            Console.WriteLine($"Суммарный урожай за 6 лет: {totalHarvest:F0} ц");
        }
    }
}