/* Class: PterodactylWings.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Manages the Pterodactyl Wings entree.
    /// </summary>
    public class PterodactylWings : Entree
    {
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Chicken","Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// No parameter constructor.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// Override the ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
