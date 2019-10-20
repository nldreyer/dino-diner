/*  IOrderItem.cs
*   Author: Nicholas Dreyer
*/

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
