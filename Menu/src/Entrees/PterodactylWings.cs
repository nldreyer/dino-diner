﻿/*  PterodactylWings.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// PterodactylWings constructor
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Chicken", "Wing Sauce" };
            }
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

        /// <summary>
        /// Gets special
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                return specials.ToArray();
            }
        }
    }
}