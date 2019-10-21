/* Class: SteakosaurusBurger.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Manages the Burger.
    /// </summary>
    public class SteakosaurusBurger : Entree, INotifyPropertyChanged
    {
        private bool _bun = true;
        private bool _pickle = true;
        private bool _ketchup = true;
        private bool _mustard = true;

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
        /// Ingredients List
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Steakburger Pattie"};
                if (_bun) ingredients.Add("Whole Wheat Bun");
                if (_pickle) ingredients.Add("Pickle");
                if (_ketchup) ingredients.Add("Ketchup");
                if (_mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// No parameter constructor.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Bun holding method.
        /// </summary>
        public void HoldBun()
        {
            _bun = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Pickles holding method.
        /// </summary>
        public void HoldPickle()
        {
            _pickle = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Ketchup holding method.
        /// </summary>
        public void HoldKetchup()
        {
            _ketchup = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Mustard holding method.
        /// </summary>
        public void HoldMustard()
        {
            _mustard = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Override the ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
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
                if (!_ketchup) special.Add("Hold Ketchup");
                if (!_mustard) special.Add("Hold Mustard");
                if (!_pickle) special.Add("Hold Pickle");
                return special.ToArray();
            }
        }
    }
}
