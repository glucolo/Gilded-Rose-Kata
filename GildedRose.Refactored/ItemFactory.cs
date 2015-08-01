using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GildedRose.Refactored
{
    internal class ItemFactory
    {
        private static readonly IDictionary<ItemType, Type> _items = new Dictionary<ItemType, Type>
            {
                {ItemType.AGED_BRIE, typeof(AgedBrieItem)},
                {ItemType.BACKSTAGE_PASS, typeof(BackStagePassItem)},
                {ItemType.CONJURED, typeof(ConjuredItem)},
                {ItemType.ELIXIR, typeof(StandardItem)},
                {ItemType.SIMPLE, typeof(StandardItem)},
                {ItemType.SULFURAS, typeof(LegendaryItem)}
            }; 
        protected internal static ItemWrapper CreateItem(ItemType type, Item item)
        {
            Type itemClass = _items.FirstOrDefault(i => i.Key.Equals(type)).Value;
            return Activator.CreateInstance(itemClass, item) as ItemWrapper;
            //var ctor = itemClass.GetConstructor(new[] { typeof(Item) });
            //if (ctor != null) return ctor.Invoke(new object[] {item}) as ItemWrapper;
            //return null;
            //switch (item.Name)
            //{
            //    case "Aged Brie":
            //        return new AgedBrieItem(item);
            //    case "Backstage passes to a TAFKAL80ETC concert":
            //        return new BackStagePassItem(item);
            //    case "Conjured Mana Cake":
            //        return new ConjuredItem(item);
            //    case "Sulfuras, Hand of Ragnaros":
            //        return new LegendaryItem(item);
            //    default:
            //        return new ItemWrapper(item);
            //}
        }
    }

}
