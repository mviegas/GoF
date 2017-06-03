using System;
using MateusViegas.GoF.AbstractFactory;
using Xunit;

namespace MateusViegas.GoF.Tests
{
    public class AbstractFactoryTest
    {
        [Fact]
        public void AssertRefeicaoBasica()
        {
            Console.WriteLine("Testando Factory de Refeicao Basica ...");
            IRefeicaoFactory factory = new RefeicaoBasicaFactory();

            Assert.IsType(typeof(Cheeseburguer), factory.CriarSanduiche());
            Assert.IsType(typeof(Sundae), factory.CriarSobremesa());
        }

        [Fact]
        public void AssertRefeicaoSaudavel()
        {
            Console.WriteLine("Testando Factory de Refeicao Saudavel ...");
            IRefeicaoFactory factory = new RefeicaoSaudavelFactory();

            Assert.IsType(typeof(Chickenburguer), factory.CriarSanduiche());
            Assert.IsType(typeof(SaladaDeFrutas), factory.CriarSobremesa());
        }
    }
}
