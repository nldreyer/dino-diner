using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        private SodasaurusFlavor flavor;
        private bool ice = true;

        private Size size = Size.Small;
        public uint Calories = 0;
        public double Price = 1.50;


        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 1.50;
                        this.Calories = 112;
                        break;
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
                        break;
                    case Size.Large:
                        this.Price = 2.50;
                        this.Calories = 208;
                        break;
                }
            }
        }
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
            }
        }
        public override bool Ice
        {
            get
            {
                return ice;
            }
        }

        public void HoldIce()
        {
            ice = false;
        }
    }
}
