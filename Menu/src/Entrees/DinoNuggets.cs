/*  DinoNuggets.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree, INotifyPropertyChanged
    {
        // Backing variable
        private int extraNuggets = 0;
        public CretaceousCombo cc;

        /// <summary>
        /// Notify of a property change; For price, calories, ingredients, and special
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoke a changed property notification
        /// </summary>
        /// <param name="propertyName">Name of property being updated</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            TryNotifyCombo(propertyName);
        }

        /// <summary>
        /// DinoNuggets constructor
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < 6 + extraNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Adds a nugget to the ingredient list and updates price and calories
        /// </summary>
        public void AddNugget()
        {
            this.extraNuggets++;
            this.Price += 0.25;
            this.Calories += 59;
            OnPropertyChanged("Ingredients");
            OnPropertyChanged("Special");
            OnPropertyChanged("Price");
            OnPropertyChanged("Calories");
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        /// <summary>
        /// Gets description
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets special
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (extraNuggets != 0) specials.Add($"{extraNuggets} Extra Nuggets");
                return specials.ToArray();
            }
        }

        /// <summary>
        /// Checks if the entree is linked to a combo, if so then it notifies of a property change
        /// </summary>
        /// <param name="propertyName">Name of property to notify</param>
        private void TryNotifyCombo(string propertyName)
        {
            if (cc != null)
            {
                cc.NotifyItemChanged(propertyName);
            }
        }
    }
}