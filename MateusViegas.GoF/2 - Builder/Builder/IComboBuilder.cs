using System;
using System.Collections.Generic;
using System.Text;

namespace MateusViegas.GoF.Builder
{
    public interface IComboBuilder
    {
        Combo Combo { get; set; }

        void AddDrink();

        void AddMainDish();

        void AddSideDish();

        void AddDessert();
    }
}
