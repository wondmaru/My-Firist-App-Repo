using System;
namespace Lessons
{
    public static class Utilities
    {
        public static double CelsiusToFahrenheit(string temperature)
	{
		double celsius = Double.Parse(temperature);
		double fahrenheit = (celsius * 9 / 5) + 32;
		return fahrenheit;
	}
	public static double FahrenheitToCelsius(string temperature)
	{
		double fahrenheit = Double.Parse(temperature);
		double celsius = (fahrenheit  - 32) * 5 / 9;
		return celsius ;
	}

    }
}