namespace MenuDriven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opp = 0;
            while (opp != 5)
            {
                Console.WriteLine("Enter Operation to be performed:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Your choice: ");

                opp = Convert.ToInt32(Console.ReadLine());

                if (opp == 5)
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }

                if (opp < 1 || opp > 5)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    continue;
                }

                Console.Write("Enter First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (opp)
                {
                    case 1:
                        Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            Console.WriteLine($"Result: {num1} / {num2} = {(double)num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                }

                Console.WriteLine(); // Add a blank line for better readability
            }
        }
    }
}
