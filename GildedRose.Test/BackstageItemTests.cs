using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUtility;

namespace GildedRose.Test
{
    [TestClass]
    public class BackstageItemTests : SpecialItemTestClass
    {
        [TestInitialize]
        public void SetUp()
        {
            ActualItem = GildedUtility.CreateBackstagePass()
                                      .WithSellIn(20)
                                      .WithQuality(20)
                                      .Build();
        }

        [TestMethod]
        public void ValidItem_Less10ggToDue_IncreseQualityTwice()
        {
            var expectedQuality = ActualItem.Quality + FAST_INCREASE;
            ActualItem.SellIn = 10;

            DoTest();

            Assert.AreEqual(expectedQuality, ActualItem.Quality);
        }

        [TestMethod]
        public void ValidItem_Less5ggToDue_IncreseQualityTer()
        {
            //Arrange
            var expectedQuality = ActualItem.Quality + ULTRAFAST_INCRESE;
            ActualItem.SellIn = 5;

            //Act
            DoTest();

            //Assert
            Assert.AreEqual(expectedQuality, ActualItem.Quality);
        }

        [TestMethod]
        public void ExpiredItem_QualityDropTo0()
        {
            //Arrange
            const int expectedQuality = 0;
            ActualItem.SellIn = 0;

            //Act
            DoTest();

            //Assert
            Assert.AreEqual(expectedQuality, ActualItem.Quality);
        }

    }
}
