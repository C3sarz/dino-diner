using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    class MockOrderItem : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public double Price { get; } = 5.0;

        public string Description { get; } = "Something";

        public string[] Special { get; } = new string[0];

        public void Mutate()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }

    /// <summary>
    /// Tests that OrderItem properity changes (Special, Description, and Price)
    /// trigger PropertyChangedEvents as outlined in Menu Milestone 5.
    /// </summary>
    public class PropertyChangeTests
    {
        // Entrees

        #region Brontowurst

        [Fact]
        public void BrotowurstHoldBunShouldNotifyPropertyChanged()
        {
            Brontowurst bronto = new Brontowurst();
            Assert.PropertyChanged(bronto, "Special", () =>
            {
                bronto.HoldBun();
            });
        }

        [Fact]
        public void BrotowurstHoldOnionShouldNotifyPropertyChanged()
        {
            Brontowurst bronto = new Brontowurst();
            Assert.PropertyChanged(bronto, "Special", () =>
            {
                bronto.HoldOnion();
            });
        }

        [Fact]
        public void BrotowurstHoldPeppersShouldNotifyPropertyChanged()
        {
            Brontowurst bronto = new Brontowurst();
            Assert.PropertyChanged(bronto, "Special", () =>
            {
                bronto.HoldPeppers();
            });
        }

        #endregion

        #region DinoNuggets

        [Fact]
        public void DinoNuggetsAddNuggetShouldNotifyPropertyChanged()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.PropertyChanged(dn, "Special", () =>
            {
                dn.AddNugget();
            });
        }

        #endregion

        #region PrehistoricPBJ

        [Fact]
        public void PrehistoricPBJHoldPeanutButterShouldNotifyPropertyChanged()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldPeanutButter();
            });
        }

        [Fact]
        public void PrehistoricPBJHoldJellyShouldNotifyPropertyChanged()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldJelly();
            });
        }

        #endregion

        #region  PterodactylWings

        #endregion

        #region SteakosaurusBurger

        [Fact]
        public void SteakosaurusBurgerHoldBunShouldNotifyPropertyChanged()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldBun();
            });
        }

        [Fact]
        public void SteakosaurusBurgerHoldKetchupShouldNotifyPropertyChanged()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldKetchup();
            });
        }

        [Fact]
        public void SteakosaurusBurgerHoldMustardShouldNotifyPropertyChanged()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldMustard();
            });
        }

        [Fact]
        public void SteakosaurusBurgerHoldPickleShouldNotifyPropertyChanged()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldPickle();
            });
        }

        #endregion

        #region TRexKingBurger

        [Fact]
        public void TRexKingBurgerHoldBunShouldNotifyPropertyChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldBun();
            });
        }

        [Fact]
        public void TRexKingBurgerHoldKetchupShouldNotifyPropertyChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldKetchup();
            });
        }

        [Fact]
        public void TRexKingBurgerHoldMustardShouldNotifyPropertyChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldMustard();
            });
        }

        [Fact]
        public void TRexKingBurgerMayoBunShouldNotifyPropertyChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldMayo();
            });
        }

        [Fact]
        public void TRexKingBurgerHoldPickleShouldNotifyPropertyChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldPickle();
            });
        }

        [Fact]
        public void TRexKingBurgerHoldOnionShouldNotifyPropertyChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldOnion();
            });
        }

        [Fact]
        public void TRexKingBurgerHoldTomatoShouldNotifyPropertyChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldTomato();
            });
        }

        [Fact]
        public void TRexKingBurgerHoldLettuceShouldNotifyPropertyChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldLettuce();
            });
        }


        #endregion

        #region VelociWrap

        [Fact]
        public void VelociwrapHoldCheeseShouldNotifyPropertyChanged()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Special", () =>
            {
                wrap.HoldCheese();
            });
        }

        [Fact]
        public void VelociwrapHoldDressingShouldNotifyPropertyChanged()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Special", () =>
            {
                wrap.HoldDressing();
            });
        }

        [Fact]
        public void VelociwrapHoldLettuceShouldNotifyPropertyChanged()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Special", () =>
            {
                wrap.HoldLettuce();
            });
        }

        #endregion

        // Sides 

        #region Fryceritops

        [Theory]
        [InlineData(Size.Large, "Description")]
        [InlineData(Size.Medium, "Description")]
        [InlineData(Size.Small, "Description")]
        [InlineData(Size.Large, "Price")]
        [InlineData(Size.Medium, "Price")]
        [InlineData(Size.Small, "Price")]
        public void FrycertiopsSizeChangeShouldNotifyPropertyChanged(Size size, string propertyName)
        {
            Fryceritops fries = new Fryceritops();
            Assert.PropertyChanged(fries, propertyName, () =>
            {
                fries.Size = size;
            });
        }

        #endregion

        #region Triceritops

        [Theory]
        [InlineData(Size.Large, "Description")]
        [InlineData(Size.Medium, "Description")]
        [InlineData(Size.Small, "Description")]
        [InlineData(Size.Large, "Price")]
        [InlineData(Size.Medium, "Price")]
        [InlineData(Size.Small, "Price")]
        public void TriceritopsSizeChangeShouldNotifyPropertyChanged(Size size, string propertyName)
        {
            Triceritots tots = new Triceritots();
            Assert.PropertyChanged(tots, propertyName, () =>
            {
                tots.Size = size;
            });
        }

        #endregion

        #region MeteorMacAndCheese

        [Theory]
        [InlineData(Size.Large, "Description")]
        [InlineData(Size.Medium, "Description")]
        [InlineData(Size.Small, "Description")]
        [InlineData(Size.Large, "Price")]
        [InlineData(Size.Medium, "Price")]
        [InlineData(Size.Small, "Price")]
        public void MeteorMacAndCheeseSizeChangeShouldNotifyPropertyChanged(Size size, string propertyName)
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            Assert.PropertyChanged(mac, propertyName, () =>
            {
                mac.Size = size;
            });
        }

        #endregion

        #region MezzorellaSticks

        [Theory]
        [InlineData(Size.Large, "Description")]
        [InlineData(Size.Medium, "Description")]
        [InlineData(Size.Small, "Description")]
        [InlineData(Size.Large, "Price")]
        [InlineData(Size.Medium, "Price")]
        [InlineData(Size.Small, "Price")]
        public void MezzorellaSticksSizeChangeShouldNotifyPropertyChanged(Size size, string propertyName)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.PropertyChanged(ms, propertyName, () =>
            {
                ms.Size = size;
            });
        }

        #endregion

        // Drinks

        #region JurassicJava 

        [Theory]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Medium, "Price")]
        [InlineData(Size.Large, "Price")]
        [InlineData(Size.Small, "Description")]
        [InlineData(Size.Medium, "Description")]
        [InlineData(Size.Large, "Description")]
        public void JurassicJavaSizeChangeShouldNotifyProperties(Size size, string property)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, property, () =>
            {
                java.Size = size;
            });
        }

        [Fact]
        public void JurrasicJavaAddIceShouldNotifyPropertySpecial()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.AddIce();
            });
        }

        [Fact]
        public void JurrasicJavaLeaveRoomForCreamShouldNotifyPropertySpecial()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.LeaveRoomForCream();
            });
        }



        #endregion

        #region Sodasaurus 

        [Theory]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Medium, "Price")]
        [InlineData(Size.Large, "Price")]
        [InlineData(Size.Small, "Description")]
        [InlineData(Size.Medium, "Description")]
        [InlineData(Size.Large, "Description")]
        public void SodasaurusChangeSizeShouldNotifyProperty(Size size, string property)
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, property, () =>
            {
                soda.Size = size;
            });
        }

        [Fact]
        public void SodasaurusHoldIceShouldNotifyPropertySpecial()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Special", () =>
            {
                soda.HoldIce();
            });
        }

        [Theory]
        [InlineData(SodasaurusFlavor.Cherry)]
        [InlineData(SodasaurusFlavor.Chocolate)]
        [InlineData(SodasaurusFlavor.Cola)]
        [InlineData(SodasaurusFlavor.Lime)]
        [InlineData(SodasaurusFlavor.Orange)]
        [InlineData(SodasaurusFlavor.RootBeer)]
        [InlineData(SodasaurusFlavor.Vanilla)]
        public void SodasaurusChangeFlavorShouldNotifyPropertyDescription(SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () =>
            {
                soda.Flavor = flavor;
            });
        }

        #endregion

        #region Tyrannotea 

        [Theory]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Medium, "Price")]
        [InlineData(Size.Large, "Price")]
        [InlineData(Size.Small, "Description")]
        [InlineData(Size.Medium, "Description")]
        [InlineData(Size.Large, "Description")]
        public void TyrannoteaSizeChangeShouldNotifyProperty(Size size, string property)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, property, () =>
            {
                tea.Size = size;
            });
        }

        [Fact]
        public void TyrannoteaSetSweetShouldNotifyPropertyDescription()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () =>
            {
                tea.Sweet = true;
            });
        }

        [Fact]
        public void TyrannoteaAddLemonShouldNotifyPropertyChanged()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.AddLemon();
            });
        }

        [Fact]
        public void TyrannoteaHoldIceShouldNotifySpecialPropertyChanged()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.HoldIce();
            });
        }

        #endregion

        #region Water 

        [Theory]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Medium, "Price")]
        [InlineData(Size.Large, "Price")]
        [InlineData(Size.Small, "Description")]
        [InlineData(Size.Medium, "Description")]
        [InlineData(Size.Large, "Description")]
        public void WaterSizeChangeShouldNotifyProperty(Size size, string property)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, property, () =>
            {
                water.Size = size;
            });
        }

        [Fact]
        public void WaterAddLemonShouldNotifyPropertyChanged()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.AddLemon();
            });
        }

        [Fact]
        public void WaterHoldIceShouldNotifySpecialPropertyChanged()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.HoldIce();
            });
        }

        #endregion

        // Combos

        #region CretaceousCombo

        [Theory]
        [InlineData(typeof(Brontowurst), Size.Large, "Description")]
        [InlineData(typeof(Brontowurst), Size.Medium, "Description")]
        [InlineData(typeof(Brontowurst), Size.Small, "Description")]
        [InlineData(typeof(Brontowurst), Size.Large, "Price")]
        [InlineData(typeof(Brontowurst), Size.Medium, "Price")]
        [InlineData(typeof(Brontowurst), Size.Small, "Price")]
        [InlineData(typeof(Brontowurst), Size.Large, "Special")]
        [InlineData(typeof(Brontowurst), Size.Medium, "Special")]
        [InlineData(typeof(Brontowurst), Size.Small, "Special")]
        [InlineData(typeof(DinoNuggets), Size.Large, "Description")]
        [InlineData(typeof(DinoNuggets), Size.Medium, "Description")]
        [InlineData(typeof(DinoNuggets), Size.Small, "Description")]
        [InlineData(typeof(DinoNuggets), Size.Large, "Price")]
        [InlineData(typeof(DinoNuggets), Size.Medium, "Price")]
        [InlineData(typeof(DinoNuggets), Size.Small, "Price")]
        [InlineData(typeof(DinoNuggets), Size.Large, "Special")]
        [InlineData(typeof(DinoNuggets), Size.Medium, "Special")]
        [InlineData(typeof(DinoNuggets), Size.Small, "Special")]
        [InlineData(typeof(PrehistoricPBJ), Size.Large, "Description")]
        [InlineData(typeof(PrehistoricPBJ), Size.Medium, "Description")]
        [InlineData(typeof(PrehistoricPBJ), Size.Small, "Description")]
        [InlineData(typeof(PrehistoricPBJ), Size.Large, "Price")]
        [InlineData(typeof(PrehistoricPBJ), Size.Medium, "Price")]
        [InlineData(typeof(PrehistoricPBJ), Size.Small, "Price")]
        [InlineData(typeof(PrehistoricPBJ), Size.Large, "Special")]
        [InlineData(typeof(PrehistoricPBJ), Size.Medium, "Special")]
        [InlineData(typeof(PrehistoricPBJ), Size.Small, "Special")]
        [InlineData(typeof(PterodactylWings), Size.Large, "Description")]
        [InlineData(typeof(PterodactylWings), Size.Medium, "Description")]
        [InlineData(typeof(PterodactylWings), Size.Small, "Description")]
        [InlineData(typeof(PterodactylWings), Size.Large, "Price")]
        [InlineData(typeof(PterodactylWings), Size.Medium, "Price")]
        [InlineData(typeof(PterodactylWings), Size.Small, "Price")]
        [InlineData(typeof(PterodactylWings), Size.Large, "Special")]
        [InlineData(typeof(PterodactylWings), Size.Medium, "Special")]
        [InlineData(typeof(PterodactylWings), Size.Small, "Special")]
        [InlineData(typeof(SteakosaurusBurger), Size.Large, "Description")]
        [InlineData(typeof(SteakosaurusBurger), Size.Medium, "Description")]
        [InlineData(typeof(SteakosaurusBurger), Size.Small, "Description")]
        [InlineData(typeof(SteakosaurusBurger), Size.Large, "Price")]
        [InlineData(typeof(SteakosaurusBurger), Size.Medium, "Price")]
        [InlineData(typeof(SteakosaurusBurger), Size.Small, "Price")]
        [InlineData(typeof(SteakosaurusBurger), Size.Large, "Special")]
        [InlineData(typeof(SteakosaurusBurger), Size.Medium, "Special")]
        [InlineData(typeof(SteakosaurusBurger), Size.Small, "Special")]
        [InlineData(typeof(TRexKingBurger), Size.Large, "Description")]
        [InlineData(typeof(TRexKingBurger), Size.Medium, "Description")]
        [InlineData(typeof(TRexKingBurger), Size.Small, "Description")]
        [InlineData(typeof(TRexKingBurger), Size.Large, "Price")]
        [InlineData(typeof(TRexKingBurger), Size.Medium, "Price")]
        [InlineData(typeof(TRexKingBurger), Size.Small, "Price")]
        [InlineData(typeof(TRexKingBurger), Size.Large, "Special")]
        [InlineData(typeof(TRexKingBurger), Size.Medium, "Special")]
        [InlineData(typeof(TRexKingBurger), Size.Small, "Special")]
        [InlineData(typeof(VelociWrap), Size.Large, "Description")]
        [InlineData(typeof(VelociWrap), Size.Medium, "Description")]
        [InlineData(typeof(VelociWrap), Size.Small, "Description")]
        [InlineData(typeof(VelociWrap), Size.Large, "Price")]
        [InlineData(typeof(VelociWrap), Size.Medium, "Price")]
        [InlineData(typeof(VelociWrap), Size.Small, "Price")]
        [InlineData(typeof(VelociWrap), Size.Large, "Special")]
        [InlineData(typeof(VelociWrap), Size.Medium, "Special")]
        [InlineData(typeof(VelociWrap), Size.Small, "Special")]
        public void CretaceousComboChangingSizeShouldNotifyPropertyChanges(Type type, Size size, string propertyName)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.PropertyChanged(combo, propertyName, () =>
            {
                combo.Size = size;
            });
        }

        #endregion

        // Order 

        #region Order 

        [Theory]
        [InlineData("Items")]
        [InlineData("TotalCost")]
        [InlineData("SalesTaxCost")]
        [InlineData("SubtotalCost")]
        public void OrderAddingItemsShouldNotifyPropertyChange(string propertyName)
        {
            Order order = new Order();
            MockOrderItem item = new MockOrderItem();
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Add(item);
            });
        }

        [Theory]
        [InlineData("Items")]
        [InlineData("TotalCost")]
        [InlineData("SalesTaxCost")]
        [InlineData("SubtotalCost")]
        public void OrderRemovingItemsShouldNotifyPropertyChange(string propertyName)
        {
            Order order = new Order();
            MockOrderItem item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Remove(item);
            });
        }

        [Theory]
        [InlineData("TotalCost")]
        [InlineData("SalesTaxCost")]
        [InlineData("SubtotalCost")]
        public void OrderItemMutatingShouldNotifyPropertyChange(string propertyName)
        {
            Order order = new Order();
            MockOrderItem item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, propertyName, () =>
            {
                item.Mutate();
            });
        }

        #endregion
    }
}
