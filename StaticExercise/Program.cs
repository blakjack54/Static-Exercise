using System;
using TemperatureConversion;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test conversion from Fahrenheit to Celsius
            double fahrenheit = 98.6;
            double celsius = TempConverter.FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit}°F is equal to {celsius:F2}°C");

            // Test conversion from Celsius to Fahrenheit
            celsius = 37.0;
            fahrenheit = TempConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C is equal to {fahrenheit:F2}°F");
            
            // Additional Tests
            TestTemperatureConversions();
        }

        static void TestTemperatureConversions()
        {
            // Example temperatures
            double[] fahrenheitTemps = { 32.0, 212.0, 68.0 };
            double[] celsiusTemps = { 0.0, 100.0, 20.0 };

            // Convert Fahrenheit to Celsius and print results
            Console.WriteLine("\nFahrenheit to Celsius:");
            foreach (var temp in fahrenheitTemps)
            {
                double converted = TempConverter.FahrenheitToCelsius(temp);
                Console.WriteLine($"{temp}°F -> {converted:F2}°C");
            }

            // Convert Celsius to Fahrenheit and print results
            Console.WriteLine("\nCelsius to Fahrenheit:");
            foreach (var temp in celsiusTemps)
            {
                double converted = TempConverter.CelsiusToFahrenheit(temp);
                Console.WriteLine($"{temp}°C -> {converted:F2}°F");
            }
        }
    }
}