﻿using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Keeps the flavor.
        /// </summary>
        private SodasaurusFlavor flavor;

        /// <summary>
        /// Public field for the flavor.
        /// </summary>
        public SodasaurusFlavor Flavor {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Sodasaurus()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Manages size gets and sets.
        /// </summary>
        public override Size Size {
            get { return size; }
            set
            {
                size = value;
                if(size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }

                else if (size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                }
                else if (size == Size.Large)
                {
                    Price = 2.50;
                    Calories = 208;
                }
            }
        }

        /// <summary>
        /// Holds the ingredients
        /// </summary>
        public override List<string> Ingredients { get; } = new List<string> { "Water", "Natural Flavors", "Cane Sugar" };


        /// <summary>
        /// Manages ice (default true).
        /// </summary>
        public bool Ice { get; set; } = true;

    }
}


//Property vs field (for the test)
//define argument
//camelcase used for private and protected