using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Manages the Dino Nuggets entree.
    /// </summary>
    public class DinoNuggets : Entree
    {
        private uint _nuggetNumber;
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i = 0;i < _nuggetNumber; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// No parameter constructor.
        /// </summary>
        public DinoNuggets()
        {
            _nuggetNumber = 6;
            this.Price = 4.25;
            this.Calories = 59*_nuggetNumber;
        }

        /// <summary>
        /// Add nugget method.
        /// </summary>
        public void AddNugget()
        {
            this.Price += 0.25;
            _nuggetNumber++;
            this.Calories += 59;
        }
    }
}
