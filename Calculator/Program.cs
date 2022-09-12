using System.Diagnostics.Metrics;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                

                PrintMenu();

                int userPick = AskUserForNumber("menu selection");

  

                switch (userPick)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Addition selected");
                        Console.WriteLine("Type in augend");
                        double number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Type in addend");
                        double number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("When adding " + number1 + " and " + number2 + " the sum is: " + addition(number1, number2));
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Subtraction selected");
                        Console.WriteLine("Type in minuend");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Type in subtrahend");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("When subtracting " + number1 + " and " + number2 + " the difference is: " + subtraction(number1, number2));
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Multiplication selected");
                        Console.WriteLine("Type in multiplicand");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Type in multiplier");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("When multiplying " + number1 + " and " + number2 + " the product is: " + multiplication(number1, number2));
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Division selected");
                        Console.WriteLine("Type in dividend");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Type in divisor");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("When dividing " + number1 + " and " + number2 + " the quotient is: " + division(number1, number2));
                        break;

                    case 9:
                        Console.WriteLine("Shutting down calculator ");
                        keepLooping = false;
                        break;

                    default: 
                        Console.WriteLine("No match found");
                        break;


                }

                static void PrintMenu()
                {
                    Console.WriteLine("----- Calculator -----");
                    Console.WriteLine("1: Addition");
                    Console.WriteLine("2: Subtraction");
                    Console.WriteLine("3: Multiplication");
                    Console.WriteLine("4: Division");
                    Console.WriteLine("9: Exit program");
                }

                static string? AskUserFor(string what)
                {
                    Console.Write("Please enter " + what + ": ");
                    return Console.ReadLine();
                }

                static int AskUserForNumber(string what)
                {
                    string? inputed = AskUserFor(what);

                    int number = Convert.ToInt32(inputed);

                    return number;
                }

                static double addition(double nr1, double nr2)
                {
                    double sum = nr1 + nr2;
                    return sum;

                }

                static double subtraction(double nr1, double nr2)
                {
                    double difference = nr1 - nr2;
                    return difference;

                }

                static double multiplication(double nr1, double nr2)
                {
                    double product = nr1 * nr2;
                    return product;

                }

                static double division(double nr1, double nr2)
                {
                    double quotient = nr1 / nr2;
                    return quotient;

                }

            }
        }
    }
}