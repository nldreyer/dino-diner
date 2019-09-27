using System.Collections.Generic;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst : Entree
    {
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
            this.Ingredients = new List<string>() { "Brautwurst", "Whole Wheat Bun", "Peppers", "Onion" };
        }

        public void HoldBun()
        {
            this.Ingredients.Remove("Whole Wheat Bun");
        }

        public void HoldPeppers()
        {
            this.Ingredients.Remove("Peppers");
        }

        public void HoldOnion()
        {
            this.Ingredients.Remove("Onion");
        }
    }
}