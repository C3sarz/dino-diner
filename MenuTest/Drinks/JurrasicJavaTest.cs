using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using Xunit;

namespace DinoDiner.MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        //The correct default price, calories, ice, size, cream space properties.

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Equal<double>(0.59, coffee.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Equal<uint>(2, coffee.Calories);

        }

        [Fact]
        public void ShouldHaveDefaultNoIce()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.False(coffee.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, coffee.Size);
        }

        [Fact]
        public void ShouldHaveDefaultNoRoomForCream()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.False(coffee.RoomForCream);
        }

        //The correct price and calories after changing to small, medium, and large sizes.

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Small;
            Assert.Equal<double>(0.59, coffee.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<double>(0.99, coffee.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Large;
            Assert.Equal<double>(1.49, coffee.Price);
        }

        //Correct calories after changing size.

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Small;
            Assert.Equal<uint>(2, coffee.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<uint>(4, coffee.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Large;
            Assert.Equal<uint>(8, coffee.Calories);

        }

        //Invoking AddIce() results in the Ice property being true.

        [Fact]
        public void AddIceAddsIce()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.AddIce();
            Assert.True(coffee.Ice);
        }

        //Invoking LeaveRoomForCream() results in the RoomForCream property being true.

        [Fact]
        public void LeavesRoomForCream()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.LeaveRoomForCream();
            Assert.True(coffee.RoomForCream);
        }
    }
}
