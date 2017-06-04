using System;
using MateusViegas.GoF.FactoryMethod;
using Xunit;

namespace MateusViegas.GoF.Tests
{
    public class FactoryTest
    {
        [Fact]
        public void CreateCheeseburguer()
        {
            var sanduiche = 
                new SanduicheFactory().Create(TipoDeSanduicheEnum.Cheeseburguer);

            Assert.IsAssignableFrom(typeof(Sanduiche), sanduiche);
            Assert.IsType(typeof(Cheeseburguer), sanduiche);
        }

        [Fact]
        public void CreateChickenburguer()
        {
            var sanduiche = 
                new SanduicheFactory().Create(TipoDeSanduicheEnum.Chickenburguer);

            Assert.IsAssignableFrom(typeof(Sanduiche), sanduiche);
            Assert.IsType(typeof(Chickenburguer), sanduiche);
        }
    }
}
