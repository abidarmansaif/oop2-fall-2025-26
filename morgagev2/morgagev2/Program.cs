// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class MortgageCalculator
{
    static void Main()
    {
        double principal = 0, annualRate, monthlyRate;
        int years, totalPayments;
        double monthlyPaymentUSD, monthlyPaymentBDT;
        const double exchangeRate = 120;

        while (true)
        {
            Console.Write("Enter your principal amount: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out principal))
            {
                Console.WriteLine("Your principal amount is: " + principal);
                break;
            }
            else
            {
                Console.WriteLine(" Invalid number! Please enter a valid amount");
            }
        }

        int creditScore = 0;
        while (true)
        {
            Console.Write("Enter your credit score (0 - 500): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out creditScore))
            {
                if (creditScore >= 0 && creditScore <= 500)
                {
                    if (creditScore < 300)
                    {
                        Console.WriteLine("Sorry, your credit score is too low");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Credit score accepted");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Credit score must be between 0 and 500");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number between 0–500");
            }
        }

        
        while (true)
        {
            Console.Write("Do you have any criminal record? (yes/no): ");
            string answer = Console.ReadLine().Trim().ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("You are not eligible for a mortgage due to criminal record");
                return; 
            }
            else if (answer == "no")
            {
                Console.WriteLine("No criminal record found. Proceeding to mortgage calculation...\n");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input! Please type 'yes' or 'no'.\n");
            }
        }


        Console.Write("Enter annual interest rate (%): ");
        annualRate = Convert.ToDouble(Console.ReadLine());
        monthlyRate = annualRate / 12 / 100;

        Console.Write("Enter loan term (years): ");
        years = Convert.ToInt32(Console.ReadLine());
        totalPayments = years * 12;

        double Value = Math.Pow(1 + monthlyRate, totalPayments);
        monthlyPaymentUSD = principal * (monthlyRate * Value) / (Value - 1);
        monthlyPaymentBDT = monthlyPaymentUSD * exchangeRate;

        CultureInfo us = new CultureInfo("bn-BD");

        Console.WriteLine("\nYour monthly payment:");
        Console.WriteLine($"USD: " + monthlyPaymentUSD.ToString("C",us ));
        Console.WriteLine($"BDT: " + monthlyPaymentBDT.ToString("N2"));

        Console.WriteLine("\nTotal payment over " + years + " years:");
        Console.WriteLine($"USD: " + (monthlyPaymentUSD * totalPayments).ToString("C",us ));
        Console.WriteLine($"BDT: " + (monthlyPaymentBDT * totalPayments).ToString("N2"));
    }
}

