namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit;
            double interestRate;

            try
            {
                Console.Write("Введите сумму вклада: ");
                deposit = Convert.ToDouble(Console.ReadLine());

                if (deposit < 100)
                {
                    interestRate = 0.05;
                }
                else if (deposit >= 100 && deposit <= 200)
                {
                    interestRate = 0.07;
                }
                else
                {
                    interestRate = 0.1;
                }

                double interest = deposit * interestRate;
                double total = deposit + interest;

                Console.WriteLine("Начисленные проценты: " + interest);
                Console.WriteLine("Общая сумма: " + total);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка!!! Введите число!");
            }
        }
    }
}