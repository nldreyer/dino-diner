﻿/*  Order.cs
*   Author: Nicholas Dreyer
*/
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Notify of a property change; For subtotal cost, sales tax cost, and total cost
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoke a changed property notification
        /// </summary>
        /// <param name="propertyName">Name of property being updated</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
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
                return Math.Max(subTotal, 0);
            }
        }

        /// <summary>
        /// Tax rate for calculating sales tax cost
        /// </summary>
        public double SalesTaxRate { get; } = 0.09;

        /// <summary>
        /// Cost of sales tax on subtotal
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return Math.Round(SalesTaxRate * SubtotalCost, 2, MidpointRounding.AwayFromZero);
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

        /// <summary>
        /// Order constructor
        /// </summary>
        public Order()
        {
            Items.CollectionChanged += OnCollectionChanged;
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Items.Add(sb);
            Items.Add(new Fryceritops());
            Items.Add(new Triceritots());
        }

        /// <summary>
        /// Helper function to notify of event property changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCollectionChanged(object sender, EventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            Items.Add(item);
        }
    }
}
