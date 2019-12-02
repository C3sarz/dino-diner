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
        public string search { get; set; }

        [BindProperty]
        public float? minPrice { get; set; }

        [BindProperty]
        public float? maxPrice { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        /// <summary>
        /// Holds all available menu items.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems {
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
            
        }

        public void OnPost(string search)
        {



        }
    }
}