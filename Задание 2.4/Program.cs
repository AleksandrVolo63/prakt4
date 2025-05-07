namespace Задание_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Random rnd = new Random();
                List<int> numbers = new List<int>();
                int attempts = 0;
                int currentNumber;

                Console.WriteLine("Генерация случайных чисел от 1 до 10...");

                do
                {
                    currentNumber = rnd.Next(1, 11);
                    numbers.Add(currentNumber);
                    attempts++;
                    Console.WriteLine($"Сгенерировано: {currentNumber}");
                } while (currentNumber != 7);


                Console.WriteLine("\nВсе сгенерированные числа:");
                Console.WriteLine(string.Join(", ", numbers));
                Console.WriteLine($"Число попыток до выпадения 7: {attempts}");
            }
        }
    }
}