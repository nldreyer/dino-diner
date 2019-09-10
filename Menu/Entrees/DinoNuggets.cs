using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private uint extraNuggets = 0;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < 6 + extraNuggets; i++) {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        public void AddNugget()
        {
            this.extraNuggets += 1;
            this.Price += 0.25;
            this.Calories += 59;
        }
    }
}