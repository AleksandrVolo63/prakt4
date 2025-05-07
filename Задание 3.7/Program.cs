namespace Задание_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SubjectsCount = 10;
            int sum = 0;

            Console.WriteLine($"Введите {SubjectsCount} оценок ученика (1-5):");

            for (int i = 0; i < SubjectsCount; i++)
            {
                int grade;
                do
                {
                    Console.Write($"Оценка по предмету {i + 1}: ");
                } while (!int.TryParse(Console.ReadLine(), out grade) || grade < 1 || grade > 5);

                sum += grade;
            }

            double average = (double)sum / SubjectsCount;
            Console.WriteLine($"Средний балл: {average:F1}");
        }
    }
}
