﻿/*  SteakosaurusBurger.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree, INotifyPropertyChanged
    {
        // Backing variables
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
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
            OnPropertyChanged("Ingredients");
            OnPropertyChanged("Special");
        }

        /// <summary>
        /// Removes pickle from ingredients list
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            OnPropertyChanged("Ingredients");
            OnPropertyChanged("Special");
        }

        /// <summary>
        /// Removes ketchup from ingredients list
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            OnPropertyChanged("Ingredients");
            OnPropertyChanged("Special");
        }

        /// <summary>
        /// Removes mustard from ingredients list
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            OnPropertyChanged("Ingredients");
            OnPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
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
                if (!bun) specials.Add("Hold Bun");
                if (!pickle) specials.Add("Hold Pickle");
                if (!ketchup) specials.Add("Hold Ketchup");
                if (!mustard) specials.Add("Hold Mustard");
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