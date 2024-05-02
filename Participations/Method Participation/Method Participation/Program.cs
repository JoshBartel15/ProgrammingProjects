
Console.WriteLine("Enter a type of animal. >>");
string answer = Console.ReadLine();

string noise = Speak(answer);
Console.WriteLine(noise);

string Speak(string makes)
{
    if (answer.ToLower() == "dog")
    {
        return makes = "The dog goes ruff!";
    }
    else if (answer.ToLower() == "monkey")
    {
        return makes = "The monkey goes ooh ooh ahh ahh!";
    }
    else if (answer.ToLower()== "cow")
    {
        return makes = "The cow goes moooooo!";
    }
    else
    {
        return makes = "The " +answer +  " goes ahhhhhhh";
    }
}