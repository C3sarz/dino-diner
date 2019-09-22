using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Manages the VelociWrap.
    /// </summary>
    public class VelociWrap : Entree
    {
        private bool _dressing = true;
        private bool _lettuce = true;
        private bool _cheese = true;
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (_dressing) ingredients.Add("Ceasar Dressing");
                if (_lettuce) ingredients.Add("Romaine Lettuce");
                if (_cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// No parameter constructor.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Dressing holding method.
        /// </summary>
        public void HoldDressing()
        {
            _dressing = false;
        }

        /// <summary>
        /// Lettuce holding method.
        /// </summary>
        public void HoldLettuce()
        {
            _lettuce = false;
        }

        /// <summary>
        /// Cheese holding method.
        /// </summary>
        public void HoldCheese()
        {
            _cheese = false;
        }
    }
}
