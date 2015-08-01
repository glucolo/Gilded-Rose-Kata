using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUtility;

namespace GildedRose.Test
{
    [TestClass]
    public class AgedBrieItemTests : SpecialItemTestClass
    {
        [TestInitialize]
        public void SetUp()
        {
            ActualItem = GildedUtility.CreateAgedBrie()
                                      .WithSellIn(10)
                                      .WithQuality(10)
                                      .Build();
        }

        [TestMethod]
        public void ExpiredItem_IncreaseQualityTwice()
        {
            //Arrange
            ActualItem.SellIn = EXPIRED;
            var expectedQuality = ActualItem.Quality + FAST_INCREASE;

            //Act
            DoTest();

            //Assert
            Assert.AreEqual(expectedQuality, ActualItem.Quality);
        }


        [TestMethod]
        public void ExpiredItem_QualityNoMoreThan50()
        {
            //Arrange
            const int expectedQuality = MAX_QUALITY;
            ActualItem.Quality = MAX_QUALITY;
            ActualItem.SellIn = EXPIRED;

            //Act
            DoTest();

            //Assert
            Assert.AreEqual(expectedQuality, ActualItem.Quality);
        }
    }
}
