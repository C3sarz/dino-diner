using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
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
            ingredients.Add("Macaroni Noodles");
            ingredients.Add("Cheese Product");
            ingredients.Add("Pork Sausage");
            Size = Size.Small;
        }

        private List<string> ingredients = new List<string>();
        public override List<string> Ingredients
        {
            get { return ingredients; }
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
    }
}
