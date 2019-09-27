using System.Collections.Generic;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
            this.Ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast", "Ceasar Dressing",
                                                    "Romaine Lettuce", "Parmesan Cheese" };
        }

        public void HoldDressing()
        {
            this.Ingredients.Remove("Ceasar Dressing");
        }

        public void HoldLettuce()
        {
            this.Ingredients.Remove("Romaine Lettuce");
        }

        public void HoldCheese()
        {
            this.Ingredients.Remove("Parmesan Cheese");
        }
    }
}