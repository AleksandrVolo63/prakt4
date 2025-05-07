namespace Задание_1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в семеричной системе: ");
            string septenaryNumber = Console.ReadLine();


            foreach (char c in septenaryNumber)
            {
                if (c < '0' || c > '6')
                {
                    Console.WriteLine("Ошибка: введено не семеричное число!");
                    return;
                }
            }

            int decimalNumber = 0;
            int power = 1;


            for (int i = septenaryNumber.Length - 1; i >= 0; i--)
            {
                int digit = septenaryNumber[i] - '0';
                decimalNumber += digit * power;
                power *= 7;
            }

            Console.WriteLine($"{septenaryNumber} в семеричной СС = {decimalNumber} в десятичной СС");
        }
    }
}