/*  Entree.cs
*   Author: Nathan Bean
*   Modified by: Nicholas Dreyer
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{

    public abstract class Entree : IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Notify of a property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoke a changed property notification
        /// </summary>
        /// <param name="cc">Combo to call a notification, allowed to be null</param>
        /// <param name="propertyName">Name of property to notify for</param>
        protected void OnPropertyChanged(CretaceousCombo cc, string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            TryNotifyCombo(cc, propertyName);
        }

        /// <summary>
        /// Invoke a changed property notification
        /// </summary>
        /// <param name="cc">Combo to call a notification, allowed to be null</param>
        /// <param name="propertyNames">Array of property names to notify</param>
        protected void OnPropertyChanged(CretaceousCombo cc, string[] propertyNames)
        {
            foreach (string property in propertyNames)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
                TryNotifyCombo(cc, property);
            }
        }

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets the description
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets the special order instructions
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Checks if the entree is linked to a combo, if so then it notifies of a property change
        /// </summary>
        /// <param name="cc">Combo to send notification</param>
        /// <param name="propertyName">Property to notify for</param>
        protected void TryNotifyCombo(CretaceousCombo cc, string propertyName)
        {
            if (cc != null)
            {
                cc.NotifyItemChanged(propertyName);
            }
        }
    }
}
