using System;
using Xunit;

namespace MateusViegas.GoF.Tests
{
    public class SingletonTest
    {
        [Fact]
        public void TestName()
        {
            Assert.NotNull(Singleton.TesteSingleton.Instance);
        }
    }    
}