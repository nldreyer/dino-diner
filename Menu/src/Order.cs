/*  Order.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        /// <summary>
        /// Gets and sets all menu items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// Subtotal for all menu items in order
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subTotal = 0;
                foreach(IOrderItem item in Items)
                {
                    subTotal += item.Price;
                }
                if(subTotal < 0)
                {
                    subTotal = 0;
                }
                return subTotal;
            }
        }

        /// <summary>
        /// Tax rate for calculating sales tax cost
        /// </summary>
        public double SalesTaxRate { get; protected set; } = 0.09;

        /// <summary>
        /// Cost of sales tax on subtotal
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        /// <summary>
        /// Cost including subtotal and sales tax cost
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
