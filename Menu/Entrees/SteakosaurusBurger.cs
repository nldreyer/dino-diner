using System.Collections.Generic;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger : Entree
    {
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
            this.Ingredients = new List<string>() { "Steakburger Pattie", "Whole Wheat Bun", "Pickle", "Ketchup", "Mustard" };
        }

        public void HoldBun()
        {
            this.Ingredients.Remove("Whole Wheat Bun");
        }

        public void HoldPickle()
        {
            this.Ingredients.Remove("Pickle");
        }

        public void HoldKetchup()
        {
            this.Ingredients.Remove("Ketchup");
        }

        public void HoldMustard()
        {
            this.Ingredients.Remove("Mustard");
        }
    }
}