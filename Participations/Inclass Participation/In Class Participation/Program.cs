using Microsoft.VisualBasic;

Console.WriteLine("Hello, what is your name?");
string answer = Console.ReadLine();

enum direction : byte
{
    north = 1,
    south = 2,
    west = 3,
    east = 4
}