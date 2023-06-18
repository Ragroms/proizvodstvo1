using System.Linq.Expressions;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Добро пожаловать!:)");
                Console.WriteLine("Введите первое число: ");
                int X = int.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int Y = int.Parse(Console.ReadLine());

                if (X == Y)
                {
                    Console.WriteLine("Числа равны. (=)");
                }
                else if (X > Y)
                {
                    Console.WriteLine($"Первое число ({X}) больше второго числа ({Y}). (>)");
                }
                else
                {
                    Console.WriteLine($"Второе число ({Y}) больше первого числа ({X}). (<)");
                }
                Console.WriteLine("Результат получен!");
            }
            catch 
            {
                Console.WriteLine("Ошибка!!! Вы ввели не число!");
            }
        }
    }
}