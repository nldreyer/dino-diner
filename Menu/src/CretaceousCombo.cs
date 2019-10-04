/*  CretaceousCombo.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        private Size size = Size.Small;

        public Entree Entree { get; set; }

        public Drink Drink { get; set; }

        public Side Side { get; set; }

        private CretaceousCombo() { }

        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

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

        public double Price
        {
            get { return Entree.Price + Drink.Price + Side.Price - 0.25; }
        }

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

        public string ToString()
        {
            return $"";
        }
    }
}
