using ProjetoTeste;
using System;
using Xunit;

namespace TesteXUnit
{
    public class TesteXUnit
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            double pNum = 1;
            double sNum = 1;

            var resultado = Operacoes.Somar(pNum, sNum);

            Assert.Equal(2, resultado);
        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 5)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double tNum)
        {
            var resultado = Operacoes.Somar(pNum, sNum);
            Assert.Equal(tNum, resultado);
        }
    }
}
