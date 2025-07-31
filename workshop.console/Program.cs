// Arrays - we don't really use them that much?
string[] games = { "Doom", "Tomb Raider", "Half Life" };

foreach (string game in games)
{
    Console.WriteLine(game);
}

//games[3] = "Pacman";  ??

string[] resizedGames = new string[games.Length + 1];
Array.Copy(games, resizedGames, games.Length);
resizedGames[resizedGames.Length - 1] = "Portal";

foreach (string game in resizedGames)
{
    Console.WriteLine(game);

}

//Lists - we use a lot!
List<string> cars = new List<string> { "Mini Clubman", "Tesla Cyber Truck", "VW Beetle" };
cars.Add("VW Up");
cars.Add("Fiat 500");

foreach (string car in cars)
{
    Console.WriteLine(car);
}

