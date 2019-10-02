/*  Sodasaururs.cs
*   Author: Nicholas Dreyer
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        private SodasaurusFlavor flavor;
        private Size size = Size.Small;

        /// <summary>
        /// Sodasaurus constructor
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
            this.Ice = true;
            this.Ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
        }

        /// <summary>
        /// Gets and sets Size property and updates price and calories
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 1.50;
                        this.Calories = 112;
                        break;
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
                        break;
                    case Size.Large:
                        this.Price = 2.50;
                        this.Calories = 208;
                        break;
                }
            }
        }

        /// <summary>
        /// Gets and sets Flavor property
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
            }
        }

        /// <summary>
        /// Sets Ice property to false
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
