using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertValidStringInputIntoDouble()
        {
            // Arrange
            string inputNumber = "7";

            // Act
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);

            // Assert
            Assert.AreEqual(7, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailToConvertInvalidStringInputIntoDouble()
        {
            // Arrange
            string inputNumber = "hgdfkhf";

            // Act
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);

        }
    }
}
