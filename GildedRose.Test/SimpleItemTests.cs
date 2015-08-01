using System;
using GildedRose.Refactored;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUtility;

namespace GildedRose.Test
{
    [TestClass]
    public class SimpleItemTests : BaseTestClass
    {
        [TestInitialize]
        public void SetUp()
        {
            ActualItem = GildedUtility.CreateElixir()
                                    .WithQuality(10)
                                    .WithSellIn(10)
                                    .Build();
        }

        #region Valid Item
        [TestMethod]
        public void ValidSimpleItem_DecreaseQuality()
        {
            var expectedQuality = ActualItem.Quality - STANDARD_DECREASE;

            DoTest();

            Assert.AreEqual(expectedQuality, ActualItem.Quality);
        }

        [TestMethod]
        public void ValidSimpleItem_DecreaseSellIn()
        {
            var expectedSellIn = ActualItem.SellIn - STANDARD_DECREASE;

            DoTest();

            Assert.AreEqual(expectedSellIn, ActualItem.SellIn);
        }

        [TestMethod]
        public void ZeroQualitySimpleItem_DoNotDecreaseQuality()
        {
            //Arrange
            const int expectedQuality = 0;
            ActualItem.Quality = expectedQuality;

            //Act
            DoTest();

            //Assert
            Assert.AreEqual(expectedQuality, ActualItem.Quality);
        }
        #endregion

        #region Expired Item
        [TestMethod]
        public void ExpiredSimpleItem_TwiceDecreaseQuality()
        {
            ActualItem.SellIn = EXPIRED;
            var expectedQuality = ActualItem.Quality - FAST_DECREASE;

            DoTest();

            Assert.AreEqual(expectedQuality, ActualItem.Quality);
        }
        [TestMethod]
        public void ExpiredSimpleItem_DecreaseSellIn()
        {
            ActualItem.SellIn = EXPIRED;
            var expectedSellIn = ActualItem.SellIn - STANDARD_DECREASE;

            DoTest();

            Assert.AreEqual(expectedSellIn, ActualItem.SellIn);
        }
        public void ZeroQualityExpiredSimpleItem_DoNotDecreaseQuality()
        {
            //Arrange
            const int expectedQuality = 0;
            ActualItem.SellIn = EXPIRED;
            ActualItem.Quality = 0;

            //Act
            DoTest();

            //Assert
            Assert.AreEqual(expectedQuality, ActualItem.Quality);
        }
        [TestMethod]
        public void OneQualityExpiredSimpleItem_DoNotGoUnderZero()
        {
            //Arrange
            const int expectedQuality = 0;
            ActualItem.SellIn = EXPIRED;
            ActualItem.Quality = 1;

            //Act
            DoTest();

            //Assert
            Assert.AreEqual(expectedQuality, ActualItem.Quality);
        }
        #endregion
    }
}
