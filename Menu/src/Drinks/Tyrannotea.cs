/*  Tyrannotea.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink, INotifyPropertyChanged
    {
        // Backing variables
        private Size size;
        private bool sweet = false;
        public bool Lemon = false;

        /// <summary>
        /// Notify of a property change; For price, calories, ingredients, and special
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
        /// Tyrannotea constructor
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if(sweet) ingredients.Add("Cane Sugar");
                if(Lemon) ingredients.Add("Lemon");
                return ingredients;
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
        /// Adds lemon to ingredients list
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            OnPropertyChanged("Ingredients");
            OnPropertyChanged("Special");
        }

        /// <summary>
        /// Gets and sets Sweet property and adds or removes cane sugar to and from ingredients list
        /// Also updates calories
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                if (value && !sweet)
                {
                    this.Calories *= 2;
                }
                else if (sweet && !value)
                {
                    this.Calories /= 2;
                }
                sweet = value;
                OnPropertyChanged("Calories");
                OnPropertyChanged("Ingredients");
                OnPropertyChanged("Special");
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Gets and sets Size property and updates price and calories
        /// Also doubles calories if sweet
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
                        this.Calories = 8;
                        break;
                    case Size.Medium:
                        this.Price = 1.49;
                        this.Calories = 16;
                        break;
                    case Size.Large:
                        this.Price = 1.99;
                        this.Calories = 32;
                        break;
                }
                if (Sweet)
                {
                    this.Calories *= 2;
                }
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Size");
            }
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            if (Sweet) return $"{Size} Sweet Tyrannotea";
            else return $"{Size} Tyrannotea";
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
                if (Lemon) specials.Add("Add Lemon");
                return specials.ToArray();
            }
        }
    }
}
