double degrees = double.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();
string outfit = "";
string shoes = "";

if (10 <= degrees && degrees <= 18)
{
    switch (timeOfDay)
    {
        case "Morning":
            outfit = "Sweatshirt";
            shoes = "Sneakers";

            break;
        case "Afternoon":
            outfit = "Shirt";
            shoes = "Moccasins";

            break;

        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";

            break;
    }
}else if (18 < degrees && degrees <= 24)
{
    switch (timeOfDay)
    {
        case "Morning":
            outfit = "Shirt";
            shoes = "Moccasins";

            break;
        case "Afternoon":
            outfit = "T-Shirt";
            shoes = "Sandals";

            break;

        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";

            break;
    }
}else if ( degrees >= 25)
{
    switch (timeOfDay)
    {
        case "Morning":
            outfit = "T-Shirt";
            shoes = "Sandals";

            break;
        case "Afternoon":
            outfit = "Swim Suit";
            shoes = "Barefoot";

            break;

        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";

            break;
    }
}
Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");