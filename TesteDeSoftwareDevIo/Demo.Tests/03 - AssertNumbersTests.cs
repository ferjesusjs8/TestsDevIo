using Xunit;

namespace Demo.Tests
{
    public class AssertNumbersTests
    {
        [Fact]
        public void Calculadora_Somar_DeveSerIgual()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var result = calculadora.Somar(1, 2);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Calculadora_Somar_NaoDeveSerIgual()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var result = calculadora.Somar(2.11231, 1.1231412);

            // Assert
            Assert.NotEqual(3.3, result, 1);
        }
    }
}