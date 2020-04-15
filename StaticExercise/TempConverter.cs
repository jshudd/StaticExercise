using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fTemp)
        {
            double x = 5;
            double y = 9;
            var celTemp = ((fTemp - 32) * (x / y));
            return celTemp;
        }

        public static double CelsisuToFahrenheit(double cTemp)
        {
            double x = 5;
            double y = 9;
            var fahTemp = ((cTemp * (y / x)) + 32);
            return fahTemp;
        }

    }
}
