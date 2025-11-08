// See https://aka.ms/new-console-template for more information
Console.Write("Enter the temperature in Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());
double fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
