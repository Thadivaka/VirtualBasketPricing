using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBasketPricing
{
    public class Rule
    {
        public string ItemName { get; set; }
        public int Price { get; set; }
        public int NumberOfItemToBuy { get; set; }
        public int NumberItemsForFree { get; set; }
    }
}
