using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    class Tyrannotea : Drink
    {
        private Size size = Size.Small;
        public bool Sweet = false;
        public bool Lemon = false;

        public Tyrannotea()
        {
            this.Price = 0;
            this.Calories = 0;
            this.Ingredients = new List<string>() { };
        }

        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 0;
                        this.Calories = 0;
                        break;
                    case Size.Medium:
                        this.Price = 0;
                        this.Calories = 0;
                        break;
                    case Size.Large:
                        this.Price = 0;
                        this.Calories = 0;
                        break;
                }
            }
        }
    }
}
