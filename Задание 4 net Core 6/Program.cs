using System;

namespace Задание_4_net_Core_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h, v, t;
            const double g = 9.81;

            Console.Write("Введите высоту (м): ");
            if (!double.TryParse(Console.ReadLine(), out h)) // Ввод и обработчик ошибок♥
            {
                Console.WriteLine("Ошибка ввода!");
                return;
            }
            if (h < 0)
            {
                Console.WriteLine("Высота не может быть отрицательной!");
                return;
            }
            // формула Скорости подения
            v = Math.Sqrt(2 * g * h);
            // Формула Времени
            t = Math.Sqrt((2 * h) / g);
            // Результат
            Console.WriteLine($"Скорость падения: {v:F1} м/c");
            Console.WriteLine($"Время падения: {t:F2} сек");
        }
    }
}