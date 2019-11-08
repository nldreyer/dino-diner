/*  VelociWrap.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class VelociWrap : Entree, INotifyPropertyChanged
    {
        // Backing variables
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;
        public CretaceousCombo cc;

        /// <summary>
        /// VelociWrap constructor
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if(dressing) ingredients.Add("Ceasar Dressing");
                if(lettuce) ingredients.Add("Romaine Lettuce");
                if(cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Removes dressing from ingredients list
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            OnPropertyChanged(cc, "Ingredients");
            OnPropertyChanged(cc, "Special");
        }

        /// <summary>
        /// Removes lettuce from ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            OnPropertyChanged(cc, "Ingredients");
            OnPropertyChanged(cc, "Special");
        }

        /// <summary>
        /// Removes cheese from ingredients list
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            OnPropertyChanged(cc, "Ingredients");
            OnPropertyChanged(cc, "Special");
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        /// <summary>
        /// Gets special
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (!dressing) specials.Add("Hold Dressing");
                if (!lettuce) specials.Add("Hold Lettuce");
                if (!cheese) specials.Add("Hold Cheese");
                return specials.ToArray();
            }
        }
    }
}