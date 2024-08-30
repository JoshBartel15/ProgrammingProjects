
Console.WriteLine("Please enter a directory path");
string path = Console.ReadLine();

while (Directory.Exists(path) == false)
{
    Console.WriteLine("Please enter a valid directory that exists");
    path = Console.ReadLine();
}

DirectoryInfo directoryInfo = new DirectoryInfo(path);

foreach (var file in directoryInfo.GetFiles())
{
    Console.WriteLine(file.Name);
}