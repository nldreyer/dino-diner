/*  IMenuItem.cs
*   Author: Nicholas Dreyer
*/
using DinoDiner.Menu.src;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public interface IMenuItem : IOrderItem
    {
        /// <summary>
        /// Gets calories
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        List<string> Ingredients { get; }
    }
}
