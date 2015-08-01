using GildedRose.Refactored;

namespace TestUtility
{
    public class ItemBuilder : IFluentBuilder
    {
        private const int MAX_QUALITY = 50;
        private const int SULFURAS_QUALITY = 80;

        private readonly Item _item;
        //private ItemType _itemType;

        private ItemBuilder(ItemType type)
        {
            //_itemType = type;
            _item = new Item
                {
                    Name = type.ToString()
                };
        }

        IFluentBuilder IFluentBuilder.CreateItem(ItemType type)
        {
            return CreateItem(type);
        }

        public static IFluentBuilder CreateItem(ItemType type)
        {
            return new ItemBuilder(type);
        }

        //public virtual ItemBuilder WithName(string name)
        //{
        //    this.Item.Name = name;
        //    return this;
        //}

        public IFluentBuilder WithSellIn(int sellIn)
        {
            _item.SellIn = sellIn;
            return this;
        }

        public IFluentBuilder WithQuality(int quality)
        {
            _item.Quality = quality;
            return this;
        }

        public Item Build()
        {
            return _item;
        }
    }
}