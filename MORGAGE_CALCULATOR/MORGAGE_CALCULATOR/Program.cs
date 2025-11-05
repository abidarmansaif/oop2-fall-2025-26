// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class Mortgagecalculator
{
    static void Main()
    {
        Console.WriteLine("Enter loan amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter annual interest rate (in %): ");
        double annualRate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter loan term (in years): ");
        int years = Convert.ToInt32(Console.ReadLine());

        double monthlyRate = annualRate / 100 / 12;
        int totalMonths = years * 12;

        double monthlyPayment = principal * (monthlyRate * Math.Pow(1 + monthlyRate, totalMonths)) / (Math.Pow(1 + monthlyRate, totalMonths) - 1);
        double totalPaid = monthlyPayment * totalMonths;
        double totalInterest = totalPaid - principal;
        Console.WriteLine($"\nMonthly Payment: {monthlyPayment:C}");
        Console.WriteLine($"Total Payment: {totalPaid:C}");
        Console.WriteLine($"Total Interest: {totalInterest:C}");

        CultureInfo bdCulture = new CultureInfo("bn-BD");
        Console.WriteLine($"\nMonthly Payment : {monthlyPayment.ToString("C", bdCulture)}");
        Console.WriteLine($"Total paid: {totalPaid.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");
    }
}

