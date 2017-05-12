using System;
using System.Reflection;

namespace MateusViegas.GoF.Tests
{
    public static class ObjectExtension
    {
        public static void ConsoleDisplayValeues(this object owner)
        {
            foreach (var prop in owner.GetType().GetProperties())
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(owner)}");
            }
        }

    }
}
