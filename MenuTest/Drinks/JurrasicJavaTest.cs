/* Class: JurassicJavaTest.cs
* Author: Cesar Zavala
*/
using DinoDiner.Menu;
using Xunit;

namespace DinoDiner.MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        //The correct default price, calories, ice, size, cream space properties.

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Equal<double>(0.59, coffee.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Equal<uint>(2, coffee.Calories);

        }

        [Fact]
        public void ShouldHaveDefaultNoIce()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.False(coffee.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Equal<Size>(Size.Small, coffee.Size);
        }

        [Fact]
        public void ShouldHaveDefaultNoRoomForCream()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.False(coffee.RoomForCream);
        }

        //The correct price and calories after changing to small, medium, and large sizes.

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Small;
            Assert.Equal<double>(0.59, coffee.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<double>(0.99, coffee.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Large;
            Assert.Equal<double>(1.49, coffee.Price);
        }

        //Correct calories after changing size.

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Small;
            Assert.Equal<uint>(2, coffee.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<uint>(4, coffee.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Large;
            Assert.Equal<uint>(8, coffee.Calories);

        }

        //Invoking AddIce() results in the Ice property being true.

        [Fact]
        public void AddIceAddsIce()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.AddIce();
            Assert.True(coffee.Ice);
        }

        //Invoking LeaveRoomForCream() results in the RoomForCream property being true.

        [Fact]
        public void LeavesRoomForCream()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.LeaveRoomForCream();
            Assert.True(coffee.RoomForCream);
        }

        //Special property tests

        [Fact]
        public void SpecialShouldContainRoomForCream()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.LeaveRoomForCream();
            Assert.Collection<string>(coffee.Special,
            item => Assert.Equal("Room for Cream", item));
        }

        [Fact]
        public void SpecialShouldContainIce()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.AddIce();
            Assert.Collection<string>(coffee.Special,
            item => Assert.Equal("Add Ice", item));
        }

        [Fact]
        public void SpecialShouldContainAll()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.LeaveRoomForCream();
            coffee.AddIce();
            Assert.Collection<string>(coffee.Special,
                item => Assert.Equal("Room for Cream", item),
                item => Assert.Equal("Add Ice", item));
        }

        [Fact]
        public void SetSizeNotifyChanges()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.PropertyChanged(coffee, "Size", () => coffee.Size = Size.Large);
            Assert.PropertyChanged(coffee, "Calories", () => coffee.Size = Size.Large);
            Assert.PropertyChanged(coffee, "Price", () => coffee.Size = Size.Large);
        }

        [Fact]
        public void RoomForCreamNotifyChanges()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.PropertyChanged(coffee, "Ingredients", () => coffee.LeaveRoomForCream());
            Assert.PropertyChanged(coffee, "Special", () => coffee.LeaveRoomForCream());
        }

        [Fact]
        public void AddIceNotifyChanges()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.PropertyChanged(coffee, "Special", () => coffee.AddIce());
        }
    }
}

