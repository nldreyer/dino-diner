/*  DinoNuggets.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
    {
        private int extraNuggets = 0;

        /// <summary>
        /// DinoNuggets constructor
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < 6 + extraNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Adds a nugget to the ingredient list and updates price and calories
        /// </summary>
        public void AddNugget()
        {
            this.extraNuggets++;
            this.Price += 0.25;
            this.Calories += 59;
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}