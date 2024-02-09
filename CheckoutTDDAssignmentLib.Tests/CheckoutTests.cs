using System.Reflection;
using Xunit;


namespace CheckoutTDDAssignment
{
    public class CheckoutTests
    {
        private readonly PriceTable _priceTable;
        private readonly Checkout _checkout;

        public CheckoutTests()
        {
            _priceTable = new PriceTable();
            _checkout = new Checkout(_priceTable);
        }

        [Theory]
        // Adding a single item to the cart
        [InlineData("A", 50)]
        [InlineData("B", 30)]
        //Adding multiple quantities of the same item to the cart
        [InlineData("AA", 100)]
        [InlineData("BB", 45)]
        // Applying a special offer to the cart
        [InlineData("AAA", 130)]
        //Mixing items with and without special offers
        [InlineData("ABABA", 175)]
        //Handling items with no special offers
        [InlineData("CD", 35)]
        public void ShouldCalculateCorrectTotal(string skus, double expectedTotal)
        {
            // Act
            foreach (char sku in skus)
            {
                _checkout.Scan(sku.ToString());
            }

            // Assert
            Assert.Equal(expectedTotal, _checkout.CalculateTotal());
        }
        
        [Fact]
        public void EmptyCartScenario_ShouldHaveZeroTotal()
        {
            // Assert
            Assert.Equal(0, _checkout.CalculateTotal());
        }

        [Fact]
        public void InvalidInputScenario_ShouldHaveZeroTotal()
        {
            // Act
            _checkout.Scan("Z");

            // Assert
            Assert.Equal(0, _checkout.CalculateTotal());
        }
    }
}
