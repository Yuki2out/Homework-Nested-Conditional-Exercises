int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermenCount = int.Parse(Console.ReadLine());

double price = 0.0;

switch (season)
{
    case "Spring":
        price = 3000.0;
        break;
    case "Summer":
    case "Autumn":
        price = 4200.0;
        break;
    case "Winter":
        price = 2600.0;
        break;
}

if (fishermenCount <= 6)
{
    price *= 0.9;
}
else if (fishermenCount <= 11)
{
    price *= 0.85;
}
else
{
    price *= 0.75;
}

if (fishermenCount % 2 == 0 && season != "Autumn")
{
    price *= 0.95;
}

double difference = Math.Abs(budget - price);

if (budget >= price)
{
    Console.WriteLine($"Yes! You have {difference:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
}