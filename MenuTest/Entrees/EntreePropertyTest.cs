/*  EntreePropertyTest.cs
*   Author: Nicholas Dreyer
*/
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class EntreePropertyTest
    {
        // All properties used in each Entree should change with a notification
        [Fact]
        public void PropertyShouldChangeBrontowurst()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Ingredients", () => bw.HoldBun());
            Assert.PropertyChanged(bw, "Ingredients", () => bw.HoldPeppers());
            Assert.PropertyChanged(bw, "Ingredients", () => bw.HoldOnion());
            Assert.PropertyChanged(bw, "Special", () => bw.HoldBun());
            Assert.PropertyChanged(bw, "Special", () => bw.HoldPeppers());
            Assert.PropertyChanged(bw, "Special", () => bw.HoldOnion());
        }

        [Fact]
        public void PropertyShouldChangeDinoNuggets()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.PropertyChanged(dn, "Price", () => dn.AddNugget());
            Assert.PropertyChanged(dn, "Special", () => dn.AddNugget());
            Assert.PropertyChanged(dn, "Calories", () => dn.AddNugget());
            Assert.PropertyChanged(dn, "Ingredients", () => dn.AddNugget());
        }

        [Fact]
        public void PropertyShouldChangePrehistoricPBJ()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Ingredients", () => pbj.HoldPeanutButter());
            Assert.PropertyChanged(pbj, "Ingredients", () => pbj.HoldJelly());
            Assert.PropertyChanged(pbj, "Special", () => pbj.HoldPeanutButter());
            Assert.PropertyChanged(pbj, "Special", () => pbj.HoldJelly());
        }

        [Fact]
        public void PropertyShouldNotChangePterodactylWings()
        {
            
        }

        [Fact]
        public void PropertyShouldChangeSteakosaurusBurger()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Ingredients", () => sb.HoldBun());
            Assert.PropertyChanged(sb, "Ingredients", () => sb.HoldPickle());
            Assert.PropertyChanged(sb, "Ingredients", () => sb.HoldKetchup());
            Assert.PropertyChanged(sb, "Ingredients", () => sb.HoldMustard());
            Assert.PropertyChanged(sb, "Special", () => sb.HoldBun());
            Assert.PropertyChanged(sb, "Special", () => sb.HoldPickle());
            Assert.PropertyChanged(sb, "Special", () => sb.HoldKetchup());
            Assert.PropertyChanged(sb, "Special", () => sb.HoldMustard());
        }

        [Fact]
        public void PropertyShouldChangeTRexKingBurger()
        {
            TRexKingBurger kb = new TRexKingBurger();
            Assert.PropertyChanged(kb, "Ingredients", () => kb.HoldBun());
            Assert.PropertyChanged(kb, "Ingredients", () => kb.HoldKetchup());
            Assert.PropertyChanged(kb, "Ingredients", () => kb.HoldLettuce());
            Assert.PropertyChanged(kb, "Ingredients", () => kb.HoldMayo());
            Assert.PropertyChanged(kb, "Ingredients", () => kb.HoldMustard());
            Assert.PropertyChanged(kb, "Ingredients", () => kb.HoldOnion());
            Assert.PropertyChanged(kb, "Ingredients", () => kb.HoldPickle());
            Assert.PropertyChanged(kb, "Ingredients", () => kb.HoldTomato());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldBun());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldKetchup());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldLettuce());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldMayo());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldMustard());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldOnion());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldPickle());
            Assert.PropertyChanged(kb, "Special", () => kb.HoldTomato());
        }

        [Fact]
        public void PropertyShouldChangeVelociWrap()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Ingredients", () => vw.HoldDressing());
            Assert.PropertyChanged(vw, "Ingredients", () => vw.HoldLettuce());
            Assert.PropertyChanged(vw, "Ingredients", () => vw.HoldCheese());
            Assert.PropertyChanged(vw, "Special", () => vw.HoldDressing());
            Assert.PropertyChanged(vw, "Special", () => vw.HoldLettuce());
            Assert.PropertyChanged(vw, "Special", () => vw.HoldCheese());
        }
    }
}
