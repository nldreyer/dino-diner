/*  CretaceousCombo.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem
    {
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets entree
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Gets and sets drink
        /// </summary>
        public Drink Drink { get; set; }

        /// <summary>
        /// Gets and sets side
        /// </summary>
        public Side Side { get; set; }

        private CretaceousCombo() { }

        /// <summary>
        /// Cretaceous combo constructor
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
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
