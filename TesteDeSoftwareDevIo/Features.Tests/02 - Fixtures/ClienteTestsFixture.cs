using Features.Clientes;
using System;
using Xunit;

namespace Features
{
    [CollectionDefinition(nameof(ClienteCollection))]
    public class ClienteCollection : ICollectionFixture<ClienteTestsFixture> {}

    public class ClienteTestsFixture : IDisposable
    {
        public Cliente GerarClienteValido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "Fernando",
                "Santos",
                DateTime.Now.AddYears(-31),
                "fernando@fer.com",
                true,
                DateTime.Now);

            return cliente;
        }
        public Cliente GerarClienteInvalido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "",
                "",
                DateTime.Now,
                "fernando@fer.com",
                true,
                DateTime.Now);


            return cliente;
        }

        public void Dispose()
        {
        }
    }
}