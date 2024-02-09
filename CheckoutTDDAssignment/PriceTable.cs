using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutTDDAssignment
{
    public class PriceTable
    {
        private readonly Dictionary<string, IPriceRule> _rules;

        public PriceTable()
        {
            _rules = new Dictionary<string, IPriceRule>
        {
            { "A", new MultiPriceRule(3,  130,50) },
            { "B", new MultiPriceRule(2,  45, 30) },
            { "C", new SinglePriceRule(20) },
            { "D", new SinglePriceRule(15) }
        };
        }

        public IPriceRule GetPriceRule(string sku)
        {
            return _rules.TryGetValue(sku, out var rule) ? rule : null;
        }
    }
}
