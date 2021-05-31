using Xunit;

namespace Demo.Tests
{
    public class AssertStringsTests
    {
        [Fact]
        public void StringsTools_UnirNomes_RetornarNomeCompleto()
        {
            // Arrange
            var stringTools = new StringsTools();

            // Act
            var nomeCompleto = stringTools.Unir("Fernando", "Santos");

            // Assert
            Assert.Equal("Fernando Santos", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveIgnorarCase()
        {
            // Arrange
            var stringTools = new StringsTools();

            // Act
            var nomeCompleto = stringTools.Unir("Fernando", "Santos");

            // Assert
            Assert.Equal("FERNANDO SANTOS", nomeCompleto, true);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveConterTrecho()
        {
            // Arrange
            var stringTools = new StringsTools();

            // Act
            var nomeCompleto = stringTools.Unir("Fernando", "Santos");

            // Assert
            Assert.Contains("nando", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveComecarCom()
        {
            // Arrange
            var stringTools = new StringsTools();

            // Act
            var nomeCompleto = stringTools.Unir("Fernando", "Santos");

            // Assert
            Assert.StartsWith("Fer", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveAcabarCom()
        {
            // Arrange
            var stringTools = new StringsTools();

            // Act
            var nomeCompleto = stringTools.Unir("Fernando", "Santos");

            // Assert
            Assert.EndsWith("tos", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_ValidarExpressaoRegular()
        {
            // Arrange
            var stringTools = new StringsTools();

            // Act      
            var nomeCompleto = stringTools.Unir("Fernando", "Santos");

            // Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);
        }
    }
}