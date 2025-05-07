using System.Text;

namespace Задание_3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Введите натуральное число (>0): ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            int square = 0;
            StringBuilder formula = new StringBuilder($"{n}² = ");

            for (int i = 1; i <= n; i++)
            {
                int currentOdd = 2 * i - 1;
                square += currentOdd;

                formula.Append(i > 1 ? $" + {currentOdd}" : $"{currentOdd}");
            }

            Console.WriteLine($"{formula} = {square}");
        }
    }
}