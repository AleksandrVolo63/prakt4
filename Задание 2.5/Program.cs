namespace Задание_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальное число (M): ");
            int M = int.Parse(Console.ReadLine());

            int a = 0; 
            int b = 1;
            int next;

            Console.WriteLine("Последовательность Фибоначчи:");


            Console.Write($"{a}, {b}");


            do
            {
                next = a + b;
                if (next > M)
                    break;

                Console.Write($", {next}");
                a = b;
                b = next;
            } while (true);

            Console.WriteLine();
        }
    }
}