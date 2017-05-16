using System;
using System.Collections.Generic;
using System.Text;

namespace MateusViegas.GoF.Builder
{
    public class MainComboBuilder : IComboBuilder
    {
        public Combo Combo { get; set; }

        public MainComboBuilder()
        {
            Combo = new Combo("Main Combo");
        }

        public void AddDrink()
        {
            Combo.Drink = DrinkEnum.Coke;
        }

        public void AddMainDish()
        {
            Combo.MainDish = MainDishEnum.Hamburger;
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
