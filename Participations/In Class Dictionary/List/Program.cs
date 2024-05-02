List<double> grades= new List<double>();

do
{
    Console.WriteLine("Please input a grade. >>");
    double grade = Convert.ToDouble(Console.ReadLine());
    grades.Add(grade);

    Console.WriteLine("Do you have another grade to add?");
 
} while (Console.ReadLine().ToLower()[0] == 'y');

double total = 0;
foreach (double item in grades)
{
    total += item;
}

double avggrade = total/grades.Count();
double pavggrade = avggrade / 100;

Console.WriteLine($"Your grade average is {pavggrade.ToString("P2")}");