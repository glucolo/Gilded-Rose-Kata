using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GildedRose.Refactored;

namespace TestUtility
{
    internal interface IItemBuilder
    {
    }

    public interface IFluentBuilder
    {
        IFluentBuilder CreateItem(ItemType type);
        IFluentBuilder WithSellIn(int sellIn);
        IFluentBuilder WithQuality(int quality);
        Item Build();
    }
}
