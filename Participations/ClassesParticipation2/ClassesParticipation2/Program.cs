using ClassesParticipation2;



string[] carlist = File.ReadAllLines("Cars.csv");

List<Car> cars = new List<Car>();
for (int i = 1; i < carlist.Length; i++)
{
    Car c = new Car();
    //Make,Model,Year,Color,VIN,Price
    string[] cl = carlist[i].Split(',');
    
    string Make = cl[0];
    string Model = cl[1];
    int  Year = Convert.ToInt32(cl[2]);
    string Color = cl[3];
    string VIN = cl[4];
    double Price = Convert.ToDouble(cl[5]);

    c.Make = Make;
    c.Model = Model;
    c.Year = Year;
    c.Color = Color;
    c.VIN = VIN;
    c.Price = Price;

    cars.Add(c);
}

foreach (Car ca in cars)
{
    if (ca.Year > 1999)
    {
        Console.WriteLine(ca);
    }
}