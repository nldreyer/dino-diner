/*  JurassicJavaTest.cs
*   Author: Nicholas Dreyer
*/
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        // The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(0.59, java.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldHaveCorrectSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);
        }


        // The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal(1.49, java.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectPriceMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal(0.99, java.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectPriceSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal(0.59, java.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }


        // That invoking AddIce() results in the Ice property being true
        [Fact]
        public void ShouldAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }


        // That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.
        [Fact]
        public void ShouldLeaveRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.Contains("Leave Room For Cream", java.Special);
        }


        // Includes the correct ingredients
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }

        // Has the correct description
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal("Medium Jurassic Java", java.Description);
        }

        [Fact]
        public void ShouldHaveCorrectDescriptionDecaf()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            java.Decaf = true;
            Assert.Equal("Large Decaf Jurassic Java", java.Description);
        }

        // Has the correct specials

        [Fact]
        public void ShouldHaveCorrectSpecialNone()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.Contains("Add Ice", java.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.Contains("Leave Room For Cream", java.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialIceAndCream()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            java.LeaveRoomForCream();
            Assert.Contains("Add Ice", java.Special);
            Assert.Contains("Leave Room For Cream", java.Special);
            Assert.Equal<int>(2, java.Special.Length);
        }
    }
}
