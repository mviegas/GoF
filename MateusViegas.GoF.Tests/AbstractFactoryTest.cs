using MateusViegas.GoF.AbstractFactory;
using Xunit;

namespace MateusViegas.GoF.Tests
{
    public class AbstractFactoryTest
    {
        private IDocumentoFactory _factory;

        public AbstractFactoryTest(IDocumentoFactory factory)
        {
            _factory = factory;
        }
    }
}
