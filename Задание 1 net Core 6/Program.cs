namespace Задание_1_net_Core_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random random = new Random();
                int secretNumber = random.Next(1, 101);
                bool success = false;
                Console.WriteLine("Угадайте число от 1 до 100");

                while (!success)
                {
                    Console.Write("Введите число: ");
                    int input = int.Parse(Console.ReadLine());
                    if (input < 1 || input > 100)
                    {
                        Console.WriteLine("Вы ввели число вне диапазона. Попробуйте еще раз.");
                        continue;
                    }

                    if (input < secretNumber)
                    {
                        Console.WriteLine("Загаданное число больше.");
                    }
                    else if (input > secretNumber)
                    {
                        Console.WriteLine("Загаданное число меньше.");
                    }
                    else
                    {
                        Console.WriteLine("Поздравляю! Вы угадали число!");
                        success = true;
                    }
                }
            }
            catch 
            {
                Console.WriteLine("Ошибка!!! Введино не число!");
            }
        }
    }
}
