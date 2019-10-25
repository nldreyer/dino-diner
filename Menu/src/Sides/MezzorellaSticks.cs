/*  MezzorellaSticks.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class MezzorellaSticks : Side, INotifyPropertyChanged
    {
        // Backing variable
        private Size size;

        /// <summary>
        /// Notify of a property change; For price, calories, ingredients, size, and special
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

        public MezzorellaSticks()
        {
            this.Price = 0.99;
            this.Calories = 540;
        }

        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Breading", "Cheese Product", "Vegetable Oil" };
            }
        }

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
                        this.Calories = 540;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 720;
                        break;
                }
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Size");
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return $"{Size} Mezzorella Sticks";
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
                return specials.ToArray();
            }
        }
    }
}
