using System;

namespace TempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's convert a temperature form Fahrenheit to Celsius, then vice-versa");
            Console.WriteLine("First, we'll convert a Fahrenheit temperature:");
            var celsius = TempConverter.FahrenheitToCelsius(78);
            Console.WriteLine($"After conversion that comes out to {celsius} degrees C");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Now we'll convert a celsius temperature:");
            var fahrenheit = TempConverter.CelsiusToFahrenheit(18);
            Console.WriteLine($"This comes out to {fahrenheit} degrees F");
        }
    }
}
