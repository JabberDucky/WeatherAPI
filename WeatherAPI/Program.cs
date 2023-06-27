namespace WeatherAPI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the weather like in your city?");
            OpenWeatherMapAPI.CurrentWeather();
            Console.ReadLine();
        }
    }
}