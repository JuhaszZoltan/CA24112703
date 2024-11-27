Console.ForegroundColor = ConsoleColor.DarkBlue;

string name = "Zoltan";
Console.WriteLine($"Hello GitHub, my name is {name}!");
Console.WriteLine("Hello tanar ur");

List<string> cats = ["Tercsi", "Fercsi", "Kata", "Klára"];
Console.WriteLine($"a random cat name: {cats[Random.Shared.Next(cats.Count)]}");