using System;
using System.Globalization;

namespace SimpleCalculator
{
    class Program
    {       
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Clear();

                    InputConverter inputConverter = new InputConverter();
                    CalculatorEngine calculatorEngine = new CalculatorEngine();

                    Console.WriteLine("First number:");
                    double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                    Console.WriteLine("Second number:");
                    double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                    Console.WriteLine("Operation:");
                    string operation = Console.ReadLine();

                    double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                    Console.WriteLine($"Result is: {result}");

                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    continue;
                }
            }                      
        }        
    }        
}
