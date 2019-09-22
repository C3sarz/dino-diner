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
                    default:
                        Calories = 999;
                        break;
                }
            }
        }

    }
}
