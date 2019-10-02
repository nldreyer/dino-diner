/*  VelociWrap.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        /// <summary>
        /// VelociWrap constructor
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
            this.Ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast", "Ceasar Dressing",
                                                    "Romaine Lettuce", "Parmesan Cheese" };
        }

        /// <summary>
        /// Removes dressing from ingredients list
        /// </summary>
        public void HoldDressing()
        {
            this.Ingredients.Remove("Ceasar Dressing");
        }

        /// <summary>
        /// Removes lettuce from ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.Ingredients.Remove("Romaine Lettuce");
        }

        /// <summary>
        /// Removes cheese from ingredients list
        /// </summary>
        public void HoldCheese()
        {
            this.Ingredients.Remove("Parmesan Cheese");
        }
    }
}