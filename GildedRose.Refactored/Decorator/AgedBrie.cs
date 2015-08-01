using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose.Refactored
{
    internal class AgedBrieItem : ItemWrapper
    {
        public AgedBrieItem(Item item) : base(item)
        {
        }

        protected override int NormalAdjust
        {
            get
            {
                return -base.NormalAdjust;
            }
        }


    }
}
