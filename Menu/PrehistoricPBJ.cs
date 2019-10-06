/* Class: PrehistoricPBJ.cs
* Author: Cesar Zavala
*/
using System.Collections.Generic;
namespace DinoDiner.Menu
{
    /// <summary>
    /// Manages the PrehistoricPBJ entree.
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;
        /// <summary>
        /// Handles the ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Holds the peanut butter.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Sets jelly to false.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }

        /// <summary>
        /// Override the ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
