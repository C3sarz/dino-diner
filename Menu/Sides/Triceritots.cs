using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Triceritots()
        {
            this.ingredients.Add("Potato");
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
                this.Size = value;
                switch (this.Size)
                {
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 590;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 410;
                        break;
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 352;
                        break;
                }
            }
        }

    }
}
