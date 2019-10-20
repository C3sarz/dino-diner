/* Class: CretaceousCombo.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Manages the combo class.
    /// </summary>
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged,IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Entree entree;

        public Entree Entree {
            get { return entree; }
            protected set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args)
                {
                    NotifyOnPropertyChanged(args.PropertyName);
                };
            }
        }
        private Side side;

        /// <summary>
        /// Handles the side.
        /// </summary>
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                side.Size = size;
            }
        }

        private Drink drink = new Sodasaurus();
        /// <summary>
        /// Handles the drink of choice.
        /// </summary>
        public Drink Drink {
            get { return drink; }
            set
            {
                drink = value;
                NotifyOnPropertyChanged("Ingredients");
                NotifyOnPropertyChanged("Special");
                NotifyOnPropertyChanged("Price");
                NotifyOnPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Handles the price.
        /// </summary>
        public double Price
        {
            get
            {
                return (Entree.Price + Side.Price + Drink.Price - 0.25);
            }
        }

        /// <summary>
        /// Handles the calories.
        /// </summary>
        public uint Calories
        {
            get
            {
                return (Entree.Calories + Side.Calories + Drink.Calories);
            }
        }

        private Size size = Size.Small; // private backing variable

        /// <summary>
        /// Handles the size.
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = size;
                Side.Size = size;
                NotifyOnPropertyChanged("Special");
                NotifyOnPropertyChanged("Size");
            }
        }

        /// <summary>
        /// Handles the ingredient list.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();

        }

        /// <summary>
        /// Override the ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = Entree.ToString();
            return (result += " Combo");
        }

        /// <summary>
        /// Item description.
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Array of special properties of the item.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }
    }
}
