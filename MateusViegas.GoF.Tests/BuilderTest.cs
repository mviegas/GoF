using MateusViegas.GoF.Builder;
using System;
using System.Reflection;
using Xunit;

namespace MateusViegas.GoF.Tests
{
    public class BuilderTest
    {
        [Fact]
        public void BuildRG()
        {
            //Arrange
            var builder = new RGBuilder()
                .NomeCompleto("Adriano Leite Ribeiro")
                .Numero("21345678910")
                .DataNascimento(new DateTime(1990, 01, 01))
                .DataExpedicao(new DateTime(1990, 01, 01))
                .DataValidade(null)
                .Pai("Jose Ribeiro")
                .Mae("Maria Leite")
                .OrgaoExpedidor("DIC")
                .UF("RJ");

            //Act
            var rg = builder.Build();

            rg.ConsoleDisplayValeues();

            //Assert
            Assert.IsType<RG>(rg);            
        }
    }
}
