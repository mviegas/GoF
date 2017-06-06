using System;

namespace MateusViegas.GoF
{
    public static class ObjectExtension
    {
        public static bool IsNull(this Object owner)
        {
            return owner == null;
        }
    }
}