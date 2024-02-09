namespace CheckoutTDDAssignment
{
    public static class Program
    {
        public static void Main()
        {
            var priceTable = new PriceTable();
            var checkout = new Checkout(priceTable);

            while (true)
            {
                Console.Write("Enter SKU (or 'q' to quit): ");
                string input = Console.ReadLine().Trim().ToUpper();

                if (input == "Q")
                {
                    break;
                }

                checkout.Scan(input);
                Console.WriteLine($"Total: {checkout.CalculateTotal()}");
            }
        }
    }
}
