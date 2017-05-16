using MateusViegas.GoF.Builder;
using Xunit;
using Xunit.Abstractions;

namespace MateusViegas.GoF.Tests
{
    public class BuilderTest
    {
        private readonly ITestOutputHelper _output;

        public BuilderTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void OrderMain()
        {
            Combo combo = null;

            combo = PlaceOrder("M");

            Assert.NotNull(combo);

            combo.ConsoleDisplayValues(_output);
        }

        [Fact]
        public void OrderHealthy()
        {
            Combo combo = null;

            combo = PlaceOrder("H");

            Assert.NotNull(combo);

            combo.ConsoleDisplayValues(_output);
        }

        [Fact]
        public void OrderChild()
        {
            Combo combo = null;

            combo = PlaceOrder("C");

            Assert.NotNull(combo);

            combo.ConsoleDisplayValues(_output);
        }

        [Fact]
        public void OrderInexistant()
        {
            Combo combo = null;

            combo = PlaceOrder("Z");

            Assert.Null(combo);

            _output.WriteLine("An inexistant combo was ordered.");
        }

        private Combo PlaceOrder(string input)
        {
            Waiter water = new Waiter();
            IComboBuilder builder;

            if (input == "M")
            {
                builder = new MainComboBuilder();
                water.OrderCombo(builder);
                return builder.Combo;
            }
            else if (input == "C")
            {
                builder = new ChildComboBuilder();
                water.OrderCombo(builder);
                return builder.Combo;
            }
            else if (input == "H")
            {
                builder = new HealthyComboBuilder();
                water.OrderCombo(builder);
                return builder.Combo;
            }

            return null;
        }
    }
}
