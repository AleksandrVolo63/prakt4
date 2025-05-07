namespace Задание_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int number;
                bool isValidInput;

                Console.WriteLine("Введите число от 1 до 100 включительно:");

                do
                {
                    Console.Write("> ");
                    string input = Console.ReadLine();


                    isValidInput = int.TryParse(input, out number) && number >= 1 && number <= 100;

                    if (!isValidInput)
                    {
                        Console.WriteLine("Ошибка! Введите целое число от 1 до 100.");
                    }

                } while (!isValidInput);

                Console.WriteLine($"Вы ввели корректное число: {number}");
            }
        }
    }
}