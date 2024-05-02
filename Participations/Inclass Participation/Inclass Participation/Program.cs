Console.WriteLine("Put in a whole number for a minimum value >>");
string answer = Console.ReadLine();
int minvalue = 0;

while (int.TryParse(answer, out minvalue) == false)
{
    Console.WriteLine("Please put in a whole number >>");
    answer = Console.ReadLine();
}

Console.WriteLine("Put in a whole number for a maximum value >>");
answer = Console.ReadLine();
int maxvalue = 0;
while (int.TryParse(answer, out maxvalue) == false)
{
    Console.WriteLine("Please put in a whole number >>");
    answer = Console.ReadLine();
}
Random rand = new Random();

int randomnumber = rand.Next(minvalue, maxvalue + 1);


Console.WriteLine($"Guess a number between {minvalue} and {maxvalue}. >>"); 
answer = Console.ReadLine();
int guess = 0;

while (int.TryParse(answer, out guess) == false)
{
    Console.WriteLine("Please put in a whole number >>");
    answer = Console.ReadLine();
}

while (guess != randomnumber)
{
    Console.WriteLine("Incorrect, please try again!");
    answer = Console.ReadLine();    
}
