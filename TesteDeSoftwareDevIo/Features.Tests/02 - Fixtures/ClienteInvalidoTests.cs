using Xunit;

namespace Features
{
    [Collection(nameof(ClienteCollection))]
    public class ClienteInvalidoTests
    {
        private readonly ClienteTestsFixture _clienteTestsFixtures;

        public ClienteInvalidoTests(ClienteTestsFixture clienteTestsFixtures)
        {
            _clienteTestsFixtures = clienteTestsFixtures;
        }

        [Fact(DisplayName = "Novo Cliente Inválido")]
        [Trait("Categoria", "Cliente Trait Testes")]
        public void Cliente_NovoCliente_DeveEstarInvalido()
        {
            var cliente = _clienteTestsFixtures.GerarClienteInvalido();

            // Act
            var result = cliente.EhValido();

            // Assert
            Assert.False(result);
            Assert.NotEmpty(cliente.ValidationResult.Errors);
        }
    }
}