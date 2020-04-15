using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature in F you want to convert?");
            double fahTemp = Convert.ToDouble(Console.ReadLine());
            double convertToCel = Convert.ToDouble(TempConverter.FahrenheitToCelsius(fahTemp));


            Console.WriteLine($"That equals {convertToCel} degrees Celsius");
            Console.WriteLine();

            Console.WriteLine("What is the temperature in Celsius you want to convert?");
            double celTemp = Convert.ToDouble(Console.ReadLine());
            double convertToFah = Convert.ToDouble(TempConverter.CelsisuToFahrenheit(celTemp));

            Console.WriteLine($"That equals {convertToFah} degrees Fahrenheit");
            Console.WriteLine();
        }
    }
}
