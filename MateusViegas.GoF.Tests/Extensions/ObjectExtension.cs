using System;
using System.Reflection;
using Xunit.Abstractions;

namespace MateusViegas.GoF.Tests
{
    public static class ObjectExtension
    {
        public static void ConsoleDisplayValues(this object owner)
        {
            foreach (var prop in owner.GetType().GetProperties())
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(owner)}");
            }
        }

        public static void ConsoleDisplayValues(this object owner, ITestOutputHelper _output)
        {
            foreach (var prop in owner.GetType().GetProperties())
            {
                _output.WriteLine($"{prop.Name}: {prop.GetValue(owner)}");
            }
        }

    }
}
