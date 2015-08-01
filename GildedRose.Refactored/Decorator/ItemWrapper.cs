namespace GildedRose.Refactored
{
    /// <summary>
    /// Decorator per la classe Item
    /// </summary>
    public abstract class ItemWrapper : Item
    {
        private readonly Item _item;

        protected virtual int NormalAdjust { get { return -1; } }
        protected virtual int ExpiredAdjust { get { return 2*NormalAdjust; } }

        public static ItemWrapper Wrap(Item item)
        {
            return ItemFactory.CreateItem((ItemType) item.Name, item);
            
        }

        protected ItemWrapper(Item item)
        {
            _item = item;
        }

        public new string Name
        {
            get { return _item.Name; }
            set { _item.Name = value; }
        }

        public new int SellIn
        {
            get { return _item.SellIn; }
            set { _item.SellIn = value; }
        }

        public new int Quality
        {
            get { return _item.Quality; }
            set
            {
                _item.Quality = value;
                if (_item.Quality < 0) _item.Quality = 0;
                if (_item.Quality > 50) _item.Quality = 50;
            }
        }

        public virtual void Update()
        {
            if ("Sulfuras, Hand of Ragnaros".Equals(Name)) return;
            UpdateSellIn();
            UpdateQuality();
        }

        private void UpdateSellIn()
        {
            SellIn--;
        }

        private void UpdateQuality()
        {
            Quality += QualityAdjustment();
        }

        protected internal virtual int QualityAdjustment()
        {
            if (SellIn < 0)
                return ExpiredAdjust;

            return NormalAdjust;
        }

    }
}