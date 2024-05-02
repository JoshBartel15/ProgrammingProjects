string[] csubj = new string[3];
int[] cnumber = new int[3];

for (int i = 0; i < csubj.Length; i++)
{
    Console.WriteLine("Please input a course subject? >>");
    string subject = Console.ReadLine();

    csubj[i] = subject;

    Console.WriteLine("Please input a course number? >>");
    int number = Convert.ToInt32(Console.ReadLine());

    cnumber[i] = number;
}

for (int i = 0; i < csubj.Length; i++)
{
    Console.WriteLine($"{csubj[i]}{cnumber[i]}");
}