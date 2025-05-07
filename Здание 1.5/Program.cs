namespace Здание_1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите двоичное число: ");
                string binaryNumber = Console.ReadLine();


                foreach (char c in binaryNumber)
                {
                    if (c != '0' && c != '1')
                    {
                        Console.WriteLine("Ошибка: введено не двоичное число!");
                        return;
                    }
                }

                int decimalNumber = 0;
                int power = 1;


                for (int i = binaryNumber.Length - 1; i >= 0; i--)
                {
                    if (binaryNumber[i] == '1')
                    {
                        decimalNumber += power;
                    }
                    power *= 2;
                }

                Console.WriteLine($"{binaryNumber} в двоичной СС = {decimalNumber} в десятичной СС");
            }
        }
    }
}