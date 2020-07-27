using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string operation, double firstNumber, double secondNumber)
        {          
            double result;

            switch (operation.ToLower())
            {
                case "add":
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "subtract":
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "multiply":
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "divide":
                case "/":
                    if (secondNumber == 0)
                    {
                        throw new InvalidOperationException("Cannot divide by '0'!");                        
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                    }
                    break;
                default:
                    throw new InvalidOperationException("Uknown operation.");
            }

            /*
            if (operation.ToLower() == "add" || operation.ToLower() == "+")
            {
                result = Math.Round((firstNumber + secondNumber), 2);                
            }
            else if (operation.ToLower() == "subtract" || operation.ToLower() == "-")
            {
                result = firstNumber - secondNumber;                
            }
            else if (operation.ToLower() == "multiply" || operation.ToLower() == "*")
            {
                result = firstNumber * secondNumber;                
            }
            else if (operation.ToLower() == "divide" || operation.ToLower() == "/")
            {
                result = firstNumber / secondNumber;                 
            }
            else
            {
                throw new InvalidOperationException("Specified operation is not recognized");
            }
            */

            return result;
        }
    }
}
