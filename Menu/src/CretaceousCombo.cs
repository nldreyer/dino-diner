/*  CretaceousCombo.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged
    {
        // Backing variables
        private Size size = Size.Small;
        private Entree entree;
        private Drink drink;
        private Side side;

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
        /// Gets and sets entree
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                if (value != entree)
                {
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("Ingredients");
                }
                entree = value;
            }
        }

        /// <summary>
        /// Gets and sets drink
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                if(value != drink)
                {
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("Ingredients");
                }
                drink = value;
            }
        }

        /// <summary>
        /// Gets and sets side
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                if (value != side)
                {
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("Ingredients");
                }
                side = value;
            }
        }

        /// <summary>
        /// Cretaceous combo constructor
        /// </summary>
        /// <param name="entree">Entree of the combo</param>
        public CretaceousCombo(Entree entree)
        {
            this.entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        /// <summary>
        /// Gets and sets size
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Description");
                OnPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Gets price
        /// </summary>
        public double Price
        {
            get { return Entree.Price + Drink.Price + Side.Price - 0.25; }
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Gets calories
        /// </summary>
        public uint Calories
        {
            get { return Entree.Calories + Drink.Calories + Side.Calories; }
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }

        /// <summary>
        /// Gets description
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets special
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                specials.AddRange(Entree.Special);
                specials.Add(Side.Description);
                specials.AddRange(Side.Special);
                specials.Add(Drink.Description);
                specials.AddRange(Drink.Special);
                return specials.ToArray();
            }
        }
    }
}
