using System.Collections.Generic;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger : Entree
    {
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
            this.Ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie",
                                                    "Whole Wheat Bun", "Romaine Lettuce", "Tomato", "Onion", "Pickle",
                                                    "Ketchup", "Mustard", "Mayo" };
        }

        public void HoldBun()
        {
            this.Ingredients.Remove("Whole Wheat Bun");
        }

        public void HoldLettuce()
        {
            this.Ingredients.Remove("Romaine Lettuce");
        }

        public void HoldTomato()
        {
            this.Ingredients.Remove("Tomato");
        }

        public void HoldOnion()
        {
            this.Ingredients.Remove("Onion");
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

        public void HoldMayo()
        {
            this.Ingredients.Remove("Mayo");
        }
    }
}