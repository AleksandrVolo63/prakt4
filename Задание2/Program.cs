namespace Задание2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double number;

            Console.WriteLine("Вводите числа (для завершения введите 0):");

            do
            {
                Console.Write("Введите число: ");



                while (!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Ошибка! Введите число: ");
                }

                sum += number;

            } while (number != 0);

            Console.WriteLine($"Сумма всех введенных чисел: {sum}");
        }
    }
}