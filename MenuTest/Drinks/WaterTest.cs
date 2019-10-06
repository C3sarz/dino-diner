/* Class: WaterTest.cs
* Author: Cesar Zavala
*/
using DinoDiner.Menu;
using Xunit;

namespace DinoDiner.MenuTest.Drinks
{
    public class WaterTest
    {
        //The correct default price, calories, ice, size, lemon properties.

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
        Water water = new Water();
        Assert.Equal<uint>(0, water.Calories);

        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }
        public void ShouldHaveDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);

        }

        //The correct price and calories after changing to small, medium, and large sizes.

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal<double>(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0.10, water.Price);
        }

        //Correct calories after changing size.

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        //Invoking HoldIce() results in the Ice property being false.

        [Fact]
        public void HoldIceRemovesIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        //Invoking AddLemon() sets results in the Lemon property being true.

        [Fact]
        public void AddLemonAddsLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }

    }
}
