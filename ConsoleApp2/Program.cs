using ConsoleApp2.Models;
using System.Net.Http.Json;

namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var request = "https://smilebus.by/api/v2/route/schedule-detail?city_from_id=58&city_to_id=1&date=08.03.2026&stop_from_id=249&stop_to_id=2";
            while (true)
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        // Отправка GET-запроса и получение ответа в виде строки
                        var responseBody = await client.GetFromJsonAsync<Response.Rootobject>(request);
                        var schedule = responseBody.schedule;
                        var route = schedule.FirstOrDefault(o => o.time == "13:00");
                        if (route.count > 0)
                        {
                            while (true)
                            {
                                Console.Beep();
                            }
                        }
                        Console.WriteLine("resp");

                        Thread.Sleep(3000);
                    }
                    catch (HttpRequestException e)
                    {
                        Console.WriteLine($"Ошибка: {e.Message}");
                    }
                }
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
