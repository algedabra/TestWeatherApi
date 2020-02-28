using System;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Forecast();
            Console.ReadKey();
        }

        public static async Task Forecast()
        {
            var apiKey = "2362fdd674b94c0c3541af74ebfe2eff";
            var darkSky = new DarkSky.Services.DarkSkyService(apiKey);
            var forecast = await darkSky.GetForecast(52.99042, 8.81614);

            if (forecast?.IsSuccessStatus == true)
            {
                Console.WriteLine(forecast.Response.Currently.Summary);
            }
            else
            {
                Console.WriteLine("No current weather data");
            }
            Console.WriteLine(forecast.AttributionLine);
            Console.WriteLine(forecast.DataSource);
        }
    }
}