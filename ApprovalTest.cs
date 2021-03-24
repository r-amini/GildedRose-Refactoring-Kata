using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace csharp
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class ApprovalTest
    {
        [Test]
        public void UpdateQuality()
        {
            CombinationApprovals.VerifyAllCombinations(
                            this.TestUpdate,
                            new string[] {
                                "Aged Brie",
                                "Backstage passes to a TAFKAL80ETC concert",
                                "Sulfuras, Hand of Ragnaros",
                                "Elixir of the Mongoose",
                                "Conjured Mana Cake"},
                            new int[] { -1, 0, 4, 6, 8, 11 },
                            new int[] { 0, 1, 2, 50 }
                    );
        }

        private string TestUpdate(string name, int sellIn, int quality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            return Items[0].ToString();
        }
    }
}
