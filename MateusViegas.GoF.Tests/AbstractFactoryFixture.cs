using MateusViegas.GoF.AbstractFactory;
using Moq;
using System;
using Xunit;

namespace MateusViegas.GoF.Tests
{
    public class AbstractFactoryFixture : IDisposable
    {
        private Mock<IDatabaseFactory> _dbFactory;

        public AbstractFactoryFixture()
        {
            _dbFactory.Setup(factory => factory);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
