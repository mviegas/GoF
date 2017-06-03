using System;

namespace MateusViegas.GoF.AbstractFactory
{
    public class Cliente
    {
        public IRefeicaoFactory Factory { get; set; }
        public Cliente(IRefeicaoFactory factory)
        {
            Factory = factory;
        }
    }
}
