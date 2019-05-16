using NUnit.Framework;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 2)]
        [TestCase(3, 4)]
        [TestCase(5, 6)]
        [TestCase(7, 8)]
        [TestCase(9, 10)]
        public void Calculator_Adds_Two_Numbers_Together(int x, int y)
        {
            // Arrange
            var expected = x + y;

            // Act
            var actual = Calculator.Add(x, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}