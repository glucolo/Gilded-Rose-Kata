using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GildedRose.Refactored;

namespace TestUtility
{
    public static class GildedUtility
    {
        private const int SULFURAS_QUALITY = 80;

        public static Program SetUpGildedRose(Item item)
        {
            var items = new Item[] {item};
            return SetUpGildedRose(items);
        }

        public static Program SetUpGildedRose(IEnumerable<Item> items)
        {
            return new Program
            {
                Items = new List<Item>(items)
            };
        }

        public static IFluentBuilder CreateBackstagePass()
        {
            return ItemBuilder.CreateItem(ItemType.BACKSTAGE_PASS);
        }
        public static IFluentBuilder CreateElixir()
        {
            return ItemBuilder.CreateItem(ItemType.ELIXIR);
        }
        public static IFluentBuilder CreateAgedBrie()
        {
            return ItemBuilder.CreateItem(ItemType.AGED_BRIE);
        }
        public static IFluentBuilder CreateClojured()
        {
            return ItemBuilder.CreateItem(ItemType.CONJURED);
        }
        public static IFluentBuilder CreateSulfuras()
        {
            return ItemBuilder.CreateItem(ItemType.SULFURAS).WithQuality(SULFURAS_QUALITY);
        }
    }

    #region Derived Builder
    //internal class BackstagePassBuilder : ItemBuilder, IItemBuilder
    //{
    //    public BackstagePassBuilder()
    //        : base(ItemType.BACKSTAGE_PASS)
    //    {

    //    }

    //    public static IFluentBuilder CreateItem()
    //    {
    //        return new BackstagePassBuilder();
    //    }

    //    IFluentBuilder IItemBuilder.CreateItem()
    //    {
    //        return BackstagePassBuilder.CreateItem();
    //    }
    //}

    //internal class AgedBrieBuilder : ItemBuilder, IItemBuilder
    //{
    //    public AgedBrieBuilder() : base(ItemType.AGED_BRIE)
    //    {
    //    }

    //    public static IFluentBuilder CreateItem()
    //    {
    //        return new AgedBrieBuilder();
    //    }
    //    IFluentBuilder IItemBuilder.CreateItem()
    //    {
    //        return CreateItem();
    //    }
    //}

    //internal class ElixirBuilder : ItemBuilder, IItemBuilder
    //{
    //    public ElixirBuilder()
    //        : base(ItemType.ELIXIR)
    //    {
    //    }

    //    public static IFluentBuilder CreateItem()
    //    {
    //        return new ElixirBuilder();
    //    }
    //    IFluentBuilder IItemBuilder.CreateItem()
    //    {
    //        return CreateItem();
    //    }
    //}

    //internal class SulfurasBuilder : ItemBuilder, IItemBuilder
    //{
    //    public SulfurasBuilder()
    //        : base(ItemType.SULFURAS)
    //    {
    //    }

    //    public static IFluentBuilder CreateItem()
    //    {
    //        return new SulfurasBuilder();
    //    }
    //    IFluentBuilder IItemBuilder.CreateItem()
    //    {
    //        return CreateItem();
    //    }
    //}

    //internal class ConjuredBuilder : ItemBuilder, IItemBuilder
    //{
    //    public ConjuredBuilder()
    //        : base(ItemType.CONJURED)
    //    {
    //    }

    //    public static IFluentBuilder CreateItem()
    //    {
    //        return new ConjuredBuilder();
    //    }
    //    IFluentBuilder IItemBuilder.CreateItem()
    //    {
    //        return CreateItem();
    //    }
    //}
    #endregion

}
