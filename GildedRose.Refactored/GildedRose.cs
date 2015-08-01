using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRose.Refactored
{
    public class Program
    {
        public IList<Item> Items;
        static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var app = new Program()
            {
                Items = new List<Item>
                    {
                        new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                        new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                        new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                        new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                        new Item
                            {
                                Name = "Backstage passes to a TAFKAL80ETC concert",
                                SellIn = 15,
                                Quality = 20
                            },
                        new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                    }

            };

            app.UpdateQuality();

            Console.ReadKey();

        }

        public void UpdateQuality()
        {
            foreach (var item in Items.Select(ItemWrapper.Wrap))
                //UpdateItem(item);
                item.Update();
        }

        /*
        private void UpdateItem(ItemWrapper item)
        {
            if (item.Name == "Sulfuras, Hand of Ragnaros") return;

            UpdateSellIn(item);
            UpdateQuality(item);
        }

        private void UpdateQuality(ItemWrapper item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    IncreaseQuality(item);
                    if (item.SellIn < 0)
                        IncreaseQuality(item);
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    IncreaseQuality(item);
                    if (item.SellIn < 11)
                        IncreaseQuality(item);
                    if (item.SellIn < 6)
                        IncreaseQuality(item);
                    if (item.SellIn < 0)
                        item.Quality = 0;
                    break;
                default:
                    DecreaseQuality(item);
                    if (item.SellIn < 0)
                        DecreaseQuality(item);
                    break;
            }
        }

        private void DecreaseQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }
        }

        private void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }

        private void UpdateSellIn(Item item)
        {
            item.SellIn--;
        }
         * */
    }

    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
    }

}
