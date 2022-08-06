using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace VirtualBasketPricing.Tests
{
    [TestClass]
    public class VirtualBasketPricingTests
    {
        [TestMethod]
        public void CalculateTotalPrice_Apple_1_Test()
        {
            IList<Rule> rules = new List<Rule>();
            rules.Add(new Rule { ItemName = "Apple", Price = 10, NumberOfItemToBuy = 2, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Orange", Price = 10, NumberOfItemToBuy = 2, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Kiwi", Price = 20 });
            rules.Add(new Rule { ItemName = "Mango", Price = 30 });

            ICalculatePricing calcPricing = new CalculatePrice(rules);
            List<string> itemsList = new List<string> 
            { 
                "Apple"
            };
            var result = calcPricing.GetTotalPrice(itemsList);

            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void CalculateTotalPrice_Apple_2_Test()
        {
            IList<Rule> rules = new List<Rule>();
            rules.Add(new Rule { ItemName = "Apple", Price = 10, NumberOfItemToBuy = 2, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Orange", Price = 10, NumberOfItemToBuy = 2, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Kiwi", Price = 20 });
            rules.Add(new Rule { ItemName = "Mango", Price = 30 });

            ICalculatePricing calcPricing = new CalculatePrice(rules);
            List<string> itemsList = new List<string>
            {
                "Apple",
                "Apple"
            };
            var result = calcPricing.GetTotalPrice(itemsList);

            Assert.AreEqual(result, 20);
        }
        
    }
}
