// See https://aka.ms/new-console-template for more information
using System;

class Calculator
{
    static void Main()
    {



        bool calculate = true;
        do
        {
            Console.WriteLine("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Operation");
            Console.WriteLine("Enter operation");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Exit");



            int choice = Convert.ToInt32(Console.ReadLine());
            double result = 0;

            if (choice == 5)
            {
                calculate = false;
                break;
            }
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case 3:
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Error! Division by zero.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }



        } while (calculate);

        Console.WriteLine("Thank you for using the calculator!");
    }
}

