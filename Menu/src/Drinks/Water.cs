/*  Water.cs
*   Author: Nicholas Dreyer
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        public bool Lemon { get; set; } = false;
        
        /// <summary>
        /// Water constructor
        /// </summary>
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;
            this.Size = Size.Small;
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if(Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Adds lemon to ingredients list
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        /// <summary>
        /// Sets Ice property to false
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return Size + " Water";
        }
    }
}
