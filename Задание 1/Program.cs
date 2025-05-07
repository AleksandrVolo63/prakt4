namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Цифры числа: ");


            if (N == 0)
            {
                Console.WriteLine("0");
                return;
            }


            bool isNegative = N < 0;
            N = Math.Abs(N);


            string digits = "";


            while (N > 0)
            {
                int digit = N % 10;
                digits = digit + " " + digits;
                N /= 10;
            }


            if (isNegative)
            {
                Console.Write("- ");
            }
            Console.WriteLine(digits.Trim());
        }
    }
}