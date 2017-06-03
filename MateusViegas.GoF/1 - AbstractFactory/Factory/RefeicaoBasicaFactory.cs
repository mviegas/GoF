using System;

namespace MateusViegas.GoF.AbstractFactory
{
    public class RefeicaoBasicaFactory : IRefeicaoFactory
    {
        public Sanduiche CriarSanduiche()
        {
            var sanduiche = new Cheeseburguer() { Nome = "Cheeseburguer" };

            sanduiche.AddIngrediente("Picles");
            sanduiche.AddIngrediente("Hamburguer simples");
            sanduiche.AddIngrediente("Queijo cheddar");
            sanduiche.AddIngrediente("Ketchup");

            return sanduiche;
        }

        public Sobremesa CriarSobremesa()
        {
            return new Sundae() { Descricao = "Sundae de Morango" };
        }
    }
}
