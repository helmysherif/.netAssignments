const double pricePerSmall = 25;
const double pricePerLarge = 35;
const double taxRate = 0.06;
const int estimateValidity = 30;
Console.WriteLine("Estimate for carpet cleaning service");
Console.WriteLine("---------------------------------");
Console.Write("Enter number of small carpets: ");
int smallCarpets = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of large carpets: ");
int largeCarpets = Convert.ToInt32(Console.ReadLine());
double costSmall = smallCarpets * pricePerSmall;
double costLarge = largeCarpets * pricePerLarge;
double totalCost = costSmall + costLarge;
double tax = totalCost * taxRate;
double totalEstimate = totalCost + tax;
Console.WriteLine("\nEstimate for carpet cleaning service");
Console.WriteLine($"Number of small carpets: {smallCarpets}");
Console.WriteLine($"Number of large carpets: {largeCarpets}");
Console.WriteLine($"Price per small carpet: ${pricePerSmall}");
Console.WriteLine($"Price per large carpet: ${pricePerLarge}");
Console.WriteLine($"Cost: ${totalCost}");
Console.WriteLine($"Tax: ${tax}");
Console.WriteLine("====================================");
Console.WriteLine($"Total estimate: ${totalEstimate}");
Console.WriteLine($"This estimate is valid for {estimateValidity} days");

// search task
/*
 * 1️- Why is the output of this equation formatted as "$30.00"?
    Because of the format specifier {value:F2}.
      - "F" means Fixed-point format.
      - "2" means exactly 2 digits after the decimal.
    Example: 
      double x = 30;
      Console.WriteLine($"{x:F2}");   // prints → 30.00
    This forces the number to always show two decimal places, 
    even if it is a whole number.

    2️ What is the benefit?
      - Ensures consistent money formatting.
      - Prevents output like "30" or "30.0"
      - Makes financial values look clean, professional, and readable.
      - Important in business apps where money MUST always show cents.
    
    * 3️- Another example with a different specifier + screenshot:
    * double exampleValue = 1234.56789;
      Console.WriteLine($"{exampleValue:N2}"); // prints: 1,234.57
 */