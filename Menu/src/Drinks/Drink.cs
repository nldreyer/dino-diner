/*  Drink.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets whether or not there is ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Gets and sets the ingredients
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

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
