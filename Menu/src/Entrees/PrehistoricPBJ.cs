using System.Collections.Generic;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree
    {
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
            this.Ingredients = new List<string>() { "Bread", "Peanut Butter", "Jelly" };
        }

        public void HoldPeanutButter()
        {
            this.Ingredients.Remove("Peanut Butter");
        }

        public void HoldJelly()
        {
            this.Ingredients.Remove("Jelly");
        }
    }
}
