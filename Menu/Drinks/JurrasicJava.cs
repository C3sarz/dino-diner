using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Manages the JurassicJava coffee.
    /// </summary>
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Determines if room is left for the cream.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Determines if the coffee had caffeine removed.
        /// </summary>
        public bool Decaf { get; set; } = false;

        public JurrasicJava()
        {
            this.Size = Size.Small;
            this.Ice = false;
        }

        /// <summary>
        /// Manages size gets and sets.
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (size == Size.Small)
                {
                    Price = 0.59;
                    Calories = 2;
                }

                else if (size == Size.Medium)
                {
                    Price = 0.99;
                    Calories = 4;
                }
                else if (size == Size.Large)
                {
                    Price = 1.49;
                    Calories = 8;
                }
            }
        }

        /// <summary>
        /// Holds the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Water", "Coffee" };
                return ingredients;
            }
        }

        /// <summary>
        /// Adds room for cream.
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// Adds ice to the coffee.
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
    }
}
