﻿using System;
using Xunit;

namespace Demo.Tests
{
    public class AssertExceptionsTests
    {
        [Fact]
        public void Calculadora_Dividir_DeveRetornarErroDivisaoPorZero()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
        }

        [Fact]
        public void Funcionario_Salario_DeveRetornarErroSalarioInferiorPermitido()
        {
            // Arrange & Act & Assert
            var exception = Assert.Throws<Exception>(() => FuncionarioFactory.Criar("Fernando", 499));

            Assert.Equal("Salário inferior ao permitido por lei.", exception.Message);


        }
    }
}