using System;

namespace MateusViegas.GoF.AbstractFactory
{
    public interface IRefeicaoFactory
    {
        Sanduiche CriarSanduiche();
        Sobremesa CriarSobremesa();
    }
}
