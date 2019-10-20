/*  WaterTest.cs
*   Author: Nicholas Dreyer
*/
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        // The correct default price, calories, ice, size, and lemon properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal(0.10, water.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }


        // The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal(0.10, water.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectPriceMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal(0.10, water.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectPriceSmall()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal(0.10, water.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesSmall()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }


        // That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }


        // That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void ShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }



        // Includes the correct ingredients
        [Fact]
        public void CorrectIngredientsWithoutLemon()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Single(water.Ingredients);
        }

        [Fact]
        public void CorrectIngredientsWithLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Contains<string>("Lemon", water.Ingredients);
            Assert.Equal<int>(2, water.Ingredients.Count);
        }

        // Has the correct description
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal("Medium Water", water.Description);
        }

        // Has the correct specials

        [Fact]
        public void ShouldHaveCorrectSpecialNone()
        {
            Water water = new Water();
            Assert.Empty(water.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.Contains("Hold Ice", water.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Contains("Add Lemon", water.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialIceAndLemon()
        {
            Water water = new Water();
            water.HoldIce();
            water.AddLemon();
            Assert.Contains("Hold Ice", water.Special);
            Assert.Contains("Add Lemon", water.Special);
            Assert.Equal<int>(2, water.Special.Length);
        }
    }
}
