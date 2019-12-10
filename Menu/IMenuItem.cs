/* Class: IMenuItem.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu 
{
    /// <summary>
    /// Interface that links all menu tiems.
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Specifies the price.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Specifies the calories.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Specifies the list of ingredients.
        /// </summary>
        List<string> Ingredients { get; }

    }
}
