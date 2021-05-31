using Xunit;

namespace Demo.Tests
{
    public class AssertCollectionsTests
    {
        [Fact]
        public void Funcionario_Habilidades_NaoDevePossuiorHabilidadesVazias()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Fernando", 10000);

            // Assert
            Assert.All(
                funcionario.Habilidades,
                habilidade => Assert.False(string.IsNullOrWhiteSpace(habilidade)));
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorDevePossuirHabilidadesBasicas()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Fernando", 1000);

            // Assert
            Assert.Contains("OOP", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorNaoDevePossuirHabilidadeAvancada()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Fernando", 1000);

            // Assert
            Assert.DoesNotContain("Microservices", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionario_Habilidades_SeniorDeveConterTodasHabilidades()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Fernando", 10000);

            var habilidadesSenior = new[]
            {
                "Lógica de Programação",
                "OOP",
                "Testes",
                "Microservices"
            };

            // Assert
            Assert.Equal(habilidadesSenior, funcionario.Habilidades);
        }
    }
}