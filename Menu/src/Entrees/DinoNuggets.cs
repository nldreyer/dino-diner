/*  DinoNuggets.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// DinoNuggets constructor
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
            this.Ingredients = new List<string>();
            for (int i = 0; i < 6; i++)
            {
                this.Ingredients.Add("Chicken Nugget");
            }
        }

        /// <summary>
        /// Adds a nugget to the ingredient list and updates price and calories
        /// </summary>
        public void AddNugget()
        {
            this.Ingredients.Add("Chicken Nugget");
            this.Price += 0.25;
            this.Calories += 59;
        }
    }
}