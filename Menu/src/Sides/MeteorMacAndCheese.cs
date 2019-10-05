/*  MeteorMacAndCheese.cs
*   Author: Nicholas Dreyer
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MeteorMacAndCheese : Side
    {
        private Size size;

        /// <summary>
        /// MeteorMacAndCheese constructor
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Price = 0.99;
            this.Calories = 420;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
            }
        }

        /// <summary>
        /// Gets and sets size
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
                        this.Price = 0.99;
                        this.Calories = 420;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 490;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 520;
                        break;
                }
            }
        }
        
        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return Size + " Meteor Mac and Cheese";
        }
    }
}
