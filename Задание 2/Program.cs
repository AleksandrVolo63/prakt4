namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)

            {
                Console.Write("Введите начальную сумму вклада (N рублей): ");
                double amount = double.Parse(Console.ReadLine());

                const double targetAmount = 100000;
                const double interestRate = 0.02;
                int months = 0;

                while (amount < targetAmount)
                {
                    amount *= (1 + interestRate);
                    months++;

                    Console.WriteLine($"После {months} месяца(ев): {amount:F2} рублей");
                }

                Console.WriteLine($"Результат: 100000 рублей будет достигнуто через {months} месяцев");
                Console.WriteLine($"Итоговая сумма: {amount:F2} рублей");
            }
        }
    }
