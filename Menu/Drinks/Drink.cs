using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Drink base class.
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Keeps the size.
        /// </summary>
        protected Size size { get; set; }

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Manages ice (default true).
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Removes the ice.
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
