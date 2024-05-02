bool leave = false;
Random rand = new Random();
Console.WriteLine("Please input minimum value >>");
string answer = Console.ReadLine();
int minvalue = 0;

while (int.TryParse(answer, out minvalue) == false)
{
    Console.WriteLine("Input valid number");
    answer = Console.ReadLine();
}

Console.WriteLine("Please input maximum value >>");
answer = Console.ReadLine();
int maxvalue = 0;

while (int.TryParse(answer, out maxvalue) == false)
{
    Console.WriteLine("Input valid number");
    answer = Console.ReadLine();
}

int randomnumber = rand.Next(minvalue, maxvalue + 1);
do
{
    Console.WriteLine($"Guess a number between {minvalue} and {maxvalue} >>");
    answer = Console.ReadLine();
    int guess = 0;

    while (int.TryParse(answer, out guess) == false)
    {
        Console.WriteLine("Input valid number");
        answer = Console.ReadLine();
    }

    if (guess == randomnumber)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Correct! >>");
        leave = true;
    }
    else
    {
        Console.WriteLine("Incorrect, Please try again >>");
    }
    

} while (leave == false);