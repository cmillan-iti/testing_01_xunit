namespace UnitTestDemo.Features.DateUtils
{
    public class WeatherService
    {        
        public decimal ConvertCelsiusToFarhenheit(decimal celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
