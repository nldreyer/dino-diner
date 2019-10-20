using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        // Has the correct description
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.Description);
        }

        // Has the correct specials

        [Fact]
        public void ShouldHaveCorrectSpecialNone()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Empty(vw.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialHoldCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.Contains("Hold Cheese", vw.Special);
            Assert.Single(vw.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialHoldDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.Contains("Hold Dressing", vw.Special);
            Assert.Single(vw.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialHoldLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.Contains("Hold Lettuce", vw.Special);
            Assert.Single(vw.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialHoldAll()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            vw.HoldDressing();
            vw.HoldLettuce();
            Assert.Contains("Hold Cheese", vw.Special);
            Assert.Contains("Hold Dressing", vw.Special);
            Assert.Contains("Hold Lettuce", vw.Special);
            Assert.Equal<int>(3, vw.Special.Length);
        }
    }
}
