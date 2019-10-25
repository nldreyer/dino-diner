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
        public abstract event PropertyChangedEventHandler PropertyChanged;

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
        public abstract string Description { get; }

        /// <summary>
        /// Gets the special order instructions
        /// </summary>
        public abstract string[] Special { get; }
    }
}
