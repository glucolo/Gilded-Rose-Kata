using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose.Refactored
{
    public class ConjuredItem : ItemWrapper
    {
        public ConjuredItem(Item item) : base(item)
        {
        }

        protected override int NormalAdjust
        {
            get
            {
                return 2*base.NormalAdjust;
            }
        }


    }
}
