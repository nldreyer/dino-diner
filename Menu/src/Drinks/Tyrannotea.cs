/*  Tyrannotea.cs
*   Author: Nicholas Dreyer
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink
    {
        private Size size = Size.Small;
        private bool sweet = false;
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Tyrannotea constructor
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if(sweet) ingredients.Add("Cane Sugar");
                if(Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets Ice property to false
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }

        /// <summary>
        /// Adds lemon to ingredients list
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        /// <summary>
        /// Gets and sets Sweet property and adds or removes cane sugar to and from ingredients list
        /// Also updates calories
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                sweet = value;
                if (sweet)
                {
                    this.Calories *= 2;
                }
                else
                {
                    this.Calories /= 2;
                }
            }
        }

        /// <summary>
        /// Gets and sets Size property and updates price and calories
        /// Also doubles calories if sweet
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 8;
                        break;
                    case Size.Medium:
                        this.Price = 1.49;
                        this.Calories = 16;
                        break;
                    case Size.Large:
                        this.Price = 1.99;
                        this.Calories = 32;
                        break;
                }
                if (Sweet)
                {
                    this.Calories *= 2;
                }
            }
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            if (Sweet) return Size + " Sweet Tyrannotea";
            else return Size + " Tyrannotea";
        }
    }
}
