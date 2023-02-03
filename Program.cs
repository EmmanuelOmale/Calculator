using System;
using System.Linq;


namespace NewCalculator
{
    class NewCalculator
    {
        public static void Main(string[] args)
        {
            do  
            {
                double Num1 = 0;
                double Num2 = 0;
                double result = 0;
                
                Console.WriteLine("..........................|");
                Console.WriteLine("A basic console calculator|");
                Console.WriteLine("..........................|");

                Console.Write("Please enter a number: ");
                Num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter a second number: ");
                Num2 = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("\t+ : Add" + "\n\t- : Subtract" + "\n\t* : Multiply" + "\n\t/ : Division");
                Console.Write("Please select an operator: ");
                
                switch (Console.ReadLine())
                {
                    case "+":
                        result = Num1 + Num2;
                        Console.WriteLine($"The product of: {Num1} + {Num2} = " + result);
                        break;

                    case "-":
                        result = Num1 - Num2;
                        Console.WriteLine($"The product of: {Num1} - {Num2} = " + result);
                        break;

                    case "*":
                        result = Num1 * Num2;
                        Console.WriteLine($"The product of: {Num1} * {Num2} = " + result);
                        break;

                    case "/":
                        result = Num1 / Num2;
                        Console.WriteLine($"The product of: {Num1} / {Num2} = " + result);
                        break;

                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.WriteLine("Do you want to perform another operation? Y or N?");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Program terminated");

        }
    }
}
