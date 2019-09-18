using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Manages the Fryceritops side.
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Fryceritops()
        {
            this.ingredients.Add("Potatoes");
            this.ingredients.Add("Salt");
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
                Size = value;
                switch (this.Size)
                {
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 480;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 365;
                        break;
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 222;
                        break;
                }
            }
        }
    }
}
