namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculator Program\n");

            do
            {
                double num1 = 0, num2 = 0, result = 0;

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("\nEnter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"\nYour result: {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"\nYour result: {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"\nYour result: {num1} * {num2} = {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"\nYour result: {num1} / {num2} = {result}");
                        break;
                    default:
                        Console.WriteLine("Enter a valid option such as +, -, *, /.");
                        break;
                }
                Console.Write("\nWould you like to continue? (Y = yes, N = No): ");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Thanks for using my calculator");
            Console.ReadKey();
        }
    }
}
