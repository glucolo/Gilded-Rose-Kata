using System;
using System.Collections.Generic;
using GildedRose.Refactored;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUtility;

namespace GildedRose.Test
{
    [TestClass]
    public class SulfurasItemTests : BaseTestClass
    {
        [TestInitialize]
        public void SetUp()
        {
            ActualItem = GildedUtility.CreateSulfuras()
                                      .WithSellIn(10)
                                      .Build();
        }

        [TestMethod]
        public void ValidSulfurasItem_NeverChangeQuality()
        {
            //Arrange
            var expectedQuality = ActualItem.Quality;

            //Act
            base.DoTest();

            //Assert
            Assert.AreEqual(expectedQuality, ActualItem.Quality);
        }

        [TestMethod]
        public void ValidSulfurasItem_NeverChangeSellIn()
        {
            //Arrange
            var expectedSellIn = ActualItem.SellIn;

            //Act
            DoTest();

            //Assert
            Assert.AreEqual(expectedSellIn, ActualItem.SellIn);
        }

        [TestMethod]
        public void ExpiredSulfurasItem_NeverChangeQuality()
        {
            //Arrange
            ActualItem.SellIn = EXPIRED;
            var expectedQuality = ActualItem.Quality;
            //Act
            base.DoTest();

            //Assert
            Assert.AreEqual(expectedQuality, ActualItem.Quality);
        }

        [TestMethod]
        public void ExpiredSulfurasItem_NeverChangeSellIn()
        {
            //Arrange
            ActualItem.SellIn = EXPIRED;
            var expectedSellIn = EXPIRED;
            //Act
            base.DoTest();

            //Assert
            Assert.AreEqual(expectedSellIn, ActualItem.SellIn);
        }
    }
}
