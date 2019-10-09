﻿/* Class: Tyrannotea.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink
    {
        private bool sweet = false;
        /// <summary>
        /// Determines if sweet or not.
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                if (value && !sweet) Calories = 2 * Calories;
                else if (!value && sweet) Calories = Calories / 2;
                sweet = value;
            }
        }

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
                    Price = 0.99;
                    Calories = 8;
                }

                else if (size == Size.Medium)
                {
                    Price = 1.49;
                    Calories = 16;
                }
                else if (size == Size.Large)
                {
                    Price = 1.99;
                    Calories = 32;
                }
                if (Sweet) Calories = 2 * Calories;
            }
        }

        /// <summary>
        /// Holds the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Water", "Tea" };
                if (Sweet) ingredients.Add("Cane Sugar");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Adds a lemon.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

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
            if (sweet) result += "Sweet ";
            return (result += "Tyrannotea");
        }
    }
}