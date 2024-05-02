using System.Xml.Schema;

Console.WriteLine("How many bank accounts do you have? >>");
string answer = Console.ReadLine();
int account = 0;

while (int.TryParse(answer, out account) == false)
{
    Console.WriteLine("Invalid Input. Please Put a Whole Number.");
    answer= Console.ReadLine();
}

int i = 0;
double balance = 0;
double total = 0;

while (i < account)
{
    i++;
    Console.WriteLine($"How much is in bank account {i.ToString("N0")}?");
    answer = Console.ReadLine();
    
    while (double.TryParse(answer, out balance) == false)
    {
        Console.WriteLine("Invalid Input. Please Put a Number.");
        answer=Console.ReadLine();
    }

    total += balance;
}


double averageamt = total/ account;
if (averageamt >= 5000)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Your average balance per account is {averageamt.ToString("C2")}");
}
else
{
    Console.WriteLine($"Your average balance per account is {averageamt.ToString("C2")}");
}
