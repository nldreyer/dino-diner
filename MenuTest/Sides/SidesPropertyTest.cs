/*  SidesPropertyTest.cs
*   Author: Nicholas Dreyer
*/
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class SidesPropertyTest
    {
        // All properties used in each Side should change with a notification
        [Fact]
        public void PropertyShouldChangeFryceritops()
        {
            Fryceritops ft = new Fryceritops();
            Assert.PropertyChanged(ft, "Price", () => ft.Size = Size.Large);
            Assert.PropertyChanged(ft, "Calories", () => ft.Size = Size.Large);
            Assert.PropertyChanged(ft, "Size", () => ft.Size = Size.Large);
        }

        [Fact]
        public void PropertyShouldChangeMeteorMacAndCheese()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.PropertyChanged(mmc, "Price", () => mmc.Size = Size.Large);
            Assert.PropertyChanged(mmc, "Calories", () => mmc.Size = Size.Large);
            Assert.PropertyChanged(mmc, "Size", () => mmc.Size = Size.Large);
        }

        [Fact]
        public void PropertyShouldChangeMezzorellaSticks()
        {
            MezzorellaSticks mz = new MezzorellaSticks();
            Assert.PropertyChanged(mz, "Price", () => mz.Size = Size.Large);
            Assert.PropertyChanged(mz, "Calories", () => mz.Size = Size.Large);
            Assert.PropertyChanged(mz, "Size", () => mz.Size = Size.Large);
        }

        [Fact]
        public void PropertyShouldChangeTriceritots()
        {
            Triceritots tt = new Triceritots();
            Assert.PropertyChanged(tt, "Price", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Calories", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Size", () => tt.Size = Size.Large);
        }
    }
}
