/* Class: Velociwrap.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Manages the VelociWrap.
    /// </summary>
    public class VelociWrap : Entree
    {
        private bool _dressing = true;
        private bool _lettuce = true;
        private bool _cheese = true;

        /// <summary>
        /// Event Handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property Change event caller.
        /// </summary>
        /// <param name="propertyName">Name of changing property.</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Ingredients list
        /// </summary>
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

        /// <summary>
        /// Override the ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        /// <summary>
        /// Item description.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Array of special properties of the item.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!_dressing) special.Add("Hold Dressing");
                if (!_lettuce) special.Add("Hold Lettuce");
                if (!_cheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }
    }
}
