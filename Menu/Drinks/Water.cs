using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Manages the regular water drink.
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Determine if the tea has a lemon.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Holds the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> {"Water"};
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Water()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Manages size gets and sets.
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                this.Price = 0.10;
                this.Calories = 0;
            }
        }

        /// <summary>
        /// Adds a lemon.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
