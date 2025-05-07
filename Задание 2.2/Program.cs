namespace Задание_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int count = 0;
            double number;

            Console.WriteLine("Вводите числа. Для завершения введите 0.");

            do
            {
                Console.Write("Введите число: ");
                string input = Console.ReadLine();


                if (!double.TryParse(input, out number))
                {
                    Console.WriteLine("Ошибка! Введите число.");
                    continue; 
                }

                if (number != 0)
                {
                    sum += number;
                    count++;
                }

            } while (number != 0);


            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine($"Сумма чисел: {sum}");
                Console.WriteLine($"Среднее арифметическое: {average}");
            }
            else
            {
                Console.WriteLine("Вы не ввели ни одного числа (кроме 0).");
            }
        }
    }
}
