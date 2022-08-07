using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBasketPricing
{
    public class CalculatePrice : ICalculatePricing
    {
        private readonly IEnumerable<Rule> _rules;
        private readonly Dictionary<RuleItem, List<string>> rulesDict = new Dictionary<RuleItem, List<string>>();
        private List<string> _NonPromotionItems = new List<string>();
        public CalculatePrice(IEnumerable<Rule> rules)
        {
            _rules = rules;
            LoadItemsWithCount(rules);
        }
        /// <summary>
        /// Calculate total price
        /// </summary>
        /// <param name="selectedItems"></param>
        /// <returns></returns>
        public int GetTotalPrice(IList<string> selectedItems)
        {
            _NonPromotionItems = selectedItems.ToList();
            int totalPrice = 0;
            foreach (var item in rulesDict)
            {
                var itemCount = 0;
                var getRuleItems = item.Value;
                foreach (var ruleItem in getRuleItems)
                {
                    itemCount += selectedItems.Where(i => i == ruleItem).Count();
                    _NonPromotionItems.RemoveAll(x => x == ruleItem);
                }

                var numberOfPromotionItems = item.Key.NumberItemsForFree + item.Key.NumberOfItemToBuy;
                var amount = _rules.Where(r => r.NumberItemsForFree == item.Key.NumberItemsForFree &&
                                                    r.NumberOfItemToBuy == item.Key.NumberOfItemToBuy).Select(rs => rs.Price).FirstOrDefault();

                if (numberOfPromotionItems > 0 && itemCount >= numberOfPromotionItems)
                {
                    var quoientValue = (itemCount / numberOfPromotionItems) * item.Key.NumberOfItemToBuy;
                    var remainderValue = itemCount % numberOfPromotionItems;

                    var totalItemsToCalculate = quoientValue + remainderValue;

                    totalPrice += totalItemsToCalculate * amount;
                }
                else
                {
                    totalPrice += itemCount * amount;
                }
            }

            foreach(var nonPromoItem in _NonPromotionItems)
            {
                totalPrice += _rules.Where(r => r.ItemName == nonPromoItem).Select(rs => rs.Price).FirstOrDefault();
            }

            return totalPrice;
        }

        #region Private Methods
        /// <summary>
        /// Creates dictionary with key as discount promo rule and value as items with same promo rule
        /// </summary>
        /// <param name="rules"></param>
        private void LoadItemsWithCount(IEnumerable<Rule> rules)
        {
            foreach (var rule in rules)
            {
                if (rulesDict.Any(d => d.Key.NumberOfItemToBuy == rule.NumberOfItemToBuy &&
                d.Key.NumberItemsForFree == rule.NumberItemsForFree))
                {
                    var itemList = rulesDict.Where(d => d.Key.NumberItemsForFree == rule.NumberItemsForFree &&
                    d.Key.NumberOfItemToBuy == rule.NumberOfItemToBuy).Select(d => d.Value).ToList().FirstOrDefault();

                    itemList.Add(rule.ItemName);
                }
                else
                {
                    if (rule.NumberOfItemToBuy > 0 && rule.NumberItemsForFree > 0)
                    {
                        RuleItem ruleItem = new RuleItem { NumberOfItemToBuy = rule.NumberOfItemToBuy, NumberItemsForFree = rule.NumberItemsForFree };
                        rulesDict[ruleItem] = new List<string> { rule.ItemName };
                    }
                }
            }
        }
        #endregion
    }
}
