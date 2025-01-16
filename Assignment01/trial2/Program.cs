using System;

namespace trial2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter First Number,Second Number,Operation You Want To Perform: (+, -, /, *)");
            int num1 = int.Parse(args[0]);
            int num2 = int.Parse(args[1]);
            char operation = char.Parse(args[2]);

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;

                case '-':
                    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                    break;

                case '*':
                    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {num1} / {num2} = {(double)num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Error: Invalid operation. Please use +, -, /, or *.");
                    break;
            }


        }
    }
}

