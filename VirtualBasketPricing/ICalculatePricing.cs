using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBasketPricing
{
    public interface ICalculatePricing
    {
        int GetTotalPrice(IList<string> items);
    }
}
