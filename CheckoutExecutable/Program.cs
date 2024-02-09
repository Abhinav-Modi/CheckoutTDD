namespace CheckoutTDDAssignment
{
    public static class Program
    {
        public static void Main()
        {
            var priceTable = new PriceTable();
            var checkout = new Checkout(priceTable);

            Console.Write("Enter SKU: ");
            string input = Console.ReadLine().Trim().ToUpper();

            checkout.Scan(input);
            Console.WriteLine($"Total: {checkout.CalculateTotal()}");
        }
    }
}

