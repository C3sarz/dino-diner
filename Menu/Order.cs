/* Class: Order.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Handles orders.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        public Order()
        {

        }

        public IOrderItem[] Items
        {
            get { return items.ToArray(); }
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        private List<IOrderItem> items { get; set; } = new List<IOrderItem>();
        /// <summary>
        ///  Total price from the prices of all order items.
        /// </summary>
        public double SubtotalCost {
            get
            {
                double result = 0;
                foreach(IOrderItem item in items)
                {
                    result += item.Price;
                }
                if (result < 0) result = 0;
                return result;
            }
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this,new EventArgs());
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
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

        /// <summary>
        /// Event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
