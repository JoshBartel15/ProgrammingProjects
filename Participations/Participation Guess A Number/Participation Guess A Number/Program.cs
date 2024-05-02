bool ExitApplication = false;
Random rand = new Random();

Console.WriteLine("Input a number for the minimum range.");
string answer = Console.ReadLine();
int minrandomnumber;

if (int.TryParse(answer, out minrandomnumber) == false)
{
    Console.WriteLine("Sorry that is an invalid answer, Please put a number. Bye.");
    Environment.Exit(1);
}
Console.WriteLine("Input a number for the maximum range.");
answer= Console.ReadLine();
int maxrandomnumber;

if (int.TryParse(answer, out maxrandomnumber) == false)
{
    Console.WriteLine("Sorry that is an invalid answer, Please put a number. Bye.");
    Environment.Exit(1);
}
int randomnumber = rand.Next(minrandomnumber, maxrandomnumber + 1);

do
{ 
Console.WriteLine($"Guess a number between {minrandomnumber} and {maxrandomnumber}.");
answer = Console.ReadLine();
int useranswer;

if(int.TryParse(answer, out useranswer) == false)
{
    Console.WriteLine("Sorry that is an invalid answer, Please put a number. Bye.");
    Environment.Exit(1);
}

    if (useranswer == randomnumber)
    {
       Console.ForegroundColor= ConsoleColor.Magenta;
        Console.WriteLine("Correct");
        ExitApplication= true;
    }
    else
    {
        Console.WriteLine("Incorrect, try again.");
    }
} while (ExitApplication == false); 



