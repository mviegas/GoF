using System;
using System.Collections.Generic;
using System.Text;

namespace MateusViegas.GoF.Builder
{
    public class Waiter
    {
        public void OrderCombo(IComboBuilder builder)
        {
            builder.AddDrink();
            builder.AddMainDish();
            builder.AddSideDish();
            builder.AddDessert();
        }
    }
}
