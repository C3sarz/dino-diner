/* Class: CretaceousCombo.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Manages the combo class.
    /// </summary>
    public class CretaceousCombo : IMenuItem
    {
        public Entree Entree { get; set; }
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
        /// <summary>
        /// Handles the drink of choice.
        /// </summary>
        public Drink Drink { get; set; }

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
    }
}
