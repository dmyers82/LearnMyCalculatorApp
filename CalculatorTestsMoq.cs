using LearnMyCalculatorApp;
using Moq;

namespace LearnMyCalculatorAppTestMoq
{
    public class CalculatorTestsMoq
    {
        [Fact]
        public void AddTestMoq()
        {
            // Arrange
            var calc = new Mock<ICalculator>();
            calc.Setup(c => c.Add(1, 1));

            // Act
            var actualcalc = calc.Object;

            // Assert
            Assert.True(actualcalc is Calculator);
        }
    }
}