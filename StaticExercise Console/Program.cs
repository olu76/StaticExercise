using System;

namespace StaticExercise_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(40);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(60);

            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
