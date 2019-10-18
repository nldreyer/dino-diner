/*  IOrderItem.cs
*   Author: Nicholas Dreyer
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.src
{
    public interface IOrderItem
    {
        /// <summary>
        /// Gets price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets description
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets special order instructions
        /// </summary>
        string[] Special { get; }
    }
}
