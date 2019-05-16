using NUnit.Framework;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Calculator_Adds_Two_Numbers_Together()
        {
            // Arrange
            var expected = 4;

            // Act
            var actual = Calculator.Add(2, 2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}