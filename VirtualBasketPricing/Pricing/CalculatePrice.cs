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
            throw new NotImplementedException();
        }
    }
}
