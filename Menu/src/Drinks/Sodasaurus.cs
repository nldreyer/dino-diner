/*  Sodasaururs.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, INotifyPropertyChanged
    {
        // Backing variables
        private SodasaurusFlavor flavor = SodasaurusFlavor.Cola;
        private Size size;

        /// <summary>
        /// Notify of a property change; For price, calories, ingredients, flavor, and special
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoke a changed property notification
        /// </summary>
        /// <param name="propertyName">Name of property being updated</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Sodasaurus constructor
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }

        /// <summary>
        /// Gets and sets Size property and updates price and calories
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
                        this.Price = 1.50;
                        this.Calories = 112;
                        break;
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
                        break;
                    case Size.Large:
                        this.Price = 2.50;
                        this.Calories = 208;
                        break;
                }
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Size");
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Gets and sets Flavor property
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
                OnPropertyChanged("Flavor");
            }
        }

        /// <summary>
        /// Sets Ice property to false
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
            OnPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
        }

        /// <summary>
        /// Gets description
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets special
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (!Ice) specials.Add("Hold Ice");
                return specials.ToArray();
            }
        }
    }
}
