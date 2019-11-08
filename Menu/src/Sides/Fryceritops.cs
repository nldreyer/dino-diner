/*  Fryceritops.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Fryceritops : Side, INotifyPropertyChanged
    {
        // Backing variable
        private Size size;

        /// <summary>
        /// Fryceritops constructor
        /// </summary>
        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        } 

        /// <summary>
        /// Gets and sets size
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 222;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 365;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 480;
                        break;
                }
                OnPropertyChanged(new string[] { "Price", "Calories", "Size", "Description" });
            }
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return $"{Size} Fryceritops";
        }

        /// <summary>
        /// Gets special
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                return specials.ToArray();
            }
        }
    }
}
