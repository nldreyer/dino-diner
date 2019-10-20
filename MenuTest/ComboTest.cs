/*  ComboTest.cs
*   Author: Nicholas Dreyer
*/
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class ComboTest
    {
        [Fact]
        public void ShouldHaveCorrectEntree()
        {
            CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
            Assert.Contains("Brontowurst", cc.Entree.Description);
            cc = new CretaceousCombo(new DinoNuggets());
            Assert.Contains("Dino-Nuggets", cc.Entree.Description);
            cc = new CretaceousCombo(new PrehistoricPBJ());
            Assert.Contains("Prehistoric PB&J", cc.Entree.Description);
            cc = new CretaceousCombo(new PterodactylWings());
            Assert.Contains("Pterodactyl Wings", cc.Entree.Description);
            cc = new CretaceousCombo(new SteakosaurusBurger());
            Assert.Contains("Steakosaurus Burger", cc.Entree.Description);
            cc = new CretaceousCombo(new TRexKingBurger());
            Assert.Contains("T-Rex King Burger", cc.Entree.Description);
            cc = new CretaceousCombo(new VelociWrap());
            Assert.Contains("Veloci-Wrap", cc.Entree.Description);
        }

        [Fact]
        public void ShouldHaveCorrectDrink()
        {
            CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
            Assert.Contains("Small Cola Sodasaurus", cc.Drink.Description);
            cc.Drink = new JurassicJava();
            Assert.Contains("Small Jurassic Java", cc.Drink.Description);
            cc.Drink = new Tyrannotea();
            Assert.Contains("Small Tyrannotea", cc.Drink.Description);
            cc.Drink = new Water();
            Assert.Contains("Small Water", cc.Drink.Description);
        }

        [Fact]
        public void ShouldHaveCorrectSide()
        {
            CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
            Assert.Contains("Small Fryceritops", cc.Side.Description);
            cc.Side = new MeteorMacAndCheese();
            Assert.Contains("Small Meteor Mac and Cheese", cc.Side.Description);
            cc.Side = new MezzorellaSticks();
            Assert.Contains("Small Mezzorella Sticks", cc.Side.Description);
            cc.Side = new Triceritots();
            Assert.Contains("Small Triceritots", cc.Side.Description);
        }
    }
}
