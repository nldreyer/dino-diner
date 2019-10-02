/*  PterodactylWings.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// PterodactylWings constructor
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
            this.Ingredients = new List<string>() { "Chicken", "Wing Sauce" };
        }
    }
}