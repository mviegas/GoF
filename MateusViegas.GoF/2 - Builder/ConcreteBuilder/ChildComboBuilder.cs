using System;
using System.Collections.Generic;
using System.Text;

namespace MateusViegas.GoF.Builder
{
    public class ChildComboBuilder : IComboBuilder
    {
        public Combo Combo { get; set; }

        public ChildComboBuilder()
        {
            Combo = new Combo("Child Combo");
        }

        public void AddDrink()
        {
            Combo.Drink = DrinkEnum.OrangeJuice;
        }

        public void AddMainDish()
        {
            Combo.MainDish = MainDishEnum.ChickenNuggets;
        }

        public void AddSideDish()
        {
            Combo.SideDish = SideDishEnum.Fries;
        }

        public void AddDessert()
        {
            Combo.Dessert = DessertEnum.IceCream;
        }
    }
}
