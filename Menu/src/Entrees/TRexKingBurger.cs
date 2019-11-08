/*  TRexKingBurger.cs
*   Author: Nicholas Dreyer
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree, INotifyPropertyChanged
    {
        // Backing variables
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;
        public CretaceousCombo cc;

        /// <summary>
        /// TRexKingBurger constructor
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if(bun) ingredients.Add("Whole Wheat Bun");
                if(lettuce) ingredients.Add("Romaine Lettuce");
                if(tomato) ingredients.Add("Tomato");
                if(onion) ingredients.Add("Onion");
                if(pickle) ingredients.Add("Pickle");
                if(ketchup) ingredients.Add("Ketchup");
                if(mustard) ingredients.Add("Mustard");
                if(mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Removes bun from ingredients list
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            OnPropertyChanged(cc, new string[] { "Ingredients", "Special" });
        }

        /// <summary>
        /// Removes lettuce from ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            OnPropertyChanged(cc, new string[] { "Ingredients", "Special" });
        }

        /// <summary>
        /// Removes tomato from ingredients list
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            OnPropertyChanged(cc, new string[] { "Ingredients", "Special" });
        }

        /// <summary>
        /// Removes onion from ingredients list
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            OnPropertyChanged(cc, new string[] { "Ingredients", "Special" });
        }

        /// <summary>
        /// Removes pickle from ingredients list
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            OnPropertyChanged(cc, new string[] { "Ingredients", "Special" });
        }

        /// <summary>
        /// Removes ketchup from ingredients list
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            OnPropertyChanged(cc, new string[] { "Ingredients", "Special" });
        }

        /// <summary>
        /// Removes mustard from ingredients list
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            OnPropertyChanged(cc, new string[] { "Ingredients", "Special" });
        }

        /// <summary>
        /// Removes mayo from ingredients list
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            OnPropertyChanged(cc, new string[] { "Ingredients", "Special" });
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }

        /// <summary>
        /// Gets special
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (!bun) specials.Add("Hold Bun");
                if (!lettuce) specials.Add("Hold Lettuce");
                if (!tomato) specials.Add("Hold Tomato");
                if (!onion) specials.Add("Hold Onion");
                if (!pickle) specials.Add("Hold Pickle");
                if (!ketchup) specials.Add("Hold Ketchup");
                if (!mustard) specials.Add("Hold Mustard");
                if (!mayo) specials.Add("Hold Mayo");
                return specials.ToArray();
            }
        }
    }
}