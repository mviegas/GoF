using System;

namespace MateusViegas.GoF.Singleton
{
    public class TesteSingleton
    {
        private static TesteSingleton _instance = null;

        public static TesteSingleton Instance
        {
            get
            {
                if (_instance.IsNull())
                    return new TesteSingleton();

                return _instance;
            }
        }
    }
}