/*  DrinkPropertyTest.cs
*   Author: Nicholas Dreyer
*/
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class DrinkPropertyTest
    {
        // All properties used in each Drink should change with a notification
        [Fact]
        public void PropertyShouldChangeJurassicJava()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price", () => java.Size = Size.Large);
            Assert.PropertyChanged(java, "Special", () => java.LeaveRoomForCream());
            Assert.PropertyChanged(java, "Special", () => java.AddIce());
            Assert.PropertyChanged(java, "Calories", () => java.Size = Size.Large);
            Assert.PropertyChanged(java, "Size", () => java.Size = Size.Large);
        }

        [Fact]
        public void PropertyShouldChangeSodaSaurus()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            Assert.PropertyChanged(sodasaurus, "Price", () => sodasaurus.Size = Size.Large);
            Assert.PropertyChanged(sodasaurus, "Special", () => sodasaurus.HoldIce());
            Assert.PropertyChanged(sodasaurus, "Calories", () => sodasaurus.Size = Size.Large);
            Assert.PropertyChanged(sodasaurus, "Size", () => sodasaurus.Size = Size.Large);
        }

        [Fact]
        public void PropertyShouldChangeTyrannotea()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            Assert.PropertyChanged(tyrannotea, "Price", () => tyrannotea.Size = Size.Large);
            Assert.PropertyChanged(tyrannotea, "Special", () => tyrannotea.AddLemon());
            Assert.PropertyChanged(tyrannotea, "Special", () => tyrannotea.HoldIce());
            Assert.PropertyChanged(tyrannotea, "Special", () => tyrannotea.Sweet = true);
            Assert.PropertyChanged(tyrannotea, "Calories", () => tyrannotea.Size = Size.Large);
            Assert.PropertyChanged(tyrannotea, "Calories", () => tyrannotea.Sweet = true);
            Assert.PropertyChanged(tyrannotea, "Size", () => tyrannotea.Size = Size.Large);
            Assert.PropertyChanged(tyrannotea, "Ingredients", () => tyrannotea.AddLemon());
            Assert.PropertyChanged(tyrannotea, "Ingredients", () => tyrannotea.Sweet = true);
        }

        [Fact]
        public void PropertyShouldChangeWater()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () => water.AddLemon());
            Assert.PropertyChanged(water, "Special", () => water.HoldIce());
            Assert.PropertyChanged(water, "Size", () => water.Size = Size.Large);
            Assert.PropertyChanged(water, "Ingredients", () => water.AddLemon());
        }
    }
}
