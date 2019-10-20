﻿/* Class: Entree.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Blueprint for the entrees.
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem
    {

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
        public virtual List<string> Ingredients
        {
            get;
        }

        /// <summary>
        /// Item description.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Array of special properties of the item.
        /// </summary>
        public abstract string[] Special { get; }
    }
}
