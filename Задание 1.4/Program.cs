namespace Задание_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите целое число в десятичной системе: ");
                int decimalNumber = int.Parse(Console.ReadLine());


                if (decimalNumber == 0)
                {
                    Console.WriteLine("0 в десятичной СС = 0 в пятеричной СС");
                    return;
                }


                bool isNegative = decimalNumber < 0;
                decimalNumber = Math.Abs(decimalNumber);

                string quinaryNumber = "";


                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % 5;
                    quinaryNumber = remainder.ToString() + quinaryNumber;
                    decimalNumber /= 5;
                }


                if (isNegative)
                {
                    quinaryNumber = "-" + quinaryNumber;
                }

                Console.WriteLine($"Результат перевода: {decimalNumber} в десятичной СС = {quinaryNumber} в пятеричной СС");
            }
        }
    }
}