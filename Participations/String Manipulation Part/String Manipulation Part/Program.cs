string sent = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs,and the universe trying to build bigger and better idiots. So far, the universe is winning.";

Console.WriteLine(sent);
Console.WriteLine("What word would you like to search for in the sentence? >>");
string search = Console.ReadLine();

Console.WriteLine("Which word would you like to replace it with? >>");
string replace = Console.ReadLine();

for (int i = 0; i < sent.Length; i++)
{
    if (sent.Contains(search) == true)
    {
        sent = sent.Replace(search, replace);
        Console.WriteLine(sent);
        Environment.Exit(-1);
    }
}
for (int i = search.Length-1; i >= 0; i--)
{
    Console.Write(search[i]);
}


