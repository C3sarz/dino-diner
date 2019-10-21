/* Class: Sodasaurus.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Keeps the flavor.
        /// </summary>
        private SodasaurusFlavor flavor;

        /// <summary>
        /// Event Handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property Change event caller.
        /// </summary>
        /// <param name="propertyName">Name of changing property.</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


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
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
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

        /// <summary>
        /// Item description.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Array of special properties of the item.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}
