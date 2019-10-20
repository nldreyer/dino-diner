/*  SodasaurusTest.cs
*   Author: Nicholas Dreyer
*/
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        // The ability to set each possible flavor
        [Theory]
        [InlineData(SodasaurusFlavor.Cherry)]
        [InlineData(SodasaurusFlavor.Chocolate)]
        [InlineData(SodasaurusFlavor.Cola)]
        [InlineData(SodasaurusFlavor.Lime)]
        [InlineData(SodasaurusFlavor.Orange)]
        [InlineData(SodasaurusFlavor.RootBeer)]
        [InlineData(SodasaurusFlavor.Vanilla)]
        public void ShouldBeAbleToSetAllFlavors(SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = flavor;
            Assert.Equal<SodasaurusFlavor>(flavor, soda.Flavor);
        }


        // The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(1.50, soda.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }


        // The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal(1.50, soda.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal(2.00, soda.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal(2.50, soda.Price, 2);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }


        // That invoking HoldIce() results in the Ice propery being false.
        [Fact]
        public void ShouldHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }


        // Includes the correct ingredients
        [Fact]
        public void CorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Equal<int>(3, soda.Ingredients.Count);
        }
    }
}
