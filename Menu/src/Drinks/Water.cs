﻿/*  Water.cs
*   Author: Nicholas Dreyer
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        public bool Lemon { get; set; } = false;
        
        /// <summary>
        /// Water constructor
        /// </summary>
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;
            this.Size = Size.Small;
            this.Ingredients = new List<string>() { "Water" };
        }

        /// <summary>
        /// Adds lemon to ingredients list
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            this.Ingredients.Add("Lemon");
        }

        /// <summary>
        /// Sets Ice property to false
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
