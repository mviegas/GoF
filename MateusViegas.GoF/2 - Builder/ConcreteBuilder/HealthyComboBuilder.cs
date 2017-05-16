using System;
using System.Collections.Generic;
using System.Text;

namespace MateusViegas.GoF.Builder
{
    public class HealthyComboBuilder : IComboBuilder
    {
        public Combo Combo { get; set; }

        public HealthyComboBuilder()
        {
            Combo = new Combo("Healthy Combo");
        }

        public void AddDrink()
        {
            Combo.Drink = DrinkEnum.OrangeJuice;
        }

        public void AddMainDish()
        {
            Combo.MainDish = MainDishEnum.Salad;
        }

        public void AddSideDish()
        {
            Combo.SideDish = SideDishEnum.RostiePotato;
        }

        public void AddDessert()
        {
            Combo.Dessert = DessertEnum.ApplePie;
        }
    }
}
