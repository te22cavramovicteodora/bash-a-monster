Paladin thePaladin = new Paladin();
Monster theMonster = new Monster();

Console.WriteLine($"{thePaladin.name} has {thePaladin.health} healths");
Console.WriteLine($"{theMonster.name} has {theMonster.health} health and {theMonster.size} size");

Console.WriteLine("ATTACK!");
theMonster.health -= 10;

Console.WriteLine($"{theMonster.name} now has {theMonster.health} health");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();