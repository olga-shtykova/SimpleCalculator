using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string userInput)
        {    
            if (!double.TryParse(userInput, out double convertedNumber))
            {
                throw new ArgumentException("Expected a numeric value");
            }           

            return convertedNumber;
        }
    }
}
