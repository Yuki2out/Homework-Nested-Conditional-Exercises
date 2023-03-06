string projectionType = Console.ReadLine();
int numbOfRows = int.Parse(Console.ReadLine());
int numbOfColumns = int.Parse(Console.ReadLine());
double totalIncome = 0;

switch (projectionType)
{
    case "Premiere":
        totalIncome = (numbOfRows * numbOfColumns) * 12.00;
        break;
    case "Normal":
        totalIncome = (numbOfRows * numbOfColumns) * 7.50;
        break;
    case "Discount":
        totalIncome = (numbOfRows * numbOfColumns) * 5.00;
        break;
    default:
        break;
}
Console.WriteLine($"{totalIncome:f2}");