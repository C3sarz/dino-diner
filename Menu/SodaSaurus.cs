/* Class: Sodasaurus.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
        public SodasaurusFlavor Flavor
        {
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
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (size == Size.Small)
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
        public override List<string> Ingredients { get { return new List<string> { "Water", "Natural Flavors", "Cane Sugar" };
    } } 

        /// <summary>
        /// Override the ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = "";
            switch (Size)
            {
                case Size.Large:
                    result = "Large ";
                    break;
                case Size.Medium:
                    result = "Medium ";
                    break;
                case Size.Small:
                    result = "Small ";
                    break;
            }
            switch (Flavor)
            {
                case SodasaurusFlavor.Cherry:
                    result += "Cherry ";
                        break;
                case SodasaurusFlavor.Chocolate:
                    result += "Chocolate ";
                    break;
                case SodasaurusFlavor.RootBeer:
                    result += "RootBeer ";
                    break;
                case SodasaurusFlavor.Vanilla:
                    result += "Vanilla ";
                    break;
                case SodasaurusFlavor.Lime:
                    result += "Lime ";
                    break;
                case SodasaurusFlavor.Cola:
                    result += "Cola ";
                    break;
                case SodasaurusFlavor.Orange:
                    result += "Orange ";
                    break;
            }
            return (result += "Sodasaurus");
        }
    }
}


//Property vs field (for the test)
//define argument
//camelcase used for private and protected