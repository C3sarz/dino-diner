/* Class: Order.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Handles orders.
    /// </summary>
    public class Order
    {
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();
        /// <summary>
        ///  Total price from the prices of all order items.
        /// </summary>
        public double SubtotalCost {
            get
            {
                double result = 0;
                foreach(IOrderItem item in Items)
                {
                    result += item.Price;
                }
                if (result < 0) result = 0;
                return result;
            }
        }

        /// <summary>
        /// Tax rate.
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.5;

        /// <summary>
        /// Product of the SalesTaxRate and the SubtotalCost.
        /// </summary>
        public double SalesTaxCost {
            get
            {
                return (SalesTaxRate * SubtotalCost);
            }
        }

        /// <summary>
        /// Total cost as the sum of the SubtotalCost and the SalesTaxCost.
        /// </summary>
        public double TotalCost { get { return (SubtotalCost + SalesTaxCost); } }
    }
}
