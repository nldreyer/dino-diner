/*  PrehistoricPBJ.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged
    {
        // Backing variables
        private bool peanutButter = true;
        private bool jelly = true;
        public CretaceousCombo cc;

        /// <summary>
        /// PrehistoricPBJ constructor
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if(peanutButter) ingredients.Add("Peanut Butter");
                if(jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Removes peanut butter from ingredients list
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            OnPropertyChanged(cc, "Ingredients");
            OnPropertyChanged(cc, "Special");
        }

        /// <summary>
        /// Removes jelly from ingredients list
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            OnPropertyChanged(cc, "Ingredients");
            OnPropertyChanged(cc, "Special");
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// Gets special
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (!peanutButter) specials.Add("Hold Peanut Butter");
                if (!jelly) specials.Add("Hold Jelly");
                return specials.ToArray();
            }
        }
    }
}
