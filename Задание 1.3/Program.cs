namespace Задание_1._3
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
                    Console.WriteLine("0 в десятичной СС = 0 в двоичной СС");
                    return;
                }


                bool isNegative = decimalNumber < 0;
                decimalNumber = Math.Abs(decimalNumber);

                string binaryNumber = "";


                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % 2;
                    binaryNumber = remainder + binaryNumber;
                    decimalNumber /= 2;
                }


                if (isNegative)
                {
                    binaryNumber = "-" + binaryNumber;
                }

                Console.WriteLine($"{decimalNumber} в десятичной СС = {binaryNumber} в двоичной СС");
            }
        }
    }
}