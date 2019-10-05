/*  Brontowurst.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree
    {
        private bool bun = true;
        private bool onion = true;
        private bool peppers = true;

        /// <summary>
        /// Brontowurst constructor
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if(bun) ingredients.Add("Whole Wheat Bun");
                if(peppers) ingredients.Add("Peppers");
                if(onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Removes bun from ingredients list
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Removes peppers from ingredients list
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Removes onion from ingredients list
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}