using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        private Size size = Size.Small;
        public bool Sweet { get; set; } = false;
        public bool Lemon { get; set; } = false;

        public Tyrannotea()
        {
            this.Price = 0;
            this.Calories = 0;
            this.Ingredients = new List<string>() { "Water", "Tea" };
            if (Sweet)
            {
                this.Ingredients.Add("Cane Sugar");
            }
            if (Lemon)
            {
                this.Ingredients.Add("Lemon");
            }
        }

        /// <summary>
        /// Holds ice
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }

        /// <summary>
        /// Adds lemon
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
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
                        this.Price = 0.99;
                        this.Calories = 8;
                        break;
                    case Size.Medium:
                        this.Price = 1.49;
                        this.Calories = 16;
                        break;
                    case Size.Large:
                        this.Price = 1.99;
                        this.Calories = 32;
                        break;
                }
                if (Sweet)
                {
                    this.Calories *= 2;
                }
            }
        }
    }
}
