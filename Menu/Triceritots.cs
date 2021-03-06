﻿/* Class: Triceritots.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Triceritots : Side, INotifyPropertyChanged
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Triceritots()
        {
            Size = Size.Small;
        }

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
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
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
                    default:
                        Calories = 999;
                        break;
                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Override the ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = "";
            switch (Size)
            {
                case Size.Large:
                    result = "Large ";
                    break;
                case Size.Medium:
                    result = "Medium ";
                    break;
                case Size.Small:
                    result = "Small ";
                    break;
            }
            return (result += "Triceritots");
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
                return special.ToArray();
            }
        }
    }
}
