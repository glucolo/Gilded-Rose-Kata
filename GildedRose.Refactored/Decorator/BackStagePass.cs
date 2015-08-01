using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose.Refactored
{
    internal class BackStagePassItem : ItemWrapper
    {
        public BackStagePassItem(Item item) : base(item)
        {
        }

        protected override int NormalAdjust
        {
            get
            {
                if (SellIn < 6)
                    return 3;
                if (SellIn < 11)
                    return 2;

                return 1;
            }
        }
        protected override int ExpiredAdjust 
        {
            get { return -Quality; }
        }

    }
}
