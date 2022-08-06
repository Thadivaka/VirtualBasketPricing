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
        public CalculatePrice(IEnumerable<Rule> rules)
        {
            _rules = rules;
            
        }
        public int GetTotalPrice(IList<string> items)
        {
            int totalPrice = 0;

            foreach (var item in items)
            {
                var itemsToBuy = _rules.Where(r => r.ItemName == item).Select(x => x.NumberOfItemToBuy).FirstOrDefault();
                var itemsFree = _rules.Where(r => r.ItemName == item).Select(x => x.NumberItemsForFree).FirstOrDefault();
                var itemPrice = _rules.Where(r => r.ItemName == item).Select(x => x.Price).FirstOrDefault();
                var totalItems = itemsFree + itemsToBuy;
                var itemCount = items.Count;
                if (itemCount == totalItems)
                {
                    var quoientValue = (itemCount / totalItems) * itemsToBuy;
                    var remainderValue = itemCount % totalItems;

                    var totalItemsToCalculate = (quoientValue + remainderValue) * itemPrice;

                    totalPrice += totalItemsToCalculate;
                    break;
                }
                else
                {
                    totalPrice += itemCount * itemPrice;
                    break;
                }
            }
            return totalPrice;
        }
    }
}
