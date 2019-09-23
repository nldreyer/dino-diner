using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    class JurassicJava : Drink
    {
        public bool RoomForCream = false;
        public bool Decaf = false;
        public bool Ice = false;

        public JurassicJava()
        {
            this.Price = 0;
            this.Calories = 0;
            this.Ingredients = new List<string>() { };
        }

        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
    }
}
