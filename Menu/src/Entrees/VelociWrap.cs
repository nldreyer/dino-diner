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
            OnPropertyChanged("Ingredients");
            OnPropertyChanged("Special");
        }

        /// <summary>
        /// Removes lettuce from ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            OnPropertyChanged("Ingredients");
            OnPropertyChanged("Special");
        }

        /// <summary>
        /// Removes cheese from ingredients list
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            OnPropertyChanged("Ingredients");
            OnPropertyChanged("Special");
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
                if (!dressing) specials.Add("Hold Dressing");
                if (!lettuce) specials.Add("Hold Lettuce");
                if (!cheese) specials.Add("Hold Cheese");
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