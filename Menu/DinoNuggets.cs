/* Class: DinoNuggets.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Manages the Dino Nuggets entree.
    /// </summary>
    public class DinoNuggets : Entree
    {
        private uint _nuggetNumber;

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
        /// Ingredients list.
        /// </summary>
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

        /// <summary>
        /// Override the ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
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
                if(_nuggetNumber > 6)
                {
                    string result = (_nuggetNumber - 6) + " Extra Nuggets";
                    special.Add(result);
                }
                return special.ToArray();
            }
        }
    }
}
