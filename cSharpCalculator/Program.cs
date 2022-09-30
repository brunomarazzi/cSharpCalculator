namespace cSharpCalculator
{
    static class Program
    {
        // First project using C#. A calculator which does the four basic operations.

        static void Main()
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("-------------------------");
                Console.WriteLine("Simple Calculator Program");
                Console.WriteLine("-------------------------");

                Console.Write("Insert the first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Insert the second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose an operation: ");
                Console.WriteLine("+ : Addition");
                Console.WriteLine("- : Subtraction");
                Console.WriteLine("* : Multiplication");
                Console.WriteLine("/ : Division");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"The result of {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"The result of {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"The result of {num1} * {num2} = {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"The result of {num1} / {num2} = {result}");
                        break;
                    default:
                        Console.WriteLine("That is not a valid option");
                        break;
                }
                Console.Write("Do you wish to make a new operation? Type 'Y' for Yes or 'N' for No:");
            } while (Console.ReadLine().ToUpper() == "Y");
 

            Console.WriteLine("Bye! Press ENTER twice to exit");
            Console.ReadKey();
        }
    }
}