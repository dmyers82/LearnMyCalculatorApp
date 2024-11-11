using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnMyCalculatorApp;
//using FluentAssertions;

namespace LearnMyCalculatorApp.Test
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();
            Assert.IsNotNull(calculator);
        }

        [TestMethod]
        public void AddTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Add(1, 1);
            var subtractActual = calculator.Subtract(actual, 1) == 1;

            // Assert
            Assert.IsNotNull(calculator);
            Assert.AreEqual(2, actual);
            Assert.IsTrue(subtractActual);
            StringAssert.Contains(actual.ToString(), "2");
        }

        [TestMethod]
        public void SubtractTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Subtract(1, 1);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Multiply(2, 2);

            // Assert
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void DivideTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(25, 5);

            // Assert
            Assert.AreEqual(5, actual);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 6)]
        [DataRow(0, 0, 1)] // The test run with this row fails
        public void AddDataTests(int x, int y, int expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Add(x, y);
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void AddTestFluentassertion()
        //{
        //    var calculator = new Calculator();
        //    var actual = calculator.Add(1, 1);

        // Non-fluent asserts:
        // Assert.AreEqual(actual, 2);
        // Assert.AreNotEqual(actual, 1);

        // Same asserts as what is commented out above, but using Fluent Assertions
        //    actual.Should().Be(2).And.NotBe(1);
        //}

    }
}