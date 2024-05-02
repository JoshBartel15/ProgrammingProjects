using CerealPart;

string[] sent = File.ReadAllLines("Cereal_Data.txt");

List<Cereal> cereals = new List<Cereal>();

for (int i = 1; i < sent.Length; i++)
{
    Cereal C = new Cereal();
    // 0        1           2      3
    //name|manufacturer|calories|cups
    string[] partsofLine = sent[i].Split('|');

    string name = partsofLine[0];
    string manufacturer = partsofLine[1];
    double calories = Convert.ToDouble(partsofLine[2]);
    double cups = Convert.ToDouble(partsofLine[3]);
    
    C.Manufacturer = manufacturer;
    C.Calories = calories;
    C.Cups = cups;
    C.Name = name;

    cereals.Add(C);
}

Console.WriteLine("Cereals with more than 1 cup of serving sizes:");
foreach (Cereal cereal in cereals)
{
    if (cereal.Cups >= 1)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{cereal.Name}{cereal.Manufacturer} {cereal.Calories} {cereal.Cups}");
    }
}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Cereals with less than 100 calores:");
foreach (Cereal cereal in cereals)
{
    if (100 >= cereal.Calories)
    {
        Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"{cereal.Name} {cereal.Manufacturer} {cereal.Calories} {cereal.Cups}");
    }
}

