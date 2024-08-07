using System;

namespace TemperatureConversion
{
    public static class TempConverter
    {
        /// <summary>
        /// Converts Fahrenheit to Celsius.
        /// </summary>
        /// <param name="fahrenheit">The temperature in Fahrenheit.</param>
        /// <returns>The temperature in Celsius.</returns>
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            // Conversion formula: (Fahrenheit - 32) * 5/9 = Celsius
            return (fahrenheit - 32) * 5 / 9;
        }

        /// <summary>
        /// Converts Celsius to Fahrenheit.
        /// </summary>
        /// <param name="celsius">The temperature in Celsius.</param>
        /// <returns>The temperature in Fahrenheit.</returns>
        public static double CelsiusToFahrenheit(double celsius)
        {
            // Conversion formula: (Celsius * 9/5) + 32 = Fahrenheit
            return (celsius * 9 / 5) + 32;
        }
    }
}