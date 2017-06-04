using System;

namespace MateusViegas.GoF.FactoryMethod
{
    public class SanduicheFactory
    {
        public Sanduiche Create(TipoDeSanduicheEnum tipoDeSanduiche)
        {
            if (tipoDeSanduiche == TipoDeSanduicheEnum.Cheeseburguer)
            {
                return new Cheeseburguer();
            }
            
            if (tipoDeSanduiche == TipoDeSanduicheEnum.Chickenburguer)
            {
                return new Chickenburguer();
            }

            return null;
        }
    }
}