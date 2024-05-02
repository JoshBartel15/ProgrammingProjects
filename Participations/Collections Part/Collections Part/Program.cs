List<double> grades = new List<double>();

do
{
        Console.WriteLine("What was your exam grade? >>");
        double examgrade = Convert.ToDouble(Console.ReadLine());
        grades.Add(examgrade);


    Console.WriteLine("Would you like to add another exam grade? >>");
} while (Console.ReadLine().ToLower()[0] == 'y');

double min = grades[0];
double max = grades[0];
double total = 0;
foreach (double examgrade in grades)
{
    total += examgrade;

    if (examgrade < min)
    {
        min = examgrade;
    }
    if (examgrade > max)
    {
        max = examgrade;
    }
}
double avg = total / grades.Count;
double avggrade = avg / 100;
double maxgrade = max / 100;
double mingrade = min / 100;

Console.WriteLine($"Your exam grade average is {avggrade.ToString("P2")}");
Console.WriteLine($"Your exam grade max is {maxgrade.ToString("P2")}");
Console.WriteLine($"Your exam grade min is {mingrade.ToString("P2")}");





