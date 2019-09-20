using System.Collections.Generic;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
            this.Ingredients = new List<string>();
            for (int i = 0; i < 6; i++)
            {
                this.Ingredients.Add("Chicken Nugget");
            }
        }

        public void AddNugget()
        {
            this.Ingredients.Add("Chicken Nugget");
            this.Price += 0.25;
            this.Calories += 59;
        }
    }
}