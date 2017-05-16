using System;
using System.Collections.Generic;
using System.Text;

namespace MateusViegas.GoF.Builder
{
    public class Combo
    {
        private string _name;

        public Combo(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }

        public DrinkEnum Drink { get; set; }
        public MainDishEnum MainDish { get; set; }
        public SideDishEnum SideDish { get; set; }
        public DessertEnum Dessert { get; set; }
    }
}