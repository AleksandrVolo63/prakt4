namespace Задание_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("а) Все целые числа от 20 до 35:");
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("б) Квадраты чисел от 10 до b (b > 10):");
            int b;
            do
            {
                Console.Write("Введите b (>10): ");
            } while (!int.TryParse(Console.ReadLine(), out b) || b <= 10);

            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine($"{i}^2 = {i * i}");
            }

            Console.WriteLine("в) Третьи степени чисел от a до 50 (a < 50):");
            int a;
            do
            {
                Console.Write("Введите a (<50): ");
            } while (!int.TryParse(Console.ReadLine(), out a) || a >= 50);

            for (int i = a; i <= 50; i++)
            {
                Console.WriteLine($"{i}^3 = {i * i * i}");
            }

            Console.WriteLine("г) Все целые числа от a до b (b < a):");
            int a2, b2;
            do
            {
                Console.Write("Введите a: ");
            } while (!int.TryParse(Console.ReadLine(), out a2));

            do
            {
                Console.Write($"Введите b (меньше {a2}): ");
            } while (!int.TryParse(Console.ReadLine(), out b2) || b2 >= a2);

            for (int i = a2; i >= b2; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}