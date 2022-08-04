using AutoFixture.Xunit2;
using FluentAssertions;
using ProjectToDestroy.UI.Services;

namespace ProjectToDestroy.UI.Tests.Services
{
    public class CalculationServiceShould
    {
        [Theory]
        [InlineAutoData]
        [InlineAutoData(-100)]
        public void GetSum_ReturnsTheSumOf2Numbers(int number1, int number2)
        {
            // Arrange
            var calculation = new CalculationService();

            // Act
            var result = calculation.GetSum(number1, number2);

            // Assert
            result.Should().Be(number1 + number2);
        }
    }
}