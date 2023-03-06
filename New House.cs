string flowerType = Console.ReadLine();
int flowerCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double flowerPrice = 0;

switch (flowerType)
{
    case "Roses":
        flowerPrice = 5;
        if (flowerCount > 80)
        {
            flowerPrice *= 0.9;
        }
        break;
    case "Dahlias":
        flowerPrice = 3.80;
        if (flowerCount > 90)
        {
            flowerPrice *= 0.85;
        }
        break;
    case "Tulips":
        flowerPrice = 2.80;
        if (flowerCount > 80)
        {
            flowerPrice *= 0.85;
        }
        break;
    case "Narcissus":
        flowerPrice = 3;
        if (flowerCount < 120)
        {
            flowerPrice *= 1.15;
        }
        break;
    case "Gladiolus":
        flowerPrice = 2.50;
        if (flowerCount < 80)
        {
            flowerPrice *= 1.2;
        }
        break;
    default:
        Console.WriteLine("Invalid flower type.");
        return;
}

double totalPrice = flowerPrice * flowerCount;

if (budget >= totalPrice)
{
    double remainingBudget = budget - totalPrice;
    Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {remainingBudget:f2} leva left.");
}
else
{
    double neededMoney = totalPrice - budget;
    Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
}