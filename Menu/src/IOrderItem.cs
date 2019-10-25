/*  IOrderItem.cs
*   Author: Nicholas Dreyer
*/

using System.ComponentModel;

namespace DinoDiner.Menu
{
    public interface IOrderItem : INotifyPropertyChanged
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
