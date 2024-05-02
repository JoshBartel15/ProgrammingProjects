using ClassParticipation;

Toy t = new Toy();
t.Name = "Top";
t.Manufacturer = "Tykes";
t.Price= 29.99;

Console.WriteLine($"The toy name is {t.Name} by {t.Manufacturer} for {t.Price}");
Console.WriteLine($"The aisle is: {t.GetAisle()}");
Console.WriteLine($"{t.TakeNotes("The toy is fun")}");

Toy t2 = new Toy();
t2.Name = "Crayon";
t2.Manufacturer = "Crayola";
t2.Price = 2.99;

Console.WriteLine($"The toy name is {t2.Name} by {t2.Manufacturer} for {t2.Price}");
Console.WriteLine($"The aisle is:{t2.GetAisle()}");
Console.WriteLine($"{t2.TakeNotes("The toy works well")}");
