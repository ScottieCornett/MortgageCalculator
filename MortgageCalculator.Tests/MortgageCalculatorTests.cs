namespace MortgageCalculator.Tests
{
    public class MortgageCalculatorTests
    {
        [Fact]
        public void CalculateMortgage_WhenCalled_ReturnsValid()
        {
            // Arrange
            var calculator = new MortgageCalculator(100000, 5, 20);

            // Act
            var actual = calculator.CalculateMortgage();
            var expected = 659.9506501597751;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateBalance_WhenCalled_ReturnsValid()
        {

            // Arange
            var calculator = new MortgageCalculator(100000, 5, 20);
            short numberOfPaymentsMade = 20;

            // Act
            var actual = calculator.CalculateBalance(numberOfPaymentsMade);
            var expected = 94936.74951200743;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetNumberOfPayments_WhenCalled_ReturnsValid()
        {
            // Arrange
            var calculator = new MortgageCalculator(1, 1, 1);

            // Act
            var actual = calculator.GetNumberOfPayments();
            var expected = 12;

            //
            Assert.Equal(actual, expected);

        }
    }
}