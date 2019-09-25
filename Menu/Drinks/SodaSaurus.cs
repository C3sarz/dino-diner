using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus
    {
        private Size size;
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor {
            get { return flavor; }
            set { flavor = value; }
        }

        public double Price { get; set; } = 1.5;

        public Size Size {
            get { return size; }
            set
            {
                size = value;
                if (size == Size.Medium) Price = 2.00; // missing the rest
            }
        }

        public bool Ice { get; set; } = true;

    }
}


//Property vs field (for the test)
//define argument
//camelcase used for private and protected