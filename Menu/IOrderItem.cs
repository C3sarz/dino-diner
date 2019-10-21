/* Class: IOrderItem.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Price with only a getter.
        /// </summary>
        double Price { get;}
        /// <summary>
        /// Item description.
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Array of special properties of the item.
        /// </summary>
        string[] Special { get; }
        /// <summary>
        /// Event Handler for the property changes.
        /// </summary>
        event PropertyChangedEventHandler PropertyChanged;
    }
}
