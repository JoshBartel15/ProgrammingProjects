string answer;
do
{
Console.WriteLine("Please give me a word >>");
string word = Console.ReadLine();

string newword = word.Replace("e", "EEE");

Console.WriteLine(newword);
Console.WriteLine("Do you want to go again? Yes or no");
answer = Console.ReadLine();
} while (answer.ToLower()[0] == 'y');