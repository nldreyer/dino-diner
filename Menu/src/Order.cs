/*  Order.cs
*   Author: Nicholas Dreyer
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu.src
{
    public class Order
    {
        /// <summary>
        /// Collection of all menu items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

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
        public double SalesTaxRate { get; protected set; }

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
