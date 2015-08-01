using GildedRose.Refactored;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUtility;

namespace GildedRose.Test
{

    public class BaseTestClass
    {
        protected const int MAX_QUALITY = 50;
        protected const int STANDARD_DECREASE = 1;
        protected const int FAST_DECREASE = 2;
        protected const int STANDARD_INCREASE = 1;
        protected const int FAST_INCREASE = 2;
        protected const int ULTRAFAST_INCRESE = 3;
        protected const int EXPIRED = -1;

        //protected IList<Item> _items;
        protected Item ActualItem;

        protected void DoTest()
        {
            var sut = GildedUtility.SetUpGildedRose(ActualItem);
            sut.UpdateQuality();
        }

    }

    public class SpecialItemTestClass : BaseTestClass
    {
        [TestMethod]
        public void ValidItem_IncreaseQuality()
        {
            //Arrange
            int expectedQuality = ActualItem.Quality + STANDARD_INCREASE;

            //Act
            DoTest();

            //Assert
            Assert.AreEqual(expectedQuality, ActualItem.Quality);
        }

        [TestMethod]
        public void ValidItem_IncreaseQualityNoMoreThan50()
        {
            //Arrange
            const int expectedQuality = MAX_QUALITY;
            ActualItem.Quality = MAX_QUALITY;

            //Act
            DoTest();

            //Assert
            Assert.AreEqual(expectedQuality, ActualItem.Quality);
        }
    }
}
