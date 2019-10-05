/*  JurassicJava.cs
*   Author: Nicholas Dreyer
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink
    {
        public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; } = false;
        private Size size = Size.Small;


        /// <summary>
        /// JurassicJava constructor
        /// </summary>
        public JurassicJava()
        {
            this.Price = 0.59;
            this.Calories = 2;
            this.Ice = false;
        }

        /// <summary>
        /// Gets ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }

        /// <summary>
        /// Gets and sets Size property and updates price and calories
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
                        this.Price = 0.59;
                        this.Calories = 2;
                        break;
                    case Size.Medium:
                        this.Price = 0.99;
                        this.Calories = 4;
                        break;
                    case Size.Large:
                        this.Price = 1.49;
                        this.Calories = 8;
                        break;
                }
            }
        }

        /// <summary>
        /// Sets RoomForCream property to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// Sets Ice property to true
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }

        /// <summary>
        /// Overrides the ToString function to return the menu item name
        /// </summary>
        /// <returns>Menu Item String</returns>
        public override string ToString()
        {
            if(Decaf) return Size + " Decaf Jurassic Java";
            else return Size + " Jurassic Java";
        }
    }
}
