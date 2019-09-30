﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
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
            this.Price = 0;
            this.Calories = 0;
            this.Ice = false;
            this.Ingredients = new List<string>() { "Water", "Coffee" };
        }

        /// <summary>
        /// 
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
        /// Leaves room for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// Adds ice
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }
    }
}
