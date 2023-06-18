namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 0 до 10: ");

            try
            {
                int X = int.Parse(Console.ReadLine());

                if (X > 5 && X < 10)
                {
                    Console.WriteLine($"{X} попадает в диапазон 5-10");
                }
                else
                {
                    Console.WriteLine($"{X} не попадает в диапазон 5-10");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка!!! Введино не число!");
            }

            Console.ReadKey();
        }
    }
}