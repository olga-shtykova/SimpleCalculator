using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultsForNonSymbolOperation()
        {
            // Arrange
            int number1 = 1;
            int number2 = 2;

            // Act
            double result = _calculatorEngine.Calculate("add", number1, number2);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultsForSymbolOperation()
        {
            // Arrange
            int number1 = 1;
            int number2 = 2;

            // Act
            double result = _calculatorEngine.Calculate("+", number1, number2);

            // Assert
            Assert.AreEqual(3, result);
        }
    }
}
