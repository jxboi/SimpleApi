using System;
using Xunit;
using SimpleApi.Controllers;

namespace SimpleApi.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        
        [Fact]
        public void GetReturnsByName()
        {
            var returnValue = controller.Get();
            var temp = ((SimpleApi.WeatherForecast[])returnValue)[0].TemperatureC;
            Console.WriteLine($"value: {temp}");
             
            Assert.IsType(typeof(string), temp);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
