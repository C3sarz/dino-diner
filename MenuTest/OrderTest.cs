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
            items.Add(new Fryceritops());
            order.Items = items;
            Assert.Equal<double>(0.99, order.SubtotalCost);
        }

        [Fact]
        public void ShouldHaveCorrectPriceSum()
        {
            Order order = new Order();
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            items.Add(new Fryceritops());
            items.Add(new Sodasaurus());
            order.Items = items;
            Assert.Equal<double>((1.5+0.99), order.SubtotalCost);
        }

        [Fact]
        public void ShouldHaveCorrectComboPriceSum()
        {
            Order order = new Order();
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            items.Add(new CretaceousCombo(new Brontowurst()));
            order.Items = items;
            Assert.Equal<double>((1.5 + 0.99 + 5.36 - 0.25), order.SubtotalCost);
        }

        [Fact]
        public void ShouldNotHaveNegativePrice()
        {
            Order order = new Order();
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            MockItem test = new MockItem();
            items.Add(test);
            items.Add(test);
            order.Items = items;
            Assert.Equal<double>(0, order.SubtotalCost);
        }
    }
}
