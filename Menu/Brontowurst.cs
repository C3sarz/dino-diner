/* Class: Brontowurst.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Manages the Brontowurst entree.
    /// </summary>
    public class Brontowurst : Entree
    {
        private bool _bun = true;
        private bool _peppers = true;
        private bool _onions = true;

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

        public override List<string> Ingredients  
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (_bun) ingredients.Add("Whole Wheat Bun");
                if (_peppers) ingredients.Add("Peppers");
                if (_onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// No parameter constructor.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// Bun holding method.
        /// </summary>
        public void HoldBun()
        {
        _bun = false;
        }
        /// <summary>
        /// Removes the peppers.
        /// </summary>
        public void HoldPeppers()
        {
            _peppers = false;
        }
        /// <summary>
        /// Removes the onions.
        /// </summary>
        public void HoldOnion()
        {
            _onions = false;
        }

        /// <summary>
        /// Override the ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
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
                if (!_bun) special.Add("Hold Bun");
                if (!_onions) special.Add("Hold Onion");
                if (!_peppers) special.Add("Hold Peppers");
                return special.ToArray();
            }
        }
    }
}
