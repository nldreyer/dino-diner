/*  IMenuItem.cs
*   Author: Nicholas Dreyer
*/
using DinoDiner.Menu;
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
