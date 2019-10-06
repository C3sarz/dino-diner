/* Class: MeteorMacAndCheese.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Manages the Meteor MnC side.
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public MeteorMacAndCheese()
        {

            Size = Size.Small;
        }
        
        /// <summary>
        /// Returns the ingredient list.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausage");
                return ingredients;
            }
        }

        /// <summary>
        /// Overrides the base size method.
        /// </summary>
        public override Size Size
        {
            get
            {
                if (this.Price == 1.95) return Size.Large;
                else if (this.Price == 1.45) return Size.Medium;
                else return Size.Small;
            }
            set
            {
                switch (value)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        break;
                    default:
                        Calories = 999;
                        break;
                }
            }
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
            return (result += "Meteor Mac and Cheese");
        }
    }
}
