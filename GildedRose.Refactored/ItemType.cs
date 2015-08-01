using System;

namespace GildedRose.Refactored
{
    public class ItemType : IEquatable<ItemType>
    {
        private readonly string _value;
        public static readonly ItemType BACKSTAGE_PASS = new ItemType("Backstage passes to a TAFKAL80ETC concert");
        public static readonly ItemType SULFURAS = new ItemType("Sulfuras, Hand of Ragnaros");
        public static readonly ItemType AGED_BRIE = new ItemType("Aged Brie");
        public static readonly ItemType CONJURED = new ItemType("Conjured Mana Cake");
        public static readonly ItemType ELIXIR = new ItemType("Elixir of the Mongoose");
        public static readonly ItemType SIMPLE = new ItemType("Simple Item");

        public ItemType(string value)
        {
            _value = value;
        }

        public bool Equals(ItemType other)
        {
            return this.ToString().Equals(other.ToString());
        }

        public override string ToString()
        {
            return _value;
        }

        public static implicit operator ItemType(string name)
        {
            return new ItemType(name);
        }
    }
}