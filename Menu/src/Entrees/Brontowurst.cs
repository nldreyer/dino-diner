/*  Brontowurst.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree, IOrderItem, INotifyPropertyChanged
    {
        // Backing variables
        private bool bun = true;
        private bool onion = true;
        private bool peppers = true;
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
            OnPropertyChanged("Ingredients");
            OnPropertyChanged("Special");
        }

        /// <summary>
        /// Removes peppers from ingredients list
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            OnPropertyChanged("Ingredients");
            OnPropertyChanged("Special");
        }

        /// <summary>
        /// Removes onion from ingredients list
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            OnPropertyChanged("Ingredients");
            OnPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return "Brontowurst";
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
                if (!onion) specials.Add("Hold Onion");
                if (!peppers) specials.Add("Hold Peppers");
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