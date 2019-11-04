/* Class: OrderTest.cs
* Author: Cesar Zavala
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            Order order = new Order();
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            order.Add(new Fryceritops());
            Assert.Equal<double>(0.99, order.SubtotalCost);
        }

        [Fact]
        public void ShouldHaveCorrectPriceSum()
        {
            Order order = new Order();
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            order.Add(new Fryceritops());
            order.Add(new Sodasaurus());
            Assert.Equal<double>((1.5+0.99), order.SubtotalCost);
        }

        [Fact]
        public void ShouldHaveCorrectComboPriceSum()
        {
            Order order = new Order();
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            order.Add(new CretaceousCombo(new Brontowurst()));
            Assert.Equal<double>((1.5 + 0.99 + 5.36 - 0.25), order.SubtotalCost);
        }

        [Fact]
        public void ShouldNotHaveNegativePrice()
        {
            Order order = new Order();
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            MockItem test = new MockItem();
            order.Add(test);
            order.Add(test);
            Assert.Equal<double>(0, order.SubtotalCost);
        }
    }
}
