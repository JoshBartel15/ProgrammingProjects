Console.WriteLine("Heads or Tails?");
string UserChoice = Console.ReadLine();


Random rand = new Random();

int randomNumber = rand.Next(1, 2 + 1);


if (randomNumber == 1 && UserChoice == "Heads")
{
    Console.WriteLine("Correct");
    Console.WriteLine("The coin landed on Heads!");
}

else if (randomNumber == 2 && UserChoice == "Tails")
{
    Console.WriteLine("Correct");
    Console.WriteLine("The coin landed on Tails!");
}
else
{
    Console.WriteLine("Incorrect");
}


const string Developer_I = "Josh Bartel";

Console.WriteLine(Developer_I);