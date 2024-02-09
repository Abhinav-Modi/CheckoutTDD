using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutTDDAssignment
{
    public class Checkout
    {
        private readonly Dictionary<string, int> _cart;
        private readonly PriceTable _priceTable;

        public Checkout(PriceTable priceTable)
        {
            _cart = new Dictionary<string, int>();
            _priceTable = priceTable;
        }

        public void Scan(string skus)
        {
            foreach (char sku in skus)
            {
                string upperCaseSku = sku.ToString().ToUpper();
                if (_cart.ContainsKey(upperCaseSku))
                {
                    _cart[upperCaseSku]++;
                }
                else
                {
                    _cart[upperCaseSku] = 1;
                }
            }
        }



        public double CalculateTotal()
        {
            double total = 0;
            foreach (var item in _cart)
            {
                string sku = item.Key;
                int quantity = item.Value;
                IPriceRule rule = _priceTable.GetPriceRule(sku);
                if (rule != null)
                {
                    total += rule.Apply(quantity);
                }
            }
            return total;
        }
    }
}
