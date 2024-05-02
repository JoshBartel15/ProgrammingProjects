Random r = new Random();

int flip = r.Next(1, 2 + 1);

Console.WriteLine("Heads or Tails?");
string guess = Console.ReadLine().ToLower();

Console.WriteLine(flip);

if (flip == 1 && guess[0] == 'h')
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You guessed correctly!");
}
else if (flip == 2 && guess == "Tails")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You guessed correctly!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You guessed incorrectly");
}
Console.WriteLine("Room40");
//minimum value is inclusive and maximum value is exclusive
//assign heads to 1 and tails to 2 using an if statement
//use && clause in if statement to test multiple conditions
