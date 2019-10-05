/*  SteakosaurusBurger.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree
    {
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// SteakosaurusBurger constructor
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if(bun) ingredients.Add("Whole Wheat Bun");
                if(pickle) ingredients.Add("Pickle");
                if(ketchup) ingredients.Add("Ketchup");
                if(mustard) ingredients.Add("Mustard");
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
        /// Removes pickle from ingredients list
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Removes ketchup from ingredients list
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Removes mustard from ingredients list
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}