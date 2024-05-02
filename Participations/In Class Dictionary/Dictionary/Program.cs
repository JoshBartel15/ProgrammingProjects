Dictionary<string, double> coursecode =new Dictionary<string, double>();


List<double> misgrades = new List<double>();
List<double> mgtgrades = new List<double>();

misgrades.Add(95);
misgrades.Add(87);
misgrades.Add(75);

double mistotal = 0;
foreach (double item in misgrades )
{
    mistotal+= item;
}
double misavggrade = mistotal/ misgrades.Count();

misgrades.Add(93);
misgrades.Add(85);
misgrades.Add(73);

double mgttotal = 0;
foreach (double item in mgtgrades)
{
    mgttotal += item;
}
double mgtavggrade = mgttotal / mgtgrades.Count();

coursecode.Add("MIS3013", misavggrade);
coursecode.Add("MIS3353", mgtavggrade);
coursecode.Add("MKT3013", .98);

foreach (var item in coursecode)
{
    Console.WriteLine(item);
}