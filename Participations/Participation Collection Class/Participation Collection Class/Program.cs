List<string> states = new List<string>();

do
{
    Console.WriteLine("What state have you lived in?");
    string astate = Console.ReadLine();
    states.Add(astate);

    Console.WriteLine("Have you lived in another state? Yes or No.");

} while (Console.ReadLine().ToLower()[0] == 'y');

Console.WriteLine($"You have lived in {states.Count} states");


int max = 0;
foreach (string astate in states)
{
    if (astate.Length > max)
    {
        max = astate.Length;

    }

}
    foreach (string astate in states)
    {
    if (astate.Length == max)
    {
        Console.WriteLine($"The longest state name is {astate.ToUpper()}({astate.ToUpper()[0]}{astate.ToUpper()[1]})");
    }
    }

