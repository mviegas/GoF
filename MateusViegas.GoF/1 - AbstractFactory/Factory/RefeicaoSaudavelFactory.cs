using System;

namespace MateusViegas.GoF.AbstractFactory
{
    public class RefeicaoSaudavelFactory : IRefeicaoFactory
    {
        public Sanduiche CriarSanduiche()
        {
            var sanduiche = new Chickenburguer() { Nome = "Chickenburguer" };

            sanduiche.AddIngrediente("Alface");
            sanduiche.AddIngrediente("Frango empanado");
            sanduiche.AddIngrediente("Molho Caesar");
            sanduiche.AddIngrediente("Molho Parmesão");

            return sanduiche;
        }

        public Sobremesa CriarSobremesa()
        {
            return new SaladaDeFrutas() { Descricao = "Salada de Frutas com Laranja, Maçã, Manga e Uva" };
        }
    }
}