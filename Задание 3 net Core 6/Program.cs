using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Задание_3_net_Core_6
{
    internal class Program
    {
            static async Task Main(string[] args)
            {
            Console.WriteLine("Добро пожаловать! Перед использованием пожалуйста не забудьте зарегестрироваться на сайте openweathermap.org и ввести с вашего аккаунта API ");
            // Введите свой API-ключ OpenWeatherMap
            Console.WriteLine("Введите API ключ:");
                string apiKey = Console.ReadLine();
                // Введите название города, о котором нужно получить информацию
                Console.WriteLine("Введите город в котором хотите узнать температуру и скорость ветра: ");
                string city = Console.ReadLine();
                // Создайте экземпляр HttpClient
                HttpClient client = new HttpClient();
                // Создайте URL-адрес запроса
                string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";
                try
                {
                    // Отправьте GET-запрос и получите ответ
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    // Прочитайте ответ как строку
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Десериализуйте JSON-ответ в объект
                    WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);
                    // Выведите информацию о погоде на консоль
                    Console.WriteLine($"Температура в городе {city}: {weatherData.Main.Temp} °C");
                    Console.WriteLine($"Скорость ветра: {weatherData.Wind.Speed} м/c");
                }
                catch (HttpRequestException)
                {
                    Console.WriteLine("Ошибка!!! Введен не верно API или название города! Пожалуйста попробуйте еще раз!");
                }
            }
    }
        // Класс, представляющий данные о погоде
        public class WeatherData
        {
            public MainData Main { get; set; }
            public WindData Wind { get; set; }
        }
        // Класс, представляющий основные данные о погоде
        public class MainData
        {
            public double Temp { get; set; }
        }
        // Класс, представляющий данные о ветре
        public class WindData
        {
            public double Speed { get; set; }
        }
}