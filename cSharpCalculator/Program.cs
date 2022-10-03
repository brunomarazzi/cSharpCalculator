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

                Console.WriteLine("\t\t\t\t-------------------------");
                Console.WriteLine("\t\t\t\tSimple Calculator Program");
                Console.WriteLine("\t\t\t\t-------------------------");

                bool valid = false;
                Console.Write("Insert the first number: ");
                valid = double.TryParse(Console.ReadLine(), out num1);

                while (!valid)
                {
                    Console.Write("Please insert a valid number: ");
                    valid = double.TryParse(Console.ReadLine(), out num1);
                }

                // https://stackoverflow.com/questions/18671774/c-sharp-allow-user-to-input-again-until-correct

                Console.WriteLine("\tChoose an operation: ");
                Console.WriteLine("\t+ : Addition");
                Console.WriteLine("\t- : Subtraction");
                Console.WriteLine("\t* : Multiplication");
                Console.WriteLine("\t/ : Division");
                string operation = Console.ReadLine();
                // validar aqui se a opção foi válida              

                Console.Write("Insert the second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                switch (operation)
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
 

            Console.WriteLine("Press ENTER twice to exit");
            Console.ReadKey();
        }
    }
}