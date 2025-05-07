namespace Задание_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            double sum = 0.0;
            double xPower = x;
            int denominator = 1;

            for (int i = 1; i <= 6; i++)
            {
                sum += xPower / denominator;


                xPower *= x * x;
                denominator += 2;
            }

            Console.WriteLine($"Сумма ряда: {sum:F6}");
        }
    }
}
