using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutTDDAssignment
{
    public class SinglePriceRule : IPriceRule
    {
        private readonly double _unitPrice;

        public SinglePriceRule(double unitPrice)
        {
            _unitPrice = unitPrice;
        }

        public double Apply(int count) => count * _unitPrice;
    }
}
