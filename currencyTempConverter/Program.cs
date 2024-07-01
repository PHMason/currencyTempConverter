using System;

namespace CurrencyTemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a converter:");
            Console.WriteLine("1. Currency Converter");
            Console.WriteLine("2. Temperature Converter");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CurrencyConverter();
                    break;
                case "2":
                    TemperatureConverter();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static void CurrencyConverter()
        {
            Console.WriteLine("Currency Converter");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Pounds to Euros");
            Console.WriteLine("2. Euros to Pounds");
            string choice = Console.ReadLine();

            Console.WriteLine("Enter the amount:");
            double amount = Convert.ToDouble(Console.ReadLine());
            double result = 0;

            switch (choice)
            {
                case "1":
                    result = PoundsToEuros(amount);
                    Console.WriteLine($"{amount} Pounds is {result} Euros");
                    break;
                case "2":
                    result = EurosToPounds(amount);
                    Console.WriteLine($"{amount} Euros is {result} Pounds");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static double PoundsToEuros(double pounds)
        {
            return pounds * 1.17; // Example conversion rate
        }

        static double EurosToPounds(double euros)
        {
            return euros * 0.85; // Example conversion rate
        }

        static void TemperatureConverter()
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            string choice = Console.ReadLine();

            Console.WriteLine("Enter the temperature:");
            double temperature = Convert.ToDouble(Console.ReadLine());
            double result = 0;

            switch (choice)
            {
                case "1":
                    result = CelsiusToFahrenheit(temperature);
                    Console.WriteLine($"{temperature} Celsius is {result} Fahrenheit");
                    break;
                case "2":
                    result = FahrenheitToCelsius(temperature);
                    Console.WriteLine($"{temperature} Fahrenheit is {result} Celsius");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}