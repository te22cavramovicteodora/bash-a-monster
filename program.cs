Stephanie theStephanie = new Stephanie();
NikocadoAvocado theNikocadoAvocado = new NikocadoAvocado();

Console.WriteLine($"{theStephanie.name} has {theStephanie.health} healths");
Console.WriteLine($"{theNikocadoAvocado.name} has {theNikocadoAvocado.health} health and {theNikocadoAvocado.size} size");

Console.WriteLine("ATTACK!");
theNikocadoAvocado.health -= 10;

Console.WriteLine($"{theNikocadoAvocado.name} now has {theNikocadoAvocado.health} health");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();