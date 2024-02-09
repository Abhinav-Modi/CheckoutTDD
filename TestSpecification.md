# Checkout Kata Problem Test Specifications

## Test Case  1: Adding a single item to the cart

- **GET**: An empty shopping cart
- **WHEN**: The user scans a single item (e.g., "A")
- **THEN**: The total price should be equal to the price of the single item (e.g., £50)

## Test Case  2: Adding multiple quantities of the same item to the cart

- **GET**: An empty shopping cart
- **WHEN**: The user scans multiple quantities of the same item (e.g., "AA")
- **THEN**: The total price should be equal to the sum of the prices of each item (e.g., £100)

## Test Case  3: Applying a special offer to the cart

- **GET**: An empty shopping cart
- **WHEN**: The user scans a sufficient number of items to trigger a special offer (e.g., "AAA" for item "A")
- **THEN**: The total price should reflect the special offer price (e.g., £130 instead of £150)

## Test Case  4: Mixing items with and without special offers

- **GET**: An empty shopping cart
- **WHEN**: The user scans a mix of items with and without special offers (e.g., "ABABA")
- **THEN**: The total price should be calculated correctly, taking into account both regular and special offer prices (e.g., £175)

## Test Case  5: Handling items with no special offers

- **GET**: An empty shopping cart
- **WHEN**: The user scans items that do not have a special offer (e.g., "CD")
- **THEN**: The total price should be the sum of the prices of each item (e.g., £35)

## Test Case  6: Empty cart scenario

- **GET**: An empty shopping cart
- **WHEN**: The user checks the total price without scanning any items
- **THEN**: The total price should be zero (£0)

## Test Case  7: Invalid input scenario

- **GET**: An empty shopping cart
- **WHEN**: The user attempts to scan an invalid SKU (e.g., "Z")
- **THEN**: The system should handle the invalid input gracefully, either ignoring it or displaying an error message
