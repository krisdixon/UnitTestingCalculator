using System;
using Xunit;
using CalculatorWithTests;
using System.Linq;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(12, 2, 14)]
        [InlineData(0, 2, 2)]
        [InlineData(10000, 2, 10002)]
        [InlineData(5, 7, 12)]
        [InlineData(-1, 0, -1)]
        [InlineData(20, 20, 40)]
        [InlineData(50, 50, 100)]
        [InlineData(1, 1, 2)]
        public void Add(int addend1, int addend2, int sum)
        {
            // Arrange
            Calculator calculator1 = new Calculator();

            // Act
            int actual = calculator1.Add(addend1, addend2);

            // Assert
            Assert.Equal(sum, actual);
        }
        [Theory]
        [InlineData(6, 5, 1)]
        [InlineData(10, 5, 5)]
        [InlineData(6, 6, 0)]
        [InlineData(100, 1, 99)]
        public void Subtract(int minuend, int subtrahend, int expectedDifference)
        {
            //Arrange
            Calculator calculator1 = new Calculator();

            //Act
            int actual = calculator1.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expectedDifference, actual);
        }
        [Theory]
        [InlineData(3, 4, 12)]
        [InlineData(6, 4, 24)]
        [InlineData(7, 5, 35)]
        [InlineData(6, 0, 0)]
        [InlineData(3, -4, -12)]
        public void Multiply(int a, int b, int expectedOutcome)
        {
            //Arrange
            Calculator calculator1 = new Calculator();

            //Act
            int actual = calculator1.Multiply(a, b);

            //Assert
            Assert.Equal(expectedOutcome, actual);
        }
        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(20, 500, .04)]
        [InlineData(2, 5, .4)]
        [InlineData(25, 5, 5)]
        public void Divide(decimal dividend, decimal divisor, decimal expectedDivision)
        {
            //Arrange
            Calculator calculator1 = new Calculator();

            //Act
            decimal actual = calculator1.Divide(dividend, divisor);

            //Assert
            Assert.Equal(expectedDivision, actual);         
        }
        [Theory]
        [InlineData(4, 24)]
        [InlineData(9, 362880)]
        [InlineData(12, 479001600)]
        
        public void Factorial(long factNumber, long expectedFactorial)
        {
            //Arrange
            Calculator calculator1 = new Calculator();

            //Act
            long actual = calculator1.Factorial(factNumber);

            //Assert
            Assert.Equal(expectedFactorial, actual);

        }
        
    }
}