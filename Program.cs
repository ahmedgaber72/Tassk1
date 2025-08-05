Console.Write("Number of small carpets: ");
int numSmall = Convert.ToInt32(Console.ReadLine());
Console.Write("Number of large carpets: ");
int numLarge = Convert.ToInt32(Console.ReadLine());
int priceSm = numSmall * 25;
int priceLr = numLarge * 35;
Console.WriteLine($"Price per small room: $25");
Console.WriteLine($"Price per large room: $35");
int sum = priceLr + priceSm;
Console.WriteLine($"Cost: {sum}$");
double tax = .06 * sum;
Console.WriteLine($"Tax: {tax}$");
Console.WriteLine($"========================");
double total = sum + tax;
Console.WriteLine($"Total estimate: ${total}$");

Console.WriteLine($"This estimate is valid for 30 days");


