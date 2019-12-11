using System;
using Xunit;


namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(10, 5, 5, 20)]
        [InlineData(7, 3, 10, 20)]
        [InlineData(9, 5, 14, 28)]
        [InlineData(3, 2, 5, 10)]
        [InlineData(20, 3, 23, 46)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Add(num1, num2, num3);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(7, 3, 4)]
        [InlineData(9, 5, 4)]
        [InlineData(3, 2, 1)]
        [InlineData(20, 3, 17)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 5, 15)]
        [InlineData(5, 5, 25)]
        [InlineData(4, 5, 20)]

        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Multiply(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(9, 3, 3)]
        [InlineData(10, 3, 3.3333)]
        [InlineData(12, 6, 2)]
        [InlineData(-17, 3, -5.6667)]
        [InlineData(0, 5, 0)]
        [InlineData(33, 25, 1.32)]
        [InlineData(17, 3, 5.6667)]
        public void Divide(decimal dividend, decimal divisor, decimal expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            // Act
            decimal actual = challenger.Divide(dividend, divisor);
            // Assert
            Assert.Equal(Math.Round(expected, 4), Math.Round(actual, 4));
        }

        [Fact]
        public void GetHello()
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            string actual = challenger.GetHello();
            //Assert
            Assert.Equal("Hello", actual);
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            string actual = challenger.GetAloha();
            //Assert
            Assert.Equal("Aloha", actual);
        }
    }
}
