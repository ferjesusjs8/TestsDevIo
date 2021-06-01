using Xunit;

namespace Features
{
    [TestCaseOrderer("Features.PriorityOrderer", "Features.Tests")]
    public class OrdemTestes
    {
        public static bool Teste1Chamado { get; set; }
        public static bool Teste2Chamado { get; set; }
        public static bool Teste3Chamado { get; set; }
        public static bool Teste4Chamado { get; set; }

        [Fact(DisplayName = "Teste 04"), TestPriority(4)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste04()
        {
            Teste4Chamado = true;

            Assert.True(Teste3Chamado);
            Assert.True(Teste1Chamado);
            Assert.True(Teste2Chamado);
        }

        [Fact(DisplayName = "Teste 01"), TestPriority(1)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste01()
        {
            Teste1Chamado = true;

            Assert.False(Teste4Chamado);
            Assert.False(Teste3Chamado);
            Assert.False(Teste2Chamado);
        }

        [Fact(DisplayName = "Teste 03"), TestPriority(3)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste03()
        {
            Teste3Chamado = true;

            Assert.True(Teste1Chamado);
            Assert.True(Teste2Chamado);
            Assert.False(Teste4Chamado);
        }

        [Fact(DisplayName = "Teste 02"), TestPriority(2)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste02()
        {
            Teste2Chamado = true;

            Assert.True(Teste1Chamado);
            Assert.False(Teste3Chamado);
            Assert.False(Teste4Chamado);
        }
    }
}