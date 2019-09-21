using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Manages the MSticks
    /// </summary>
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public MezzorellaSticks()
        {
            this.ingredients.Add("Breading");
            this.ingredients.Add("Cheese Product");
            this.ingredients.Add("Vegetable Oil");
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
                        this.Calories = 720;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        break;
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 540;
                        break;
                }
            }
        }

    }
}
