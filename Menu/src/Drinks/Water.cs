using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
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
            this.Ingredients = new List<string>() { "Water" };
        }

        /// <summary>
        /// Adds lemon
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            this.Ingredients.Add("Lemon");
        }

        /// <summary>
        /// Holds ice
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
