using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTeste;

namespace TestMSTest
{
    [TestClass]
    public class TesteMSTeste
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //arrange - organizar
            double pNum = 1;
            double sNum = 1;

            //act - agir
            var resultado = Operacoes.Somar(pNum, sNum);

            //assert - verificar 
            Assert.AreEqual(2, resultado);

        }

        //atribuindo mais valores para teste
        [DataTestMethod]
        //vai somar 1 + 1 = 2
        [DataRow(1, 1, 2)]
        //vai somar 2 + 2 = 4
        [DataRow(2, 2, 4)]
        //vai somar 1 + 2 = 3
        [DataRow(1, 2, 3)]

        //método que irá somar os valores
        public void SomarDoisNumerosLista(double pNum, double sNum, double tNum)
        {
            var resultado = Operacoes.Somar(pNum, sNum);

            Assert.AreEqual(tNum, resultado);
        }
    }
}
