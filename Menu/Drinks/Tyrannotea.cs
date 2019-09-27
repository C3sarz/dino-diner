﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Determines if sweet or not.
        /// </summary>
        public bool Sweet { get; set; } = false;

        /// <summary>
        /// Determine if the tea has a lemon.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Tyrannotea()
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
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Water", "Tea"};
                if (Sweet) ingredients.Add("Cane Sugar");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

    }
}