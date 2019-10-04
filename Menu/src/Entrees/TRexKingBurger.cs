/*  TRexKingBurger.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// TRexKingBurger constructor
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
            this.Ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie",
                                                    "Whole Wheat Bun", "Romaine Lettuce", "Tomato", "Onion", "Pickle",
                                                    "Ketchup", "Mustard", "Mayo" };
        }

        /// <summary>
        /// Removes bun from ingredients list
        /// </summary>
        public void HoldBun()
        {
            this.Ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// Removes lettuce from ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.Ingredients.Remove("Romaine Lettuce");
        }

        /// <summary>
        /// Removes tomato from ingredients list
        /// </summary>
        public void HoldTomato()
        {
            this.Ingredients.Remove("Tomato");
        }

        /// <summary>
        /// Removes onion ffrom ingredients list
        /// </summary>
        public void HoldOnion()
        {
            this.Ingredients.Remove("Onion");
        }

        /// <summary>
        /// Removes pickle from ingredients list
        /// </summary>
        public void HoldPickle()
        {
            this.Ingredients.Remove("Pickle");
        }

        /// <summary>
        /// Removes ketchup from ingredients list
        /// </summary>
        public void HoldKetchup()
        {
            this.Ingredients.Remove("Ketchup");
        }

        /// <summary>
        /// Removes mustard from ingredients list
        /// </summary>
        public void HoldMustard()
        {
            this.Ingredients.Remove("Mustard");
        }

        /// <summary>
        /// Removes mayo from ingredients list
        /// </summary>
        public void HoldMayo()
        {
            this.Ingredients.Remove("Mayo");
        }
    }
}