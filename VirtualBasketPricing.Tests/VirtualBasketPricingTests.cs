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
        [TestMethod]
        public void CalculateTotalPrice_Apple_3_Test()
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
                "Apple",
                "Apple"
            };
            var result = calcPricing.GetTotalPrice(itemsList);

            Assert.AreEqual(result, 20);
        }
        [TestMethod]
        public void CalculateTotalPrice_Apple_2_Orange_1_Test()
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
                "Apple",
                "Orange"
            };
            var result = calcPricing.GetTotalPrice(itemsList);

            Assert.AreEqual(result, 20);
        }
        [TestMethod]
        public void CalculateTotalPrice_Apple_2_Orange_2_Test()
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
                "Apple",
                "Orange",
                "Orange"
            };
            var result = calcPricing.GetTotalPrice(itemsList);

            Assert.AreEqual(result, 30);
        }
        [TestMethod]
        public void CalculateTotalPrice_Apple_3_Orange_2_Test()
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
                "Apple",
                "Orange",
                "Orange",
                "Apple"
            };
            var result = calcPricing.GetTotalPrice(itemsList);

            Assert.AreEqual(result, 40);
        }

        [TestMethod]
        public void CalculateTotalPrice_Apple_3_Orange_3_Test()
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
                "Apple",
                "Orange",
                "Orange",
                "Apple",
                "Orange"
            };
            var result = calcPricing.GetTotalPrice(itemsList);

            Assert.AreEqual(result, 40);
        }

        [TestMethod]
        public void CalculateTotalPrice_Apple_3_Orange_3_Kiwi_1_Test()
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
                "Apple",
                "Orange",
                "Orange",
                "Apple",
                "Orange",
                "Kiwi"
            };
            var result = calcPricing.GetTotalPrice(itemsList);

            Assert.AreEqual(result, 60);
        }
        [TestMethod]
        public void CalculateTotalPrice_Apple_3_Orange_3_Kiwi_1_Mango_1_Test()
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
                "Apple",
                "Orange",
                "Orange",
                "Apple",
                "Orange",
                "Kiwi",
                "Mango"
            };
            var result = calcPricing.GetTotalPrice(itemsList);

            Assert.AreEqual(result, 90);
        }
        [TestMethod]
        public void CalculateTotalPrice_ChangeRule_Apple_3_Orange_3_Kiwi_2_Mango_1_Test()
        {
            IList<Rule> rules = new List<Rule>();
            rules.Add(new Rule { ItemName = "Apple", Price = 10, NumberOfItemToBuy = 2, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Orange", Price = 10, NumberOfItemToBuy = 2, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Kiwi", Price = 20, NumberOfItemToBuy = 1, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Mango", Price = 30 });

            ICalculatePricing calcPricing = new CalculatePrice(rules);
            List<string> itemsList = new List<string>
            {
                "Apple",
                "Apple",
                "Orange",
                "Orange",
                "Apple",
                "Orange",
                "Kiwi",
                "Mango",
                "Kiwi"
            };
            var result = calcPricing.GetTotalPrice(itemsList);

            Assert.AreEqual(result, 90);
        }
        [TestMethod]
        public void CalculateTotalPrice_ChangeRule_Apple_3_Orange_3_Kiwi_3_Mango_1_Test()
        {
            IList<Rule> rules = new List<Rule>();
            rules.Add(new Rule { ItemName = "Apple", Price = 10, NumberOfItemToBuy = 2, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Orange", Price = 10, NumberOfItemToBuy = 2, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Kiwi", Price = 20, NumberOfItemToBuy = 1, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Mango", Price = 30 });

            ICalculatePricing calcPricing = new CalculatePrice(rules);
            List<string> itemsList = new List<string>
            {
                "Apple",
                "Apple",
                "Orange",
                "Orange",
                "Apple",
                "Orange",
                "Kiwi",
                "Mango",
                "Kiwi",
                "Kiwi"
            };
            var result = calcPricing.GetTotalPrice(itemsList);

            Assert.AreEqual(result, 110);
        }
        [TestMethod]
        public void CalculateTotalPrice_ChangeRule_Apple_3_Orange_3_Kiwi_3_Mango_4_Test()
        {
            IList<Rule> rules = new List<Rule>();
            rules.Add(new Rule { ItemName = "Apple", Price = 10, NumberOfItemToBuy = 2, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Orange", Price = 10, NumberOfItemToBuy = 2, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Kiwi", Price = 20, NumberOfItemToBuy = 1, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Mango", Price = 30, NumberOfItemToBuy = 3, NumberItemsForFree = 2 });

            ICalculatePricing calcPricing = new CalculatePrice(rules);
            List<string> itemsList = new List<string>
            {
                "Apple",
                "Apple",
                "Orange",
                "Orange",
                "Apple",
                "Orange",
                "Kiwi",
                "Mango",
                "Kiwi",
                "Kiwi",
                "Mango",
                "Mango",
                "Mango",
                "Mango"
            };
            var result = calcPricing.GetTotalPrice(itemsList);

            Assert.AreEqual(result, 170);
        }
        [TestMethod]
        public void CalculateTotalPrice_ChangeRule_Apple_3_Orange_3_Kiwi_3_Mango_4_Papaya_1_Test()
        {
            IList<Rule> rules = new List<Rule>();
            rules.Add(new Rule { ItemName = "Apple", Price = 10, NumberOfItemToBuy = 2, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Orange", Price = 10, NumberOfItemToBuy = 2, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Kiwi", Price = 20, NumberOfItemToBuy = 1, NumberItemsForFree = 1 });
            rules.Add(new Rule { ItemName = "Mango", Price = 30, NumberOfItemToBuy = 3, NumberItemsForFree = 2 });
            rules.Add(new Rule { ItemName = "Papaya", Price = 40, NumberOfItemToBuy = 3, NumberItemsForFree = 1 });

            ICalculatePricing calcPricing = new CalculatePrice(rules);
            List<string> itemsList = new List<string>
            {
                "Apple",
                "Apple",
                "Orange",
                "Orange",
                "Apple",
                "Orange",
                "Kiwi",
                "Mango",
                "Kiwi",
                "Kiwi",
                "Mango",
                "Mango",
                "Mango",
                "Mango",
                "Papaya",
                "Papaya",
                "Papaya",
                "Papaya"
            };
            var result = calcPricing.GetTotalPrice(itemsList);

            Assert.AreEqual(result, 290);
        }
    }
}
