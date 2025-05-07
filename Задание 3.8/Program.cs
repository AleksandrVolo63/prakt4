namespace Задание_3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество предметов: ");
            int count = int.Parse(Console.ReadLine());

            double sum = 0;
            double[] masses = new double[count];

            Console.WriteLine($"Введите массу {count} предметов (в кг):");

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Масса предмета {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out masses[i]) || masses[i] <= 0)
                {
                    Console.WriteLine("Ошибка! Масса должна быть положительным числом.");
                    Console.Write($"Масса предмета {i + 1}: ");
                }
                sum += masses[i];
            }

            double average = sum / count;
            Console.WriteLine($"Средняя масса: {average:F3} кг");
        }
    }
}