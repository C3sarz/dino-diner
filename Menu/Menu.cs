/* Class: Menu.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Manages the Menu and all its items.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Returns all menu items.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.AddRange(AvailableEntrees);
                items.AddRange(AvailableSides);
                items.AddRange(AvailableDrinks);
                items.AddRange(AvailableCombos);
                return items;
            }
        }

        /// <summary>
        /// Returns all available entrees.
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> entrees = new List<IMenuItem>();
                entrees.Add(new Brontowurst());
                entrees.Add(new DinoNuggets());
                entrees.Add(new PterodactylWings());
                entrees.Add(new VelociWrap());
                entrees.Add(new TRexKingBurger());
                entrees.Add(new SteakosaurusBurger());
                entrees.Add(new PrehistoricPBJ());
                return entrees;
            }
        }

        /// <summary>
        /// Returns all availablew sides.
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> sides = new List<IMenuItem>();
                sides.Add(new Fryceritops());
                sides.Add(new MeteorMacAndCheese());
                sides.Add(new MezzorellaSticks());
                sides.Add(new Triceritots());
                return sides;
            }
        }

        /// <summary>
        /// Returns all available drinks.
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> drinks = new List<IMenuItem>();
                drinks.Add(new JurassicJava());
                drinks.Add(new Sodasaurus());
                drinks.Add(new Tyrannotea());
                drinks.Add(new Water());
                return drinks;
            }
        }

        /// <summary>
        /// Returns all available combos.
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> combos = new List<IMenuItem>();
                IMenuItem[] items = AvailableEntrees.ToArray();
                foreach (IMenuItem item in items)
                {
                    combos.Add(new CretaceousCombo(item as Entree));
                }
                return combos;
            }
        }

        /// <summary>
        /// Override the ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(IMenuItem item in AvailableMenuItems)
            {
                sb.Append(item.ToString());
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
