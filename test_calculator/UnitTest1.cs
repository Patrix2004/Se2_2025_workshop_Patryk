using Xunit;
using calc;  

namespace test_calculator
{
    public class CalcTests
    {
        [Fact]
        public void Calc_ReturnsZero_ForEmptyString()
        {
            // Arrange
            var calculator = new Calc();

            // Act
            int result = calculator.calc("");

            // Assert
            Assert.Equal(0, result);  
        }

        [Fact]
        public void Calc_ReturnsOne_ForElse()
        {
            // Arrange
            var calculator = new Calc();

            // Act
            int result = calculator.calc("test");

            // Assert
            Assert.Equal(1, result); 
        }
        [Fact]
        public void Calc_ReturnsOneNumber()
        {
            // Arrange
            var calculator = new Calc();

            // Act
            int result = calculator.calc("5");

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Calc_Addition1()
        {
            // Arrange
            var calculator = new Calc();

            // Act
            int result = calculator.calc("5,3");

            // Assert
            Assert.Equal(8, result);
        }
        [Fact]
        public void Calc_Addition_with_one_greater_than_1000()
        {
            // Arrange
            var calculator = new Calc();

            // Act
            int result = calculator.calc("5,1001");

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Calc_Addition3()
        {
            // Arrange
            var calculator = new Calc();

            // Act
            int result = calculator.calc("5,3,3");

            // Assert
            Assert.Equal(11, result);
        }

        [Fact]
        public void Calc_Addition4()
        {
            // Arrange
            var calculator = new Calc();

            // Act
            int result = calculator.calc("5\n3\n3");

            // Assert
            Assert.Equal(11, result);
        }

        [Fact]
        public void Calc_Addition2()
        {
            // Arrange
            var calculator = new Calc();

            // Act
            int result = calculator.calc("5\n3");

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Calc_ThrowsException_ForNegativeNumber()
        {
            // Arrange
            var calculator = new Calc();

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => calculator.calc("-3"));
            Assert.Equal("cant be negative.", exception.Message);
        }
    }
}
