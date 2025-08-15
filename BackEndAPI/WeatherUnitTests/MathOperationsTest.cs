using Xunit;
using BackEndAPI.Interfaces;
using BackEndAPI.Implementations;

namespace WeatherUnitTests
{
    public class MathOperationsTest
    {
        private readonly IMathOperations _mathOperations = new MathOperations();

        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            var result = _mathOperations.Add(3, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            var result = _mathOperations.Subtract(5, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct()
        {
            var result = _mathOperations.Multiply(4, 2.5);
            Assert.Equal(10, result);
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient()
        {
            var result = _mathOperations.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ReturnsNaN()
        {
            var result = _mathOperations.Divide(10, 0);
            Assert.True(double.IsNaN(result));
        }
    }
}