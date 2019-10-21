/* Class: MockItem.cs
* Author: Cesar Zavala
*/

//CLASS INTENDED FOR DEBUG PURPOSES ONLY!!!

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Mock item with negative price (Use only for debug)
    /// </summary>
    public class MockItem : IOrderItem
    {
        public double Price => -9.99;
        public string Description => throw new NotImplementedException();

        public string[] Special => throw new NotImplementedException();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
