using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutTDDAssignment
{
    public class MultiPriceRule : IPriceRule
    {
        private readonly int _offerQuantity;
        private readonly double _offerPrice;
        private readonly double _basePrice;

        public MultiPriceRule(int offerQuantity, double offerPrice, double basePrice)
        {
            _offerQuantity = offerQuantity;
            _offerPrice = offerPrice;
            _basePrice = basePrice;
        }

        public double Apply(int count)
        {
            int fullOffers = count / _offerQuantity;
            int remainder = count % _offerQuantity;
            return fullOffers * _offerPrice + remainder * _basePrice;
        }

    }
}
