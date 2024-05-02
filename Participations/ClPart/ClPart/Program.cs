using ClPart;

string[] ds = File.ReadAllLines("Pharmaceutical Drugs.csv");
List<Drug> dlist = new List<Drug>();
for (int i = 1; i < ds.Length; i++)
{
    Drug d = new Drug();
        //Name,Company,Brand,Code,StreetName
        string[] pieces = ds[i].Split(',');
        d.Name = pieces[0];
        d.Company = pieces[1];
        d.Brand = pieces[2];
        d.Code = Convert.ToInt32(pieces[3]);
        d.StreetName = pieces[4];
        
        dlist.Add(d);
}
    foreach (Drug item in dlist)
    {
        Console.WriteLine(item.Name);
    }
    Console.WriteLine($"\nWhat drug would you like to see?");
    string answer = Console.ReadLine();

    foreach (Drug names in dlist)
    {
        if (answer == names.Name)
        {
            Console.WriteLine(names);
        }
    }



