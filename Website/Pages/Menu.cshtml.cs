/* Class: Menu.cshtml.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// Holds an instance of the Menu;
        /// </summary>
        public Menu Menu { get; } = new Menu();

        [BindProperty]
        public string Search { get; set; }

        [BindProperty]
        public float? minimumPrice { get; set; }

        [BindProperty]
        public float? maximumPrice { get; set; }

        [BindProperty]
        public List<string> excludedIngredients { get; set; } = new List<string>();

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        /// <summary>
        /// Holds all available menu items.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.AddRange(Menu.AvailableMenuItems);
                return items;
            }
        }

        /// <summary>
        /// Called when the webpage is loaded.
        /// </summary>
        public void OnGet()
        {
            menuCategory.Add("Combo");
            menuCategory.Add("Entree");
            menuCategory.Add("Side");
            menuCategory.Add("Drink");
        }

        public void OnPost(string search)
        {



        }

        /// <summary>
        /// Checks if the item is within the filtered range.
        /// </summary>
        /// <param name="Itemprice"></param>
        /// <returns></returns>
        public bool CheckIfInPriceRange(float Itemprice)
        {
            if (minimumPrice is null && maximumPrice is null) return true;
            else if (minimumPrice is null || maximumPrice is null)
            {
                if (minimumPrice is null && Itemprice <= maximumPrice) return true;
                if (maximumPrice is null && Itemprice >= minimumPrice) return true;
                else return false;
            }
            else if (Itemprice <= maximumPrice && Itemprice >= minimumPrice) return true;
            else return false;
        }

        /// <summary>
        /// Checks if a menu item contains an excluded ingredient.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool ContainsExcludedIngredient(IMenuItem item)
        {
            foreach(string ingredient in item.Ingredients)
            {
                if (excludedIngredients.Contains(ingredient)) return true;
            }
            return false;
        }

        /// <summary>
        /// Verifies if the menu item is searched for.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool InSearchResult(string name)
        {
            if (Search is null) return true;
            else if (name.Contains(Search, StringComparison.OrdinalIgnoreCase)) return true;
            else return false;
        }
    }
}