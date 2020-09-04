using System;
using System.Collections.Generic;
using System.Text;

namespace TempConverter
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var resultOne = (fahrenheit - 32) / 1.8;
            return resultOne;
        }
    
        public static double CelsiusToFahrenheit(double celsius)
        {
            var resultTwo =  (celsius * 9) / 5 + 32;
            return resultTwo;
        }
    }
}
