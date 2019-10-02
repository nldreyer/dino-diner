/*  Brontowurst.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Brontowurst constructor
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
            this.Ingredients = new List<string>() { "Brautwurst", "Whole Wheat Bun", "Peppers", "Onion" };
        }

        /// <summary>
        /// Removes bun from ingredients list
        /// </summary>
        public void HoldBun()
        {
            this.Ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// Removes peppers from ingredients list
        /// </summary>
        public void HoldPeppers()
        {
            this.Ingredients.Remove("Peppers");
        }

        /// <summary>
        /// Removes onion from ingredients list
        /// </summary>
        public void HoldOnion()
        {
            this.Ingredients.Remove("Onion");
        }
    }
}