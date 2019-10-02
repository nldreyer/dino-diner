/*  PrehistoricPBJ.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// PrehistoricPBJ constructor
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
            this.Ingredients = new List<string>() { "Bread", "Peanut Butter", "Jelly" };
        }

        /// <summary>
        /// Removes peanut butter from ingredients list
        /// </summary>
        public void HoldPeanutButter()
        {
            this.Ingredients.Remove("Peanut Butter");
        }

        /// <summary>
        /// Removes jelly from ingredients list
        /// </summary>
        public void HoldJelly()
        {
            this.Ingredients.Remove("Jelly");
        }
    }
}
