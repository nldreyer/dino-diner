/*  JurassicJava.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink, INotifyPropertyChanged
    {
        // Backing variables
        private bool roomForCream = false;
        public bool Decaf = false;
        private Size size;

        /// <summary>
        /// Notify of a property change; For price, calories, ingredients, and special
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
        /// JurassicJava constructor
        /// </summary>
        public JurassicJava()
        {
            this.Price = 0.59;
            this.Calories = 2;
            this.Ice = false;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
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
                        this.Price = 0.59;
                        this.Calories = 2;
                        break;
                    case Size.Medium:
                        this.Price = 0.99;
                        this.Calories = 4;
                        break;
                    case Size.Large:
                        this.Price = 1.49;
                        this.Calories = 8;
                        break;
                }
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Size");
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Sets roomForCream property to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            roomForCream = true;
            OnPropertyChanged("Special");
        }

        /// <summary>
        /// Sets Ice property to true
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            OnPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            if(Decaf) return $"{Size} Decaf Jurassic Java";
            else return $"{Size} Jurassic Java";
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
                if (Ice) specials.Add("Add Ice");
                if (roomForCream) specials.Add("Leave Room For Cream");
                return specials.ToArray();
            }
        }
    }
}
