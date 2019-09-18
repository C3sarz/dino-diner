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
            this.ingredients.Add("Macaroni Noodles");
            this.ingredients.Add("Cheese Product");
            this.ingredients.Add("Pork Sausage");
        }

        /// <summary>
        /// Overrides the base size method.
        /// </summary>
        public override Size Size
        {
            get => this.Size;
            set
            {
                this.Size = value;
                switch (this.Size)
                {
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 520;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 490;
                        break;
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 420;
                        break;
                }
            }
        }
    }
}
