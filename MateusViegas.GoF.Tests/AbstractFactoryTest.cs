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
            Cliente cliente = new Cliente(new RefeicaoBasicaFactory());

            Assert.IsType(typeof(Cheeseburguer), cliente.Factory.CriarSanduiche());
            Assert.IsType(typeof(Sundae), cliente.Factory.CriarSobremesa());
        }

        [Fact]
        public void AssertRefeicaoSaudavel()
        {
            Cliente cliente = new Cliente(new RefeicaoSaudavelFactory());

            Assert.IsType(typeof(Chickenburguer), cliente.Factory.CriarSanduiche());
            Assert.IsType(typeof(SaladaDeFrutas), cliente.Factory.CriarSobremesa());
        }
    }
}
