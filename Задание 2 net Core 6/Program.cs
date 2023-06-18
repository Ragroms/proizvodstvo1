namespace Задание_2_net_Core_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
              Console.WriteLine("Введите текст:");
              string text = Console.ReadLine();
              string path = "file.txt";
              File.WriteAllText(path, text);
              string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '1', '2', '3', '4', '5', '6', '7','8', '9', '0', '-', '=', '+', '*','/', '(', ')', '<','>','"','`', '~', '|', '#', '№', '@', '%', '^', '&','_'}, StringSplitOptions.RemoveEmptyEntries);
              Console.WriteLine("Количество слов в тексте: " + words.Length);
            }
        }
    }
}